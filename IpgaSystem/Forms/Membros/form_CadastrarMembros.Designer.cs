namespace IpgaSystem.Forms.Membros
{
    partial class form_CadastrarMembros
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
            this.txtNomeMembro = new DevExpress.XtraEditors.TextEdit();
            this.dtDataCadastro = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCadastrarMembro = new DevExpress.XtraEditors.SimpleButton();
            this.chkBatizado = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtDataNascimento = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtDataBatismo = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMembro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBatizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataBatismo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeMembro
            // 
            this.txtNomeMembro.Location = new System.Drawing.Point(32, 124);
            this.txtNomeMembro.Name = "txtNomeMembro";
            this.txtNomeMembro.Size = new System.Drawing.Size(163, 22);
            this.txtNomeMembro.TabIndex = 0;
            // 
            // dtDataCadastro
            // 
            this.dtDataCadastro.EditValue = null;
            this.dtDataCadastro.Location = new System.Drawing.Point(32, 60);
            this.dtDataCadastro.Name = "dtDataCadastro";
            this.dtDataCadastro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataCadastro.Size = new System.Drawing.Size(163, 22);
            this.dtDataCadastro.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 15);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data de Cadastro:";
            // 
            // btnCadastrarMembro
            // 
            this.btnCadastrarMembro.Location = new System.Drawing.Point(129, 368);
            this.btnCadastrarMembro.Name = "btnCadastrarMembro";
            this.btnCadastrarMembro.Size = new System.Drawing.Size(172, 38);
            this.btnCadastrarMembro.TabIndex = 3;
            this.btnCadastrarMembro.Text = "Cadastrar";
            this.btnCadastrarMembro.Click += new System.EventHandler(this.btnCadastrarMembro_Click);
            // 
            // chkBatizado
            // 
            this.chkBatizado.Location = new System.Drawing.Point(33, 305);
            this.chkBatizado.Name = "chkBatizado";
            this.chkBatizado.Properties.Caption = "Sim";
            this.chkBatizado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkBatizado.Size = new System.Drawing.Size(106, 20);
            this.chkBatizado.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 15);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Nome:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(249, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 15);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Data de Nascimento:";
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.EditValue = null;
            this.dtDataNascimento.Location = new System.Drawing.Point(249, 60);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataNascimento.Size = new System.Drawing.Size(163, 22);
            this.dtDataNascimento.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(249, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 15);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(249, 124);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(163, 22);
            this.txtEndereco.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(249, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 15);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(249, 195);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(163, 22);
            this.txtTelefone.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(33, 174);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 15);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(33, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(249, 283);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 15);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Data de Batismo:";
            // 
            // dtDataBatismo
            // 
            this.dtDataBatismo.EditValue = null;
            this.dtDataBatismo.Location = new System.Drawing.Point(249, 304);
            this.dtDataBatismo.Name = "dtDataBatismo";
            this.dtDataBatismo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataBatismo.Size = new System.Drawing.Size(163, 22);
            this.dtDataBatismo.TabIndex = 20;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 235);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(422, 23);
            this.separatorControl1.TabIndex = 22;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 254);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(347, 17);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "O membro é batizado? Se sim, informar data de batismo.";
            // 
            // form_CadastrarMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 432);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.dtDataBatismo);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.chkBatizado);
            this.Controls.Add(this.btnCadastrarMembro);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtDataCadastro);
            this.Controls.Add(this.txtNomeMembro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_CadastrarMembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Membros";
            this.Load += new System.EventHandler(this.form_CadastrarMembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMembro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBatizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataBatismo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNomeMembro;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtDataCadastro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarMembro;
        private DevExpress.XtraEditors.CheckEdit chkBatizado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtDataNascimento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtDataBatismo;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}