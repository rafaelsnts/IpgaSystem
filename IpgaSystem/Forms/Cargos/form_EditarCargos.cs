using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpgaSystem.Forms.Cargos
{
    public partial class form_EditarCargos : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();
        private int idCargo;
        public form_EditarCargos()
        {
            InitializeComponent();
        }

        public int IdCargo
        {
            get
            {
                return idCargo;
            }
            set
            {
                idCargo = value;
                var cargo = context.tb_cargos.Find(idCargo);
                txtNomeCargo.Text = cargo.car_nome;
            }
        }

        private async Task EditarCargo()
        {
            var cargo = context.tb_cargos.Find(idCargo);
            cargo.car_nome = txtNomeCargo.Text;
            await context.SaveChangesAsync();
            XtraMessageBox.Show("Cargo editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            await EditarCargo();
        }
    }
}