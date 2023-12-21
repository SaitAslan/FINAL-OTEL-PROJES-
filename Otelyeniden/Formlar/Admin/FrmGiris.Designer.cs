namespace Otelyeniden.Formlar.Admin
{
    partial class FrmGiris
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Otelyeniden.Formlar.Admin.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit9 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtKullanici = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager2
            // 
            splashScreenManager2.ClosingDelay = 500;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnGiris);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.pictureEdit3);
            this.groupControl2.Controls.Add(this.TxtSifre);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.pictureEdit9);
            this.groupControl2.Controls.Add(this.TxtKullanici);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(373, 160);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.ImageOptions.Image = global::Otelyeniden.Properties.Resources.record_32x32;
            this.BtnGiris.Location = new System.Drawing.Point(121, 99);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(229, 41);
            this.BtnGiris.TabIndex = 6;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Şifreniz";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(5, 63);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit3.TabIndex = 14;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(121, 60);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.UseSystemPasswordChar = true;
            this.TxtSifre.Size = new System.Drawing.Size(229, 22);
            this.TxtSifre.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(31, 15);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 16);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Kullanıcı Adınız";
            // 
            // pictureEdit9
            // 
            this.pictureEdit9.EditValue = ((object)(resources.GetObject("pictureEdit9.EditValue")));
            this.pictureEdit9.Location = new System.Drawing.Point(5, 15);
            this.pictureEdit9.Name = "pictureEdit9";
            this.pictureEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit9.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit9.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit9.Size = new System.Drawing.Size(20, 20);
            this.pictureEdit9.TabIndex = 10;
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(121, 13);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(229, 22);
            this.TxtKullanici.TabIndex = 1;
            // 
            // FrmGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 160);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanici.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PictureEdit pictureEdit9;
        private DevExpress.XtraEditors.TextEdit TxtKullanici;
    }
}