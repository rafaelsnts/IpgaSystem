namespace IpgaSystem.Forms.Ministérios
{
    partial class form_ExibirMinisterios
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
            this.gridMinisterio = new DevExpress.XtraGrid.GridControl();
            this.viewMinisterio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMinisterio = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridMinisterio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMinisterio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMinisterio)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMinisterio
            // 
            this.gridMinisterio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMinisterio.Location = new System.Drawing.Point(0, 0);
            this.gridMinisterio.MainView = this.viewMinisterio;
            this.gridMinisterio.Name = "gridMinisterio";
            this.gridMinisterio.Size = new System.Drawing.Size(1270, 668);
            this.gridMinisterio.TabIndex = 0;
            this.gridMinisterio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewMinisterio});
            // 
            // viewMinisterio
            // 
            this.viewMinisterio.GridControl = this.gridMinisterio;
            this.viewMinisterio.Name = "viewMinisterio";
            // 
            // popupMinisterio
            // 
            this.popupMinisterio.Name = "popupMinisterio";
            // 
            // form_ExibirMinisterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 668);
            this.Controls.Add(this.gridMinisterio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ExibirMinisterios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mnistérios";
            ((System.ComponentModel.ISupportInitialize)(this.gridMinisterio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMinisterio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMinisterio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMinisterio;
        private DevExpress.XtraGrid.Views.Grid.GridView viewMinisterio;
        private DevExpress.XtraBars.PopupMenu popupMinisterio;
    }
}