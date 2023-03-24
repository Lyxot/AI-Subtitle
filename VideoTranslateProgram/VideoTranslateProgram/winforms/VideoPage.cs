using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using VideoTranslateProgram.winforms;
namespace VideoTranslateProgram
{
    public partial class VideoPage : Form
    {
        private static string outputPath;
        private static string videoPath;
        private static string fileName;
        private ConfigHelper cfgh;
        public string srtContent;

        //public string audioURL = "http://101.132.75.22/小王子.mp3";
        public string audioURL;
        public VideoPage()
        {
            InitializeComponent();
        }
        public VideoPage(ConfigHelper cfghelper)
        {
            cfgh = cfghelper;
            outputPath = cfghelper.GetConfigKey("defaultOutputPath");
            InitializeComponent();
        }

        private void VideoPage_Load(object sender, EventArgs e)
        {
            videoPathTextBox.Text = videoPath;
            outputTextBox.Text = outputPath;
        }



        private void buttonSelectVideo_Click(object sender, EventArgs e)
        {
            //打开窗口选择文件
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            videoPath = fileDialog.FileName;
            fileName = videoPath.Substring(videoPath.LastIndexOf("\\") + 1);
            videoPathTextBox.Text = videoPath;
            Console.WriteLine(fileName);
        }
        //用户输入文件地址
        private void videoPathTextBox_TextChanged(object sender, EventArgs e)
        {
            videoPath = videoPathTextBox.Text;
            fileName = videoPath.Substring(videoPath.LastIndexOf("\\") + 1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //打开窗口选择文件
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            outputPath = folderBrowserDialog.SelectedPath;
            outputTextBox.Text = outputPath;
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
            outputPath = outputTextBox.Text;
        }

        private void buttonSetDefaultPath_Click(object sender, EventArgs e)
        {
            cfgh.SetConfigKey("defaultOutputPath", outputPath);
        }

        public int renderVideo()
        {
            try
            {
                StateWND stateform = new StateWND();
                stateform.Show();
                stateform.updateState(StateWND.state.toAudio);
                string audioPath = outputPath + "\\" + fileName.Substring(0, fileName.LastIndexOf("."));
                //将视频转换成音频
                ProcessStartInfo info1 = new ProcessStartInfo();
                info1.FileName = Application.StartupPath + "\\ffmpeg.exe";
                info1.Arguments = "-i \"" + videoPath + "\" -f mp3 -ar 16000 -ab 160 \"" + audioPath + ".mp3\" -y";
                Console.WriteLine(info1.FileName + info1.Arguments);
                info1.UseShellExecute = false;
                info1.WindowStyle = ProcessWindowStyle.Minimized;
                //info1.CreateNoWindow = true;
                Process pro1 = Process.Start(info1);
                pro1.WaitForExit();


                //上传部分
                FileUpLoad fu = new FileUpLoad();
                string result = fu.uploadFileByHttp(Config.UPLOAD_SERVER, audioPath + ".mp3");
                if (result != "true")
                {
                    MessageBox.Show(result);
                    return -1;
                }
                //audioURL = upLoadFile(audioPath);
                stateform.updateState(StateWND.state.upload);


                //提取、翻译
                Console.WriteLine(Config.DOWNLOAD_SERVER + fileName.Substring(0, fileName.LastIndexOf(".")) + ".mp3");
                srtContent = VideoTrans.VideoTranslate(Config.DOWNLOAD_SERVER + fileName.Substring(0, fileName.LastIndexOf(".")) + ".mp3", stateform);

                stateform.updateState(StateWND.state.render);
                //写入字幕文件
                string srtPath = string.Format("{0}\\{1}.srt", outputPath, fileName.Substring(0, fileName.LastIndexOf(".")));
                ////创建一个文件，并给这个文件写值
                if (!File.Exists(srtPath))
                {
                    FileStream fs = new FileStream(srtPath, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    //开始写入  
                    sw.WriteLine(srtContent);
                    //清空缓冲区  
                    sw.Flush();
                    //关闭流  
                    sw.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(srtPath, FileMode.Open, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    //开始写入  
                    sw.WriteLine(srtContent);
                    //清空缓冲区  
                    sw.Flush();
                    //关闭流  
                    sw.Close();
                    fs.Close();
                }



                Console.WriteLine(srtContent);
                //渲染字幕
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = Application.StartupPath + "\\ffmpeg.exe";
                info.Arguments = String.Format("-i \"{0}\" -filter_complex \"subtitles=\\'{1}/{2}.srt\\'\" -c:a copy \"{3}\\{4}\" -y", videoPath, outputPath.Replace("\\", "/").Replace(":", "\\:"), fileName.Substring(0, fileName.LastIndexOf(".")), outputPath, fileName);
                Console.WriteLine(info.FileName + info.Arguments);
                info.UseShellExecute = false;
                info.WindowStyle = ProcessWindowStyle.Minimized;
                //info.CreateNoWindow = true;
                Process pro = Process.Start(info);
                pro.WaitForExit();
                stateform.updateState(StateWND.state.finished);
                if (MessageBox.Show("渲染完成，是否打开输出文件夹？", "Render complicated", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    OpenFolderAndSelectedFile(outputPath + "\\" + fileName);
                }
                return pro.ExitCode;
            }
            catch
            {
                return -1;
            }

        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            renderVideo();
        }
        /// <summary>
        /// 打开目录且选中文件
        /// </summary>
        /// <param name="filePathAndName">文件的路径和名称（比如：C:\Users\Administrator\test.txt）</param>
        private static void OpenFolderAndSelectedFile(string filePathAndName)
        {
            if (string.IsNullOrEmpty(filePathAndName)) return;

            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + filePathAndName;
            process.StartInfo = psi;

            //process.StartInfo.UseShellExecute = true;
            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                process?.Close();

            }
        }
    }
}
