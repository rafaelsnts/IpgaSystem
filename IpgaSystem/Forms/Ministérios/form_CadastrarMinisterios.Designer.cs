namespace IpgaSystem.Forms.Ministérios
{
    partial class form_CadastrarMinisterios
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCadastrarMinisterio = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricaoMinisterio = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeMinisterio = new DevExpress.XtraEditors.TextEdit();
            this.dtDataCriacao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoMinisterio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMinisterio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCriacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCriacao.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nome:";
            // 
            // btnCadastrarMinisterio
            // 
            this.btnCadastrarMinisterio.Location = new System.Drawing.Point(23, 215);
            this.btnCadastrarMinisterio.Name = "btnCadastrarMinisterio";
            this.btnCadastrarMinisterio.Size = new System.Drawing.Size(188, 22);
            this.btnCadastrarMinisterio.TabIndex = 2;
            this.btnCadastrarMinisterio.Text = "Cadastrar";
            this.btnCadastrarMinisterio.Click += new System.EventHandler(this.btnCadastrarMinisterio_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Descrição:";
            // 
            // txtDescricaoMinisterio
            // 
            this.txtDescricaoMinisterio.Location = new System.Drawing.Point(23, 156);
            this.txtDescricaoMinisterio.Name = "txtDescricaoMinisterio";
            this.txtDescricaoMinisterio.Size = new System.Drawing.Size(188, 22);
            this.txtDescricaoMinisterio.TabIndex = 3;
            // 
            // txtNomeMinisterio
            // 
            this.txtNomeMinisterio.Location = new System.Drawing.Point(23, 97);
            this.txtNomeMinisterio.Name = "txtNomeMinisterio";
            this.txtNomeMinisterio.Size = new System.Drawing.Size(188, 22);
            this.txtNomeMinisterio.TabIndex = 0;
            // 
            // dtDataCriacao
            // 
            this.dtDataCriacao.EditValue = null;
            this.dtDataCriacao.Location = new System.Drawing.Point(23, 38);
            this.dtDataCriacao.Name = "dtDataCriacao";
            this.dtDataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataCriacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataCriacao.Size = new System.Drawing.Size(188, 22);
            this.dtDataCriacao.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 15);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Data Criação";
            // 
            // form_CadastrarMinisterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 258);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtDataCriacao);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDescricaoMinisterio);
            this.Controls.Add(this.btnCadastrarMinisterio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeMinisterio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_CadastrarMinisterios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Ministério";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoMinisterio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMinisterio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCriacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCriacao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNomeMinisterio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarMinisterio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescricaoMinisterio;
        private DevExpress.XtraEditors.DateEdit dtDataCriacao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}