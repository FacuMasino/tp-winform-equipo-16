namespace WindowsForms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblProjectRepo = new System.Windows.Forms.LinkLabel();
            this.pnlMaxi = new WindowsForms.RoundPanel();
            this.pbxGHMaxi = new System.Windows.Forms.PictureBox();
            this.pbxLnMaxi = new System.Windows.Forms.PictureBox();
            this.lblNameMaxi = new System.Windows.Forms.Label();
            this.pbxMaxi = new System.Windows.Forms.PictureBox();
            this.pnlFacu = new WindowsForms.RoundPanel();
            this.pbxGHFacu = new System.Windows.Forms.PictureBox();
            this.pbxLnFacu = new System.Windows.Forms.PictureBox();
            this.lblFacuName = new System.Windows.Forms.Label();
            this.pbxFacu = new System.Windows.Forms.PictureBox();
            this.pnlAna = new WindowsForms.RoundPanel();
            this.pbxGHAna = new System.Windows.Forms.PictureBox();
            this.pbxLnAna = new System.Windows.Forms.PictureBox();
            this.lblAnaName = new System.Windows.Forms.Label();
            this.pbxAna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.pnlAbout.SuspendLayout();
            this.pnlMaxi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGHMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxi)).BeginInit();
            this.pnlFacu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGHFacu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLnFacu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFacu)).BeginInit();
            this.pnlAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGHAna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLnAna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAna)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(105, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TP WinForm - Grupo 16";
            // 
            // pbxAppIcon
            // 
            this.pbxAppIcon.BackgroundImage = global::WindowsForms.Properties.Resources.AppIcon;
            this.pbxAppIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAppIcon.Location = new System.Drawing.Point(30, 24);
            this.pbxAppIcon.Name = "pbxAppIcon";
            this.pbxAppIcon.Size = new System.Drawing.Size(60, 60);
            this.pbxAppIcon.TabIndex = 1;
            this.pbxAppIcon.TabStop = false;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.lblProjectRepo);
            this.pnlAbout.Controls.Add(this.pnlMaxi);
            this.pnlAbout.Controls.Add(this.pnlFacu);
            this.pnlAbout.Controls.Add(this.pnlAna);
            this.pnlAbout.Controls.Add(this.lblCredits);
            this.pnlAbout.Controls.Add(this.lblVersion);
            this.pnlAbout.Controls.Add(this.lblCopyright);
            this.pnlAbout.Controls.Add(this.pbxAppIcon);
            this.pnlAbout.Controls.Add(this.lblTitle);
            this.pnlAbout.Location = new System.Drawing.Point(12, 12);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(502, 524);
            this.pnlAbout.TabIndex = 2;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(107, 106);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(105, 15);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "Desarrollado por:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(107, 73);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(68, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versión 1.0";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(107, 52);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(186, 15);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright 2024 - Licencia GNU";
            // 
            // lblProjectRepo
            // 
            this.lblProjectRepo.AutoSize = true;
            this.lblProjectRepo.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectRepo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(104)))), ((int)(((byte)(243)))));
            this.lblProjectRepo.Location = new System.Drawing.Point(181, 73);
            this.lblProjectRepo.Name = "lblProjectRepo";
            this.lblProjectRepo.Size = new System.Drawing.Size(145, 15);
            this.lblProjectRepo.TabIndex = 6;
            this.lblProjectRepo.TabStop = true;
            this.lblProjectRepo.Text = "Repositorio del proyecto";
            this.lblProjectRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProjectRepo_LinkClicked);
            // 
            // pnlMaxi
            // 
            this.pnlMaxi.BackColor = System.Drawing.Color.Transparent;
            this.pnlMaxi.BackgroundColor = System.Drawing.Color.White;
            this.pnlMaxi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.pnlMaxi.BorderWidth = 1F;
            this.pnlMaxi.Controls.Add(this.pbxGHMaxi);
            this.pnlMaxi.Controls.Add(this.pbxLnMaxi);
            this.pnlMaxi.Controls.Add(this.lblNameMaxi);
            this.pnlMaxi.Controls.Add(this.pbxMaxi);
            this.pnlMaxi.Location = new System.Drawing.Point(110, 261);
            this.pnlMaxi.Name = "pnlMaxi";
            this.pnlMaxi.Radius = 10;
            this.pnlMaxi.Size = new System.Drawing.Size(281, 114);
            this.pnlMaxi.TabIndex = 5;
            // 
            // pbxGHMaxi
            // 
            this.pbxGHMaxi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxGHMaxi.BackgroundImage")));
            this.pbxGHMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGHMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGHMaxi.Location = new System.Drawing.Point(138, 60);
            this.pbxGHMaxi.Name = "pbxGHMaxi";
            this.pbxGHMaxi.Size = new System.Drawing.Size(24, 24);
            this.pbxGHMaxi.TabIndex = 5;
            this.pbxGHMaxi.TabStop = false;
            this.pbxGHMaxi.Click += new System.EventHandler(this.pbxGHMaxi_Click);
            // 
            // pbxLnMaxi
            // 
            this.pbxLnMaxi.BackgroundImage = global::WindowsForms.Properties.Resources.LinkedIn_icon;
            this.pbxLnMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLnMaxi.Location = new System.Drawing.Point(108, 60);
            this.pbxLnMaxi.Name = "pbxLnMaxi";
            this.pbxLnMaxi.Size = new System.Drawing.Size(24, 24);
            this.pbxLnMaxi.TabIndex = 4;
            this.pbxLnMaxi.TabStop = false;
            this.pbxLnMaxi.Click += new System.EventHandler(this.pbxLnMaxi_Click);
            // 
            // lblNameMaxi
            // 
            this.lblNameMaxi.AutoSize = true;
            this.lblNameMaxi.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMaxi.Location = new System.Drawing.Point(105, 40);
            this.lblNameMaxi.Name = "lblNameMaxi";
            this.lblNameMaxi.Size = new System.Drawing.Size(174, 16);
            this.lblNameMaxi.TabIndex = 3;
            this.lblNameMaxi.Text = "Malvicino, Maximiliano R.";
            // 
            // pbxMaxi
            // 
            this.pbxMaxi.BackgroundImage = global::WindowsForms.Properties.Resources.MaxiProfilePicRounded;
            this.pbxMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMaxi.Location = new System.Drawing.Point(12, 12);
            this.pbxMaxi.Name = "pbxMaxi";
            this.pbxMaxi.Size = new System.Drawing.Size(90, 90);
            this.pbxMaxi.TabIndex = 0;
            this.pbxMaxi.TabStop = false;
            // 
            // pnlFacu
            // 
            this.pnlFacu.BackColor = System.Drawing.Color.Transparent;
            this.pnlFacu.BackgroundColor = System.Drawing.Color.White;
            this.pnlFacu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.pnlFacu.BorderWidth = 1F;
            this.pnlFacu.Controls.Add(this.pbxGHFacu);
            this.pnlFacu.Controls.Add(this.pbxLnFacu);
            this.pnlFacu.Controls.Add(this.lblFacuName);
            this.pnlFacu.Controls.Add(this.pbxFacu);
            this.pnlFacu.Location = new System.Drawing.Point(110, 381);
            this.pnlFacu.Name = "pnlFacu";
            this.pnlFacu.Radius = 10;
            this.pnlFacu.Size = new System.Drawing.Size(281, 114);
            this.pnlFacu.TabIndex = 5;
            // 
            // pbxGHFacu
            // 
            this.pbxGHFacu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxGHFacu.BackgroundImage")));
            this.pbxGHFacu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGHFacu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGHFacu.Location = new System.Drawing.Point(138, 60);
            this.pbxGHFacu.Name = "pbxGHFacu";
            this.pbxGHFacu.Size = new System.Drawing.Size(24, 24);
            this.pbxGHFacu.TabIndex = 5;
            this.pbxGHFacu.TabStop = false;
            this.pbxGHFacu.Click += new System.EventHandler(this.pbxGHFacu_Click);
            // 
            // pbxLnFacu
            // 
            this.pbxLnFacu.BackgroundImage = global::WindowsForms.Properties.Resources.LinkedIn_icon;
            this.pbxLnFacu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLnFacu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLnFacu.Location = new System.Drawing.Point(108, 60);
            this.pbxLnFacu.Name = "pbxLnFacu";
            this.pbxLnFacu.Size = new System.Drawing.Size(24, 24);
            this.pbxLnFacu.TabIndex = 4;
            this.pbxLnFacu.TabStop = false;
            this.pbxLnFacu.Click += new System.EventHandler(this.pbxLnFacu_Click);
            // 
            // lblFacuName
            // 
            this.lblFacuName.AutoSize = true;
            this.lblFacuName.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacuName.Location = new System.Drawing.Point(105, 40);
            this.lblFacuName.Name = "lblFacuName";
            this.lblFacuName.Size = new System.Drawing.Size(132, 16);
            this.lblFacuName.TabIndex = 3;
            this.lblFacuName.Text = "Masino, Facundo J.";
            // 
            // pbxFacu
            // 
            this.pbxFacu.BackgroundImage = global::WindowsForms.Properties.Resources.FacuProfilePicRounded;
            this.pbxFacu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxFacu.Location = new System.Drawing.Point(12, 12);
            this.pbxFacu.Name = "pbxFacu";
            this.pbxFacu.Size = new System.Drawing.Size(90, 90);
            this.pbxFacu.TabIndex = 0;
            this.pbxFacu.TabStop = false;
            // 
            // pnlAna
            // 
            this.pnlAna.BackColor = System.Drawing.Color.Transparent;
            this.pnlAna.BackgroundColor = System.Drawing.Color.White;
            this.pnlAna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.pnlAna.BorderWidth = 1F;
            this.pnlAna.Controls.Add(this.pbxGHAna);
            this.pnlAna.Controls.Add(this.pbxLnAna);
            this.pnlAna.Controls.Add(this.lblAnaName);
            this.pnlAna.Controls.Add(this.pbxAna);
            this.pnlAna.Location = new System.Drawing.Point(110, 141);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Radius = 10;
            this.pnlAna.Size = new System.Drawing.Size(281, 114);
            this.pnlAna.TabIndex = 4;
            // 
            // pbxGHAna
            // 
            this.pbxGHAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxGHAna.BackgroundImage")));
            this.pbxGHAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGHAna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGHAna.Location = new System.Drawing.Point(138, 60);
            this.pbxGHAna.Name = "pbxGHAna";
            this.pbxGHAna.Size = new System.Drawing.Size(24, 24);
            this.pbxGHAna.TabIndex = 5;
            this.pbxGHAna.TabStop = false;
            this.pbxGHAna.Click += new System.EventHandler(this.pbxGHAna_Click);
            // 
            // pbxLnAna
            // 
            this.pbxLnAna.BackgroundImage = global::WindowsForms.Properties.Resources.LinkedIn_icon;
            this.pbxLnAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLnAna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLnAna.Location = new System.Drawing.Point(108, 60);
            this.pbxLnAna.Name = "pbxLnAna";
            this.pbxLnAna.Size = new System.Drawing.Size(24, 24);
            this.pbxLnAna.TabIndex = 4;
            this.pbxLnAna.TabStop = false;
            this.pbxLnAna.Click += new System.EventHandler(this.pbxLnAna_Click);
            // 
            // lblAnaName
            // 
            this.lblAnaName.AutoSize = true;
            this.lblAnaName.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnaName.Location = new System.Drawing.Point(105, 40);
            this.lblAnaName.Name = "lblAnaName";
            this.lblAnaName.Size = new System.Drawing.Size(108, 16);
            this.lblAnaName.TabIndex = 3;
            this.lblAnaName.Text = "Bertello, Ana C.";
            // 
            // pbxAna
            // 
            this.pbxAna.BackgroundImage = global::WindowsForms.Properties.Resources.AnaProfilePicRounded;
            this.pbxAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAna.Location = new System.Drawing.Point(12, 12);
            this.pbxAna.Name = "pbxAna";
            this.pbxAna.Size = new System.Drawing.Size(90, 90);
            this.pbxAna.TabIndex = 0;
            this.pbxAna.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(539, 547);
            this.Controls.Add(this.pnlAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de - TP WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.pnlMaxi.ResumeLayout(false);
            this.pnlMaxi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGHMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxi)).EndInit();
            this.pnlFacu.ResumeLayout(false);
            this.pnlFacu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGHFacu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLnFacu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFacu)).EndInit();
            this.pnlAna.ResumeLayout(false);
            this.pnlAna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGHAna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLnAna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label lblCopyright;
        private RoundPanel pnlAna;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pbxAna;
        private System.Windows.Forms.PictureBox pbxLnAna;
        private System.Windows.Forms.Label lblAnaName;
        private System.Windows.Forms.PictureBox pbxGHAna;
        private RoundPanel pnlFacu;
        private System.Windows.Forms.PictureBox pbxGHFacu;
        private System.Windows.Forms.PictureBox pbxLnFacu;
        private System.Windows.Forms.Label lblFacuName;
        private System.Windows.Forms.PictureBox pbxFacu;
        private RoundPanel pnlMaxi;
        private System.Windows.Forms.PictureBox pbxGHMaxi;
        private System.Windows.Forms.PictureBox pbxLnMaxi;
        private System.Windows.Forms.Label lblNameMaxi;
        private System.Windows.Forms.PictureBox pbxMaxi;
        private System.Windows.Forms.LinkLabel lblProjectRepo;
    }
}