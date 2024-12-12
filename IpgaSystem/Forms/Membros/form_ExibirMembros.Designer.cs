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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ExibirMembros));
            this.gridMembros = new DevExpress.XtraGrid.GridControl();
            this.viewMembros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMembros = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnNovoMembro = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcluir = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.viewMembros.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.viewMembros_PopupMenuShowing);
            // 
            // popupMembros
            // 
            this.popupMembros.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovoMembro),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcluir)});
            this.popupMembros.Manager = this.barManager1;
            this.popupMembros.Name = "popupMembros";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNovoMembro,
            this.btnEditar,
            this.btnExcluir});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 664);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 664);
            // 
            // btnNovoMembro
            // 
            this.btnNovoMembro.Caption = "Novo Membro";
            this.btnNovoMembro.Id = 0;
            this.btnNovoMembro.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNovoMembro.ImageOptions.SvgImage")));
            this.btnNovoMembro.Name = "btnNovoMembro";
            this.btnNovoMembro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoMembro_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 1;
            this.btnEditar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditar.ImageOptions.SvgImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.Id = 2;
            this.btnExcluir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcluir.ImageOptions.SvgImage")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcluir_ItemClick);
            // 
            // form_ExibirMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.Controls.Add(this.gridMembros);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ExibirMembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ExibirMembros";
            ((System.ComponentModel.ISupportInitialize)(this.gridMembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMembros;
        private DevExpress.XtraGrid.Views.Grid.GridView viewMembros;
        private DevExpress.XtraBars.PopupMenu popupMembros;
        private DevExpress.XtraBars.BarButtonItem btnNovoMembro;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnExcluir;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}