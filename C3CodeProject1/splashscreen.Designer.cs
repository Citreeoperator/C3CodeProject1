namespace C3CodeProject1
{
    partial class splashscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashscreen));
            this.pBar_splash = new System.Windows.Forms.ProgressBar();
            this.tmr_splash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_splash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBar_splash
            // 
            this.pBar_splash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar_splash.Location = new System.Drawing.Point(0, 438);
            this.pBar_splash.Name = "pBar_splash";
            this.pBar_splash.Size = new System.Drawing.Size(473, 23);
            this.pBar_splash.TabIndex = 0;
            // 
            // tmr_splash
            // 
            this.tmr_splash.Enabled = true;
            this.tmr_splash.Tick += new System.EventHandler(this.tmr_splash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_splash
            // 
            this.lbl_splash.AutoSize = true;
            this.lbl_splash.BackColor = System.Drawing.Color.Transparent;
            this.lbl_splash.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_splash.Location = new System.Drawing.Point(217, 423);
            this.lbl_splash.Name = "lbl_splash";
            this.lbl_splash.Size = new System.Drawing.Size(38, 13);
            this.lbl_splash.TabIndex = 2;
            this.lbl_splash.Text = "label1";
            // 
            // splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(473, 461);
            this.Controls.Add(this.lbl_splash);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBar_splash);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashscreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar_splash;
        private System.Windows.Forms.Timer tmr_splash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_splash;
    }
}