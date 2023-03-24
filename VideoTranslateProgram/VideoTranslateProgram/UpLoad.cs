using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace VideoTranslateProgram
{
    public class FileUpLoad

    {

        public string uploadFileByHttp(string webUrl, string localFileName)
        {
            // 检查文件是否存在  
            if (!System.IO.File.Exists(localFileName))
            {
                MessageBox.Show(localFileName+" does not exist!");
                return null;
            }
            try
            {
                System.Net.WebClient myWebClient = new System.Net.WebClient();
                myWebClient.UploadFile(webUrl, "POST", localFileName);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "true";
        }
    }
}
