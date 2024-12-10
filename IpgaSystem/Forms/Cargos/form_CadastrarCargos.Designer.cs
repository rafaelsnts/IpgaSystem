namespace IpgaSystem.Forms.Cargos
{
    partial class form_CadastrarCargos
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
            this.txtNomeCargo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCadastrarCargo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCargo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Location = new System.Drawing.Point(13, 47);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(164, 22);
            this.txtNomeCargo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nome:";
            // 
            // btnCadastrarCargo
            // 
            this.btnCadastrarCargo.Location = new System.Drawing.Point(13, 90);
            this.btnCadastrarCargo.Name = "btnCadastrarCargo";
            this.btnCadastrarCargo.Size = new System.Drawing.Size(164, 29);
            this.btnCadastrarCargo.TabIndex = 2;
            this.btnCadastrarCargo.Text = "Cadastrar";
            this.btnCadastrarCargo.Click += new System.EventHandler(this.btnCadastrarCargo_Click);
            // 
            // form_CadastrarCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 148);
            this.Controls.Add(this.btnCadastrarCargo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_CadastrarCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cargo";
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCargo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNomeCargo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarCargo;
    }
}