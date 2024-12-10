using System;
using System.Windows.Forms;
using IpgaSystem.Forms.Cargos;
using IpgaSystem.Forms.Membros;
using IpgaSystem.Forms.Ministérios;

namespace IpgaSystem
{
    public partial class form_MenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_MenuPrincipal()
        {
            InitializeComponent();
        }
        public void showChildForminPanel(object Form)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                this.pnlPrincipal.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(form);
            form.Show();
        }
        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_CadastrarMembros formCadastrarMembros = new form_CadastrarMembros();
            formCadastrarMembros.ShowDialog();
        }
        private void exibirMembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_ExibirMembros());
        }
        private void exibirCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ExibirCargos formExibirCargos = new form_ExibirCargos();
            formExibirCargos.ShowDialog();
        }
        private void exibirMinistériosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_ExibirMinisterios());
        }
    }
}