namespace VideoTranslateProgram
{
    partial class mainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.SidebarContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.homeContainer = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.home_Video = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.childFormContainer = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.SidebarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.homeContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.childFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.sidebar.Controls.Add(this.SidebarContainer);
            this.sidebar.Controls.Add(this.homeContainer);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(5, 5);
            this.sidebar.MaximumSize = new System.Drawing.Size(270, 99999);
            this.sidebar.MinimumSize = new System.Drawing.Size(83, 520);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(270, 687);
            this.sidebar.TabIndex = 0;
            this.sidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidebar_MouseDown);
            // 
            // SidebarContainer
            // 
            this.SidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SidebarContainer.Controls.Add(this.label1);
            this.SidebarContainer.Controls.Add(this.menuButton);
            this.SidebarContainer.Location = new System.Drawing.Point(3, 3);
            this.SidebarContainer.Name = "SidebarContainer";
            this.SidebarContainer.Size = new System.Drawing.Size(267, 135);
            this.SidebarContainer.TabIndex = 0;
            this.SidebarContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SIdebarContainer_MouseDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "菜单";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::VideoTranslateProgram.Properties.Resources.menu__1_;
            this.menuButton.Location = new System.Drawing.Point(13, 39);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(52, 45);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // homeContainer
            // 
            this.homeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.homeContainer.Controls.Add(this.panel6);
            this.homeContainer.Controls.Add(this.panel1);
            this.homeContainer.Controls.Add(this.homePanel);
            this.homeContainer.Location = new System.Drawing.Point(3, 144);
            this.homeContainer.MaximumSize = new System.Drawing.Size(267, 168);
            this.homeContainer.MinimumSize = new System.Drawing.Size(267, 57);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(267, 57);
            this.homeContainer.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3);
            this.panel6.Location = new System.Drawing.Point(1, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 45);
            this.panel6.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::VideoTranslateProgram.Properties.Resources.subject;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-10, -7);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(287, 70);
            this.button3.TabIndex = 1;
            this.button3.Text = "             软字幕";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.home_Video);
            this.panel1.Location = new System.Drawing.Point(1, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 45);
            this.panel1.TabIndex = 4;
            // 
            // home_Video
            // 
            this.home_Video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Video.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.home_Video.ForeColor = System.Drawing.Color.White;
            this.home_Video.Image = global::VideoTranslateProgram.Properties.Resources.subject;
            this.home_Video.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Video.Location = new System.Drawing.Point(-10, -7);
            this.home_Video.Name = "home_Video";
            this.home_Video.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.home_Video.Size = new System.Drawing.Size(287, 70);
            this.home_Video.TabIndex = 1;
            this.home_Video.Text = "             硬字幕";
            this.home_Video.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Video.UseVisualStyleBackColor = false;
            this.home_Video.Click += new System.EventHandler(this.home_Video_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.buttonHome);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(268, 57);
            this.homePanel.TabIndex = 3;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::VideoTranslateProgram.Properties.Resources.home_outline__2_;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(-10, -7);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(287, 70);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "             主页";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.aboutButton);
            this.panel5.Location = new System.Drawing.Point(3, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 57);
            this.panel5.TabIndex = 6;
            // 
            // aboutButton
            // 
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = global::VideoTranslateProgram.Properties.Resources.info_circle;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(-10, -7);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(287, 70);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "             关于";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 10;
            this.homeTimer.Tick += new System.EventHandler(this.homeTimer_Tick);
            // 
            // childFormContainer
            // 
            this.childFormContainer.Controls.Add(this.LOGO);
            this.childFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormContainer.Location = new System.Drawing.Point(275, 5);
            this.childFormContainer.Name = "childFormContainer";
            this.childFormContainer.Size = new System.Drawing.Size(857, 687);
            this.childFormContainer.TabIndex = 1;
            this.childFormContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.childFormContainer_MouseDown);
            // 
            // LOGO
            // 
            this.LOGO.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGO.Enabled = false;
            this.LOGO.Image = global::VideoTranslateProgram.Properties.Resources.translate;
            this.LOGO.Location = new System.Drawing.Point(295, 211);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(256, 256);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.buttonMin.Image = global::VideoTranslateProgram.Properties.Resources.window_min_line;
            this.buttonMin.Location = new System.Drawing.Point(1063, 12);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Padding = new System.Windows.Forms.Padding(0, 0, 2, 15);
            this.buttonMin.Size = new System.Drawing.Size(25, 25);
            this.buttonMin.TabIndex = 2;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.buttonClose.Image = global::VideoTranslateProgram.Properties.Resources.close_outline;
            this.buttonClose.Location = new System.Drawing.Point(1099, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 57);
            this.panel4.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::VideoTranslateProgram.Properties.Resources.bx_help_circle;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-10, -7);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(287, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "             帮助";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::VideoTranslateProgram.Properties.Resources.setting;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-10, -7);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(287, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "             设置";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 57);
            this.panel2.TabIndex = 4;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1137, 697);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.childFormContainer);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(870, 520);
            this.Name = "mainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoTranslate";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.sidebar.ResumeLayout(false);
            this.SidebarContainer.ResumeLayout(false);
            this.SidebarContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.homeContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.childFormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel SidebarContainer;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel homeContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home_Video;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Panel childFormContainer;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}

