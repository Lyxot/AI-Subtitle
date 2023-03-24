namespace VideoTranslateProgram
{
    partial class helpPage
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
            this.childFormContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.childFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // childFormContainer
            // 
            this.childFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.childFormContainer.Controls.Add(this.label1);
            this.childFormContainer.Controls.Add(this.LOGO);
            this.childFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormContainer.Location = new System.Drawing.Point(0, 0);
            this.childFormContainer.Name = "childFormContainer";
            this.childFormContainer.Size = new System.Drawing.Size(1042, 638);
            this.childFormContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "←拖拽这里移动窗口";
            // 
            // LOGO
            // 
            this.LOGO.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGO.Enabled = false;
            this.LOGO.Image = global::VideoTranslateProgram.Properties.Resources.translate;
            this.LOGO.Location = new System.Drawing.Point(388, 187);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(256, 256);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 0;
            this.LOGO.TabStop = false;
            // 
            // helpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 638);
            this.Controls.Add(this.childFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "helpPage";
            this.Text = "helpPage";
            this.childFormContainer.ResumeLayout(false);
            this.childFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Panel childFormContainer;
        private System.Windows.Forms.Label label1;
    }
}