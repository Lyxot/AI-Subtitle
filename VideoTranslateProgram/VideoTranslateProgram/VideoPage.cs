using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTranslateProgram
{
    public partial class VideoPage : Form
    {
        public VideoPage()
        {
            InitializeComponent();
        }

        private void VideoPage_Load(object sender, EventArgs e)
        {
            videoPathTextBox.Text = videoPath;
            outputTextBox.Text = outputPath;
        }


        private static string videoPath;
        private void buttonSelectVideo_Click(object sender, EventArgs e)
        {
            //打开窗口选择文件
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            videoPath = fileDialog.FileName;
            videoPathTextBox.Text = videoPath;
        }
        //用户输入文件地址
        private void videoPathTextBox_TextChanged(object sender, EventArgs e)
        {
            videoPath = videoPathTextBox.Text;
        }

        private static string outputPath;
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


    }
}
