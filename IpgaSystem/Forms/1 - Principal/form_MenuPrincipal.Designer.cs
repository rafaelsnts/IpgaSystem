namespace IpgaSystem
{
    partial class form_MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirMembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ministériosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirMinistériosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new DevExpress.XtraEditors.PanelControl();
            this.novoCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.membrosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.ministériosToolStripMenuItem,
            this.cargosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // membrosToolStripMenuItem
            // 
            this.membrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem,
            this.exibirMembrosToolStripMenuItem});
            this.membrosToolStripMenuItem.Name = "membrosToolStripMenuItem";
            this.membrosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.membrosToolStripMenuItem.Text = "Membros";
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoCadastroToolStripMenuItem.Text = "Novo Cadastro";
            this.novoCadastroToolStripMenuItem.Click += new System.EventHandler(this.novoCadastroToolStripMenuItem_Click);
            // 
            // exibirMembrosToolStripMenuItem
            // 
            this.exibirMembrosToolStripMenuItem.Name = "exibirMembrosToolStripMenuItem";
            this.exibirMembrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirMembrosToolStripMenuItem.Text = "Exibir Membros";
            this.exibirMembrosToolStripMenuItem.Click += new System.EventHandler(this.exibirMembrosToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // ministériosToolStripMenuItem
            // 
            this.ministériosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem1,
            this.exibirMinistériosToolStripMenuItem});
            this.ministériosToolStripMenuItem.Name = "ministériosToolStripMenuItem";
            this.ministériosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ministériosToolStripMenuItem.Text = "Ministérios";
            // 
            // exibirMinistériosToolStripMenuItem
            // 
            this.exibirMinistériosToolStripMenuItem.Name = "exibirMinistériosToolStripMenuItem";
            this.exibirMinistériosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirMinistériosToolStripMenuItem.Text = "Exibir Ministérios";
            this.exibirMinistériosToolStripMenuItem.Click += new System.EventHandler(this.exibirMinistériosToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem2,
            this.exibirCargosToolStripMenuItem});
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cargosToolStripMenuItem.Text = "Cargos";
            // 
            // exibirCargosToolStripMenuItem
            // 
            this.exibirCargosToolStripMenuItem.Name = "exibirCargosToolStripMenuItem";
            this.exibirCargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirCargosToolStripMenuItem.Text = "Exibir Cargos";
            this.exibirCargosToolStripMenuItem.Click += new System.EventHandler(this.exibirCargosToolStripMenuItem_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1270, 668);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // novoCadastroToolStripMenuItem1
            // 
            this.novoCadastroToolStripMenuItem1.Name = "novoCadastroToolStripMenuItem1";
            this.novoCadastroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novoCadastroToolStripMenuItem1.Text = "Novo Cadastro";
            this.novoCadastroToolStripMenuItem1.Click += new System.EventHandler(this.novoCadastroToolStripMenuItem1_Click);
            // 
            // novoCadastroToolStripMenuItem2
            // 
            this.novoCadastroToolStripMenuItem2.Name = "novoCadastroToolStripMenuItem2";
            this.novoCadastroToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.novoCadastroToolStripMenuItem2.Text = "Novo Cadastro";
            this.novoCadastroToolStripMenuItem2.Click += new System.EventHandler(this.novoCadastroToolStripMenuItem2_Click);
            // 
            // form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 692);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPGA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirMembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ministériosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirMinistériosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem2;
    }
}