using System;
using System.Threading.Tasks;

namespace IpgaSystem.Forms.Membros
{
    public partial class form_CadastrarMembros : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();
        public form_CadastrarMembros()
        {
            InitializeComponent();
        }

        private void form_CadastrarMembros_Load(object sender, EventArgs e)
        {
            dtDataCadastro.EditValue = DateTime.Today.Date;
        }

        private async Task CadastrarNovoMembro()
        {
            //tb_membros novoMembro = new tb_membros
            //{
            //    mem_nome = txtNomeMembro.Text,
            //    mem_telefone = txtTelefone.Text,
            //    mem_email = txtEmail.Text,
            //    mem_endereco = txtEndereco.Text,
            //    mem_ativo = true,
            //    mem_data_cadastro = DateTime.Now.Date,
            //    mem_data_nascimento = Convert.ToDateTime(dtDataNascimento.Text),
            //    mem_data_batismo = Convert.ToDateTime(dtDataBatismo.Text),
            //    mem_batizado = Convert.ToBoolean(chkBatizado.Checked)
            //};

            //using (ipgaContext context = new ipgaContext())
            //{
            //    await context.tb_membros.AddAsync(novoMembro); 
            //    await context.SaveChangesAsync(); 
            //}

            //XtraMessageBox.Show("Membro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //LimparTextBoxMembros();
        }
        private async void btnCadastrarMembro_Click(object sender, EventArgs e)
        {
            await CadastrarNovoMembro();
        }

        private void LimparTextBoxMembros()
        {
            txtNomeMembro.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            dtDataNascimento.EditValue = DateTime.Today.Date;
            dtDataBatismo.EditValue = DateTime.Today.Date;
            chkBatizado.Checked = false;
        }
    }
}