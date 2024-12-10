using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpgaSystem.Forms.Cargos
{
    
    public partial class form_CadastrarCargos : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();
        public form_CadastrarCargos()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNomeCargo.Text = string.Empty;
        }
        private async Task CadastrarCargo()
        {
            try
            {
                tb_cargos cargo = new tb_cargos();
                cargo.car_nome = txtNomeCargo.Text;

                using (ipgaContext context = new ipgaContext())
                {
                    context.tb_cargos.Add(cargo);
                    await context.SaveChangesAsync();
                    XtraMessageBox.Show("Cargo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao cadastrar cargo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void btnCadastrarCargo_Click(object sender, EventArgs e)
        {
            await CadastrarCargo();
        }
    }
}