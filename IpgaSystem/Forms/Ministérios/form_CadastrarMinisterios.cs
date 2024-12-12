using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IpgaSystem.Forms.Ministérios
{
    public partial class form_CadastrarMinisterios : DevExpress.XtraEditors.XtraForm
    {
        public form_CadastrarMinisterios()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNomeMinisterio.Text = string.Empty;
            txtDescricaoMinisterio.Text = string.Empty;
        }
        private async Task CadastrarMinisterio()
        {
            try
            {
                tb_ministerios ministerio = new tb_ministerios();
                ministerio.min_nome = txtNomeMinisterio.Text;
                ministerio.min_descricao = txtDescricaoMinisterio.Text;
                ministerio.min_data_criacao = DateTime.Now.Date;

                using (ipgaContext context = new ipgaContext())
                {
                    context.tb_ministerios.Add(ministerio);
                    await context.SaveChangesAsync();
                    XtraMessageBox.Show("Ministério cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao cadastrar ministério: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void btnCadastrarMinisterio_Click(object sender, System.EventArgs e)
        {
            await CadastrarMinisterio();
        }
    }
}