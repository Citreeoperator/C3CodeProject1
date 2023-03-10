namespace C3CodeProject1
{
    partial class dashboardform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardform));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_timeanddate = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_endorsement = new System.Windows.Forms.Button();
            this.btn_sitrep = new System.Windows.Forms.Button();
            this.btn_cctvreports = new System.Windows.Forms.Button();
            this.btn_cctvreqforms = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.tmr_dash = new System.Windows.Forms.Timer(this.components);
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.pnl_mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.lbl_timeanddate);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1920, 108);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project TBD";
            // 
            // lbl_timeanddate
            // 
            this.lbl_timeanddate.AutoSize = true;
            this.lbl_timeanddate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_timeanddate.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeanddate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_timeanddate.Location = new System.Drawing.Point(1608, 0);
            this.lbl_timeanddate.Name = "lbl_timeanddate";
            this.lbl_timeanddate.Size = new System.Drawing.Size(312, 100);
            this.lbl_timeanddate.TabIndex = 2;
            this.lbl_timeanddate.Text = "MMMM:DD:YYYY \r\nHH:MM:SS";
            this.lbl_timeanddate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.pnl_menu.Controls.Add(this.button1);
            this.pnl_menu.Controls.Add(this.btn_exit);
            this.pnl_menu.Controls.Add(this.btn_endorsement);
            this.pnl_menu.Controls.Add(this.btn_sitrep);
            this.pnl_menu.Controls.Add(this.btn_cctvreports);
            this.pnl_menu.Controls.Add(this.btn_cctvreqforms);
            this.pnl_menu.Controls.Add(this.btn_home);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 108);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(249, 932);
            this.pnl_menu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 559);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.button1.Size = new System.Drawing.Size(249, 108);
            this.button1.TabIndex = 8;
            this.button1.Text = "About";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 791);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_exit.Size = new System.Drawing.Size(249, 108);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_endorsement
            // 
            this.btn_endorsement.Enabled = false;
            this.btn_endorsement.FlatAppearance.BorderSize = 0;
            this.btn_endorsement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_endorsement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endorsement.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_endorsement.Image = ((System.Drawing.Image)(resources.GetObject("btn_endorsement.Image")));
            this.btn_endorsement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_endorsement.Location = new System.Drawing.Point(0, 445);
            this.btn_endorsement.Name = "btn_endorsement";
            this.btn_endorsement.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_endorsement.Size = new System.Drawing.Size(249, 108);
            this.btn_endorsement.TabIndex = 6;
            this.btn_endorsement.Text = "Endorsement \r\nGenerator";
            this.btn_endorsement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_endorsement.UseVisualStyleBackColor = true;
            this.btn_endorsement.Click += new System.EventHandler(this.btn_endorsement_Click);
            // 
            // btn_sitrep
            // 
            this.btn_sitrep.FlatAppearance.BorderSize = 0;
            this.btn_sitrep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sitrep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sitrep.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sitrep.Image = ((System.Drawing.Image)(resources.GetObject("btn_sitrep.Image")));
            this.btn_sitrep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sitrep.Location = new System.Drawing.Point(0, 334);
            this.btn_sitrep.Name = "btn_sitrep";
            this.btn_sitrep.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_sitrep.Size = new System.Drawing.Size(249, 108);
            this.btn_sitrep.TabIndex = 5;
            this.btn_sitrep.Text = "SitRep \r\nGenerator";
            this.btn_sitrep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sitrep.UseVisualStyleBackColor = true;
            this.btn_sitrep.Click += new System.EventHandler(this.btn_sitrep_Click);
            // 
            // btn_cctvreports
            // 
            this.btn_cctvreports.FlatAppearance.BorderSize = 0;
            this.btn_cctvreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cctvreports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cctvreports.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cctvreports.Image = ((System.Drawing.Image)(resources.GetObject("btn_cctvreports.Image")));
            this.btn_cctvreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cctvreports.Location = new System.Drawing.Point(0, 223);
            this.btn_cctvreports.Name = "btn_cctvreports";
            this.btn_cctvreports.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_cctvreports.Size = new System.Drawing.Size(249, 108);
            this.btn_cctvreports.TabIndex = 4;
            this.btn_cctvreports.Text = "CCTV Reports";
            this.btn_cctvreports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cctvreports.UseVisualStyleBackColor = true;
            this.btn_cctvreports.Click += new System.EventHandler(this.btn_cctvreports_Click);
            // 
            // btn_cctvreqforms
            // 
            this.btn_cctvreqforms.FlatAppearance.BorderSize = 0;
            this.btn_cctvreqforms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cctvreqforms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cctvreqforms.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cctvreqforms.Image = ((System.Drawing.Image)(resources.GetObject("btn_cctvreqforms.Image")));
            this.btn_cctvreqforms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cctvreqforms.Location = new System.Drawing.Point(0, 112);
            this.btn_cctvreqforms.Name = "btn_cctvreqforms";
            this.btn_cctvreqforms.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_cctvreqforms.Size = new System.Drawing.Size(249, 108);
            this.btn_cctvreqforms.TabIndex = 3;
            this.btn_cctvreqforms.Text = "CCTV Request";
            this.btn_cctvreqforms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cctvreqforms.UseVisualStyleBackColor = true;
            this.btn_cctvreqforms.Click += new System.EventHandler(this.btn_cctvreqforms_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 1);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_home.Size = new System.Drawing.Size(249, 108);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // tmr_dash
            // 
            this.tmr_dash.Tick += new System.EventHandler(this.tmr_dash_Tick);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.pnl_bottom.Controls.Add(this.lbl_version);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(249, 1006);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1671, 34);
            this.pnl_bottom.TabIndex = 2;
            // 
            // lbl_version
            // 
            this.lbl_version.Location = new System.Drawing.Point(1514, 4);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(157, 30);
            this.lbl_version.TabIndex = 0;
            this.lbl_version.Text = "Version No.";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_mainpanel
            // 
            this.pnl_mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.pnl_mainpanel.Controls.Add(this.pictureBox1);
            this.pnl_mainpanel.Location = new System.Drawing.Point(249, 108);
            this.pnl_mainpanel.Name = "pnl_mainpanel";
            this.pnl_mainpanel.Size = new System.Drawing.Size(1671, 899);
            this.pnl_mainpanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 899);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_mainpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dashboardform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardform";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label lbl_timeanddate;
        private System.Windows.Forms.Timer tmr_dash;
        private System.Windows.Forms.Button btn_endorsement;
        private System.Windows.Forms.Button btn_sitrep;
        private System.Windows.Forms.Button btn_cctvreports;
        private System.Windows.Forms.Button btn_cctvreqforms;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_mainpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label label1;
    }
}