namespace IpgaSystem.Forms.Cargos
{
    partial class form_EditarCargos
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
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeCargo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCargo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 29);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 15);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Nome:";
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Location = new System.Drawing.Point(13, 47);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(164, 22);
            this.txtNomeCargo.TabIndex = 3;
            // 
            // form_EditarCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 148);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_EditarCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Informações";
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCargo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeCargo;
    }
}