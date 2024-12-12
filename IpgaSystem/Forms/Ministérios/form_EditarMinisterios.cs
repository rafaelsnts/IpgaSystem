using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpgaSystem.Forms.Ministérios
{
    public partial class form_EditarMinisterios : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();
        private int idMinisterio;
        public form_EditarMinisterios()
        {
            InitializeComponent();
        }

        public int IdMinisterio
        {
            get
            {
                return idMinisterio;
            }
            set
            {
                idMinisterio = value;
                var ministerio = context.tb_ministerios.Find(idMinisterio);
                txtNomeMinisterio.Text = ministerio.min_nome;
                txtDescricaoMinisterio.Text = ministerio.min_descricao;
            }
        }

        private async Task EditarMinisterio()
        {
            var ministerio = context.tb_ministerios.Find(idMinisterio);
            ministerio.min_nome = txtNomeMinisterio.Text;
            ministerio.min_descricao = txtDescricaoMinisterio.Text;
            await context.SaveChangesAsync();
            XtraMessageBox.Show("Ministério editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnEditarMinisterio_Click(object sender, EventArgs e)
        {
            await EditarMinisterio();
        }
    }
}