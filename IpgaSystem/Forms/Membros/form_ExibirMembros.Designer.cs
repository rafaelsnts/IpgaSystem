namespace IpgaSystem.Forms.Membros
{
    partial class form_ExibirMembros
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
            this.gridMembros = new DevExpress.XtraGrid.GridControl();
            this.viewMembros = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMembros)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMembros
            // 
            this.gridMembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMembros.Location = new System.Drawing.Point(0, 0);
            this.gridMembros.MainView = this.viewMembros;
            this.gridMembros.Name = "gridMembros";
            this.gridMembros.Size = new System.Drawing.Size(1278, 664);
            this.gridMembros.TabIndex = 0;
            this.gridMembros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewMembros});
            // 
            // viewMembros
            // 
            this.viewMembros.GridControl = this.gridMembros;
            this.viewMembros.Name = "viewMembros";
            // 
            // form_ExibirMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.Controls.Add(this.gridMembros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ExibirMembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ExibirMembros";
            ((System.ComponentModel.ISupportInitialize)(this.gridMembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMembros;
        private DevExpress.XtraGrid.Views.Grid.GridView viewMembros;
    }
}