namespace IpgaSystem.Forms
{
    partial class form_Logins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Logins));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.btnLogar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(269, 179);
            this.pictureEdit1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "admin";
            this.txtUsuario.Location = new System.Drawing.Point(49, 211);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txtUsuario.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsuario.Properties.Appearance.Options.UseBorderColor = true;
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.txtUsuario.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUsuario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsuario.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Red;
            this.txtUsuario.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtUsuario.Properties.AutoHeight = false;
            this.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUsuario.Size = new System.Drawing.Size(198, 31);
            this.txtUsuario.TabIndex = 10;
            // 
            // btnLogar
            // 
            this.btnLogar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnLogar.Appearance.Options.UseBackColor = true;
            this.btnLogar.Location = new System.Drawing.Point(49, 314);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(198, 32);
            this.btnLogar.TabIndex = 8;
            this.btnLogar.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.EditValue = "admin";
            this.txtSenha.Location = new System.Drawing.Point(50, 258);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtSenha.Properties.Appearance.Options.UseBackColor = true;
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.Appearance.Options.UseForeColor = true;
            this.txtSenha.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSenha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSenha.Properties.AutoHeight = false;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(197, 31);
            this.txtSenha.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl1.ImageOptions.SvgImage")));
            this.labelControl1.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.labelControl1.Location = new System.Drawing.Point(14, 211);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 30);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl2.ImageOptions.SvgImage")));
            this.labelControl2.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.labelControl2.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.labelControl2.Location = new System.Drawing.Point(18, 260);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 26);
            this.labelControl2.TabIndex = 12;
            // 
            // form_Logins
            // 
            this.ActiveGlowColor = System.Drawing.Color.Cyan;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 370);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InactiveGlowColor = System.Drawing.Color.Fuchsia;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form_Logins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.SimpleButton btnLogar;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}