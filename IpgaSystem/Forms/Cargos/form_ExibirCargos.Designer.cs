namespace IpgaSystem.Forms.Cargos
{
    partial class form_ExibirCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ExibirCargos));
            this.gridCargos = new DevExpress.XtraGrid.GridControl();
            this.viewCargos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupCargos = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnNovoCargo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCargos
            // 
            this.gridCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCargos.Location = new System.Drawing.Point(0, 0);
            this.gridCargos.MainView = this.viewCargos;
            this.gridCargos.Name = "gridCargos";
            this.gridCargos.Size = new System.Drawing.Size(514, 308);
            this.gridCargos.TabIndex = 0;
            this.gridCargos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCargos});
            // 
            // viewCargos
            // 
            this.viewCargos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.viewCargos.GridControl = this.gridCargos;
            this.viewCargos.Name = "viewCargos";
            this.viewCargos.OptionsBehavior.Editable = false;
            this.viewCargos.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.viewCargos_PopupMenuShowing);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CARGOS";
            this.gridColumn1.FieldName = "car_nome";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "car_id";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // popupCargos
            // 
            this.popupCargos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovoCargo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcluir)});
            this.popupCargos.Manager = this.barManager1;
            this.popupCargos.Name = "popupCargos";
            // 
            // btnNovoCargo
            // 
            this.btnNovoCargo.Caption = "Novo Cargo";
            this.btnNovoCargo.Id = 0;
            this.btnNovoCargo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNovoCargo.ImageOptions.SvgImage")));
            this.btnNovoCargo.Name = "btnNovoCargo";
            this.btnNovoCargo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoCargo_ItemClick);
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
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNovoCargo,
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
            this.barDockControlTop.Size = new System.Drawing.Size(514, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 308);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(514, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 308);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(514, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 308);
            // 
            // form_ExibirCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 308);
            this.Controls.Add(this.gridCargos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_ExibirCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCargos;
        private DevExpress.XtraGrid.Views.Grid.GridView viewCargos;
        private DevExpress.XtraBars.PopupMenu popupCargos;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnNovoCargo;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnExcluir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}