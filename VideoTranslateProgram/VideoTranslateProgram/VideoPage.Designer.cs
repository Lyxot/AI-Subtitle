namespace VideoTranslateProgram
{
    partial class VideoPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectVideo = new System.Windows.Forms.Button();
            this.videoPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectVideo
            // 
            this.buttonSelectVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectVideo.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectVideo.ForeColor = System.Drawing.Color.White;
            this.buttonSelectVideo.Location = new System.Drawing.Point(592, 130);
            this.buttonSelectVideo.Name = "buttonSelectVideo";
            this.buttonSelectVideo.Size = new System.Drawing.Size(86, 32);
            this.buttonSelectVideo.TabIndex = 0;
            this.buttonSelectVideo.Text = "浏览";
            this.buttonSelectVideo.UseVisualStyleBackColor = true;
            this.buttonSelectVideo.Click += new System.EventHandler(this.buttonSelectVideo_Click);
            // 
            // videoPathTextBox
            // 
            this.videoPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.videoPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.videoPathTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.videoPathTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.videoPathTextBox.Location = new System.Drawing.Point(145, 130);
            this.videoPathTextBox.Name = "videoPathTextBox";
            this.videoPathTextBox.Size = new System.Drawing.Size(430, 32);
            this.videoPathTextBox.TabIndex = 1;
            this.videoPathTextBox.Text = "X:\\XXX\\XXX.mp4";
            this.videoPathTextBox.TextChanged += new System.EventHandler(this.videoPathTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "1> 选择视频文件";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "2> 选择输出文件夹";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.outputTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.outputTextBox.Location = new System.Drawing.Point(145, 238);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(430, 32);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "X:\\XXX\\XXX\\";
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(592, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExecute.ForeColor = System.Drawing.Color.White;
            this.buttonExecute.Location = new System.Drawing.Point(337, 361);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(86, 32);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "执行";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonExecute);
            this.panel1.Controls.Add(this.buttonSelectVideo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.videoPathTextBox);
            this.panel1.Controls.Add(this.outputTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 529);
            this.panel1.TabIndex = 7;
            // 
            // VideoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(788, 529);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoPage";
            this.Text = " ";
            this.Load += new System.EventHandler(this.VideoPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectVideo;
        private System.Windows.Forms.TextBox videoPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Panel panel1;
    }
}