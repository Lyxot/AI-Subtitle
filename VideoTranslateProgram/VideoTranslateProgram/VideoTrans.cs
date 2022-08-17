using System;
using Newtonsoft.Json.Linq;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Http;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace VideoTranslateProgram
{
    class VideoTrans
    {
        // 地域ID，固定值。
        public const string REGIONID = "cn-shanghai";
        public const string PRODUCT = "nls-filetrans";
        public const string DOMAIN = "filetrans.cn-shanghai.aliyuncs.com";
        public const string API_VERSION = "2018-08-17";
        public const string POST_REQUEST_ACTION = "SubmitTask";
        public const string GET_REQUEST_ACTION = "GetTaskResult";
        // 请求参数
        public const string KEY_APP_KEY = "appkey";
        public const string KEY_FILE_LINK = "file_link";
        public const string KEY_VERSION = "version";
        public const string KEY_ENABLE_WORDS = "enable_words";
        // 响应参数
        public const string KEY_TASK = "Task";
        public const string KEY_TASK_ID = "TaskId";
        public const string KEY_STATUS_TEXT = "StatusText";
        public const string KEY_RESULT = "Result";
        // 状态值
        public const string STATUS_SUCCESS = "SUCCESS";
        public const string STATUS_RUNNING = "RUNNING";
        public const string STATUS_QUEUEING = "QUEUEING";
        // JSON字段
        public const string KEY_RESULT_LIST = "Sentences";
        public const string KEY_LIST_TIME_BEGIN = "BeginTime";
        public const string KEY_LIST_TIME_END = "EndTime";
        public const string KEY_LIST_TEXT = "Text";
        public const string KEY_LIST_SPEECH_RATE = "SpeechRate";
        static JObject stt(string accessKeyId, string accessKeySecret, string appKey, string fileLink) {
            JObject FailObj = new JObject();
            FailObj[KEY_STATUS_TEXT] = "";
            /**
             * 创建阿里云鉴权对象
             */
            IClientProfile profile = DefaultProfile.GetProfile(
                REGIONID,
                accessKeyId,
                accessKeySecret
                );
            DefaultAcsClient client = new DefaultAcsClient(profile);
            try {
                /**
                 * 创建录音文件识别请求，设置请求参数。
                 */
                CommonRequest request = new CommonRequest();
                request.Domain = DOMAIN;
                request.Version = API_VERSION;
                request.Action = POST_REQUEST_ACTION;
                request.Product = PRODUCT;
                request.Method = MethodType.POST;
                // 设置task，以JSON字符串形式设置到请求Body中。
                JObject obj = new JObject();
                obj[KEY_APP_KEY] = appKey;
                obj[KEY_FILE_LINK] = fileLink;
                // 新接入请使用4.0版本，已接入（默认2.0）如需维持现状，请注释掉该参数设置。
                obj[KEY_VERSION] = "4.0";
                // 设置是否输出词信息，默认为false。开启时需要设置version为4.0。
                obj[KEY_ENABLE_WORDS] = false;
                string task = obj.ToString();
                request.AddBodyParameters(KEY_TASK, task);
                /**
                 * 提交录音文件识别请求，处理服务端返回的响应。
                 */
                CommonResponse response = client.GetCommonResponse(request);
                System.Console.WriteLine(response.Data);
                if (response.HttpStatus != 200) {
                    System.Console.WriteLine("录音文件识别请求失败： " + response.HttpStatus);
                    return FailObj;
                }
                // 获取录音文件识别请求任务ID，以供识别结果查询使用。
                string taskId = "";
                JObject jsonObj = JObject.Parse(response.Data);
                string statusText = jsonObj[KEY_STATUS_TEXT].ToString();
                if (statusText.Equals(STATUS_SUCCESS)) {
                    System.Console.WriteLine("录音文件识别请求成功响应!");
                    taskId = jsonObj[KEY_TASK_ID].ToString();
                }
                else {
                    System.Console.WriteLine("录音文件识别请求失败!");
                    return FailObj ;
                }
                /**
                 * 创建识别结果查询请求，并设置查询参数为任务ID。
                 */
                CommonRequest getRequest = new CommonRequest();
                getRequest.Domain = DOMAIN;
                getRequest.Version = API_VERSION;
                getRequest.Action = GET_REQUEST_ACTION;
                getRequest.Product = PRODUCT;
                getRequest.Method = MethodType.GET;
                getRequest.AddQueryParameters(KEY_TASK_ID, taskId);
                /**
                 * 提交录音文件识别结果查询请求
                 * 以轮询的方式进行识别结果的查询，直到服务端返回的状态描述为“SUCCESS”、“SUCCESS_WITH_NO_VALID_FRAGMENT”，
                 * 或者为错误描述，则结束轮询。
                 */
                JObject jsonObj2 = new JObject();
                statusText = "";
                while (true) {
                    CommonResponse getResponse = client.GetCommonResponse(getRequest);
                    jsonObj2 = JObject.Parse(getResponse.Data);
                    if (!statusText.Equals(jsonObj2[KEY_STATUS_TEXT].ToString())) {
                        statusText = jsonObj2[KEY_STATUS_TEXT].ToString();
                        System.Console.WriteLine(getResponse.Data);
                        if (statusText.Equals(STATUS_QUEUEING)) {
                            // 继续轮询
                            System.Console.WriteLine("录音文件识别请求正在排队中");
                        }
                        if (statusText.Equals(STATUS_RUNNING)) {
                            // 继续轮询
                            System.Console.WriteLine("录音文件识别请求正在识别中");
                        }
                    }
                        
                    if (getResponse.HttpStatus != 200) {
                        System.Console.WriteLine("识别结果查询请求失败，Http错误码：" + getResponse.HttpStatus);
                        break;
                    }
                    
                    if (statusText.Equals(STATUS_RUNNING) || statusText.Equals(STATUS_QUEUEING)) {
                        // 继续轮询
                        System.Threading.Thread.Sleep(500);
                    }
                    else {
                        // 退出轮询
                        break;
                    }
                }
                if (statusText.Equals(STATUS_SUCCESS)) {
                    System.Console.WriteLine("录音文件识别成功！");
                    return jsonObj2;
                }
                else {
                    System.Console.WriteLine("录音文件识别失败！");
                    return FailObj;

                }
            }
            catch (ServerException ex) {
                System.Console.WriteLine(ex.ToString());
                return FailObj;
            }
            catch (ClientException ex) {
                System.Console.WriteLine(ex.ToString());
                return FailObj;
            }
        }
        static string json2srt(JObject json) {
            string result = "";
            JArray result_list = JArray.Parse(json[KEY_RESULT][KEY_RESULT_LIST].ToString());
            double begin_time, end_time;
            int hour, minute, second, msecond;
            JObject translate_result;
            JArray translate_result_list, translate_result_list1;
            string begin_time_f, end_time_f, speech_rate, text, translation;
            for (int i = 0; i < result_list.Count; i++) {
                // 解析json
                begin_time = Convert.ToDouble(result_list[i][KEY_LIST_TIME_BEGIN].ToString()) / 1000;
                end_time = Convert.ToDouble(result_list[i][KEY_LIST_TIME_END].ToString()) / 1000;
                speech_rate = result_list[i][KEY_LIST_SPEECH_RATE].ToString();
                text = result_list[i][KEY_LIST_TEXT].ToString();
                // 时间格式化
                hour = (int)Math.Floor(Convert.ToDecimal(begin_time / 3600));
                minute = (int)Math.Floor(Convert.ToDecimal(begin_time % 3600 / 60));
                second = (int)Math.Floor(Convert.ToDecimal(begin_time % 60));
                msecond = (int)Math.Floor(Convert.ToDecimal((begin_time - Math.Floor(begin_time)) * 1000));
                begin_time_f = hour.ToString().PadLeft(2, '0') + ":" + minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0') + "," + msecond.ToString().PadLeft(3, '0');
                hour = (int)Math.Floor(Convert.ToDecimal(end_time / 3600));
                minute = (int)Math.Floor(Convert.ToDecimal(end_time % 3600 / 60));
                second = (int)Math.Floor(Convert.ToDecimal(end_time % 60));
                msecond = (int)Math.Floor(Convert.ToDecimal((end_time - Math.Floor(end_time)) * 1000));
                end_time_f = hour.ToString().PadLeft(2, '0') + ":" + minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0') + "," + msecond.ToString().PadLeft(3, '0');
                // 翻译
                translate_result = translate(text);
                if (!translate_result["errorCode"].ToString().Equals("0")) {
                    translate_result = translate(text);
                }
                translation = "";
                translate_result_list = JArray.Parse(translate_result["translateResult"].ToString());
                if (translate_result["errorCode"].ToString().Equals("0")) {
                    for (int j = 0; j < translate_result_list.Count; j++) {
                        translate_result_list1 = JArray.Parse(translate_result_list[j].ToString());
                        for (int k = 0; k < translate_result_list1.Count; k++) {
                            translation += translate_result_list1[k]["tgt"];
                        }
                    }
                }
                // 转为srt格式
                result += i.ToString() + "\n" + begin_time_f + " --> " + end_time_f + "\n";
                result += translation + "\n" + text + "\n\n";
            }
            return result;
        }

        static string Md5(string sInput)
        {
            byte[] buffer = Encoding.Default.GetBytes(sInput); //将字符串解析成字节数组，随便按照哪种解析格式都行
            MD5 md5 = MD5.Create();  //使用MD5这个抽象类的Creat()方法创建一个虚拟的MD5类的对象。
            byte[] bufferNew = md5.ComputeHash(buffer); //使用MD5实例的ComputerHash()方法处理字节数组。
            string strNew = null;
            for (int i = 0; i < bufferNew.Length; i++) {
                strNew += bufferNew[i].ToString("x2");  //对bufferNew字节数组中的每个元素进行十六进制转换然后拼接成strNew字符串
            }
            return strNew;  //输出加密后的字符串

        }
        static JObject translate(string text) {
            // 时间戳
            string lts = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds).ToString();
            // 盐值
            Random r = new Random();
            string salt = lts + r.Next(0, 10).ToString();
            // 签名
            string sign_str = "fanyideskweb" + text + salt + "Ygy_4c=r#e#4EX^NUGUc5";
            string sign = Md5(sign_str);
            // request
            string url = "https://fanyi.youdao.com/translate_o?smartresult=dict&smartresult=rule&i="+text+"&from=en&to=zh-CHS&client=fanyideskweb&salt="+salt+"&sign="+sign+"&lts="+lts+"&doctype=json&version=2.1&keyfrom=fanyi.web&action=FY_BY_REALTIME";
            System.Console.WriteLine(url);
            string id = r.Next(10000, 100000).ToString() + r.Next(10000, 100000).ToString() + "@" + r.Next(10, 256).ToString() + "." + r.Next(10, 256).ToString() + "." + r.Next(10, 256).ToString() + "." + r.Next(10, 256).ToString();
            try {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "POST";
                request.Headers.Add("Cookie", "OUTFOX_SEARCH_USER_ID=" + id + ";");
                request.Referer = "http://fanyi.youdao.com/";
                request.Host = "fanyi.youdao.com";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.5060.134 Safari/537.36 Edg/103.0.1264.77";
                request.ReadWriteTimeout = 5000;
                request.KeepAlive = false;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
                string responseText = reader.ReadToEnd();
                reader.Close();
                response.Close();
                if (JObject.Parse(responseText)["errorCode"].ToString().Equals("0"))
                {
                    System.Console.WriteLine("翻译成功: " + text);
                }
                else
                {
                    System.Console.WriteLine("翻译失败: " + text);
                }
                return JObject.Parse(responseText);
            }
            catch (Exception ex)
            {
                JObject FailObj = new JObject();
                FailObj["errorCode"] = "";
                System.Console.WriteLine(ex);
                return FailObj;
            }
        }
        public static string VideoTranslate(string FileLink) {
            JObject SttResult = stt(AliyunKey.ALIYUN_ACCESSKEY_ID, AliyunKey.ALIYUN_ACCESSKEY_SECRET, AliyunKey.ALIYUN_APPKEY, FileLink);
            if (SttResult[KEY_STATUS_TEXT].ToString().Equals(STATUS_SUCCESS)) {
                string SrtResult = json2srt(SttResult);
                return SrtResult;
            }
            else {
                return "";
            }
        }
        // public static void Main(string[] args) {
        //     System.Console.WriteLine(VideoTranslate("http://101.132.75.22/小王子.mp3"));
        // }
    }
}