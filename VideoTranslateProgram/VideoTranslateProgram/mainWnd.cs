using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
namespace VideoTranslateProgram
{
    public partial class mainWindow : Form
    {
        bool sidebarExpand = true;
        bool homeExpand = false;

        private ConfigHelper ConfigHelpers = null;

        public mainWindow()
        {
            InitializeComponent();
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            string configPath = Application.StartupPath + "\\VideoTranslateProgram.exe.config";
            Console.WriteLine(configPath);
            ConfigHelpers = new ConfigHelper(configPath);
            if (ConfigHelpers.GetConfigKey("isFirstStart") == "")
            {
                openChildForm(new helpPage());
                ConfigHelpers.SetConfigKey("isFirstStart", "true");
            }
            else
            {

            }
        }

        //打开新的分窗口
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormContainer.Controls.Add(childForm);
            childFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region 侧边栏
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand,minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        #endregion

        #region home键
        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeExpand)
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeExpand = false;
                    homeTimer.Stop();
                }
            }
            else
            {
                homeContainer.Height += 10;
                if (homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    homeExpand = true;
                    homeTimer.Stop();
                }
            }
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
            if (!sidebarExpand && !homeExpand)
            {
                sidebarTimer.Start();
            }
        }
        #endregion

        #region 无边框窗口
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParan);
        public const int HTCAPTION = 2;
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MOVE = 0xf010;
        //欺骗系统使系统认为点击任务栏，实现无边框拖拽
        private void SIdebarContainer_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void childFormContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void sidebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        //无边框修改窗体大小
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息 
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标 
                    m.LParam = IntPtr.Zero;//默认值 
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内 
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion
        private void FoldSideBar()
        {
            if (sidebarExpand)
            {
                sidebarTimer.Start();
            }
        }
        private void FoldAll()
        {
            if (sidebarExpand)
            {
                sidebarTimer.Start();
            }
            if (homeExpand)
            {
                homeTimer.Start();
            }
        }
        private void aboutButton_Click(object sender, EventArgs e)
        {
            openChildForm(new aboutPage());
            FoldAll();
        }

        private void home_Video_Click(object sender, EventArgs e)
        {
            openChildForm(new VideoPage());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new helpPage());
            FoldAll();
        }
    }
}
