namespace VideoTranslateProgram.winforms
{
    partial class StateWND
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressbarContainer = new System.Windows.Forms.Panel();
            this.progressbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.labelState = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.progressbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.labelState);
            this.panel1.Controls.Add(this.progressbarContainer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // progressbarContainer
            // 
            this.progressbarContainer.BackColor = System.Drawing.SystemColors.Control;
            this.progressbarContainer.Controls.Add(this.progressbar);
            this.progressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressbarContainer.Location = new System.Drawing.Point(0, 427);
            this.progressbarContainer.Name = "progressbarContainer";
            this.progressbarContainer.Size = new System.Drawing.Size(800, 23);
            this.progressbarContainer.TabIndex = 3;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressbar.Location = new System.Drawing.Point(-1, 0);
            this.progressbar.MaximumSize = new System.Drawing.Size(801, 23);
            this.progressbar.MinimumSize = new System.Drawing.Size(0, 23);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(10, 23);
            this.progressbar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 376);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(242, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "处理中...";
            // 
            // progressTimer
            // 
            this.progressTimer.Enabled = true;
            this.progressTimer.Interval = 10;
            this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            this.labelState.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelState.Location = new System.Drawing.Point(299, 362);
            this.labelState.Name = "labelState";
            this.labelState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelState.Size = new System.Drawing.Size(139, 62);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "state";
            // 
            // StateWND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StateWND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateWND";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressbarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel progressbarContainer;
        private System.Windows.Forms.Panel progressbar;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label labelState;
    }
}