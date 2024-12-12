using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using IpgaSystem.XPO.IpgaDB;

namespace IpgaSystem.Forms.Membros
{
    public partial class form_CadastrarMembros : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();
        public form_CadastrarMembros()
        {
            InitializeComponent();
            PreencherLookUpEditMinisterios();
            PreencherLookUpEditCargos();
        }

        private void PreencherLookUpEditMinisterios()
        {
            UnitOfWork uou = new UnitOfWork(XpoDefault.DataLayer);
            
            var query = from ministerio in new XPQuery<tb_ministeriosXPO>(uou)
                        orderby ministerio.min_nome ascending
                        select new
                        {
                            ministerio.min_id,
                            ministerio.min_nome
                        };

            var ministerios = query.ToList();
            lookMinisterio.Properties.DataSource = ministerios;
            lookMinisterio.Properties.ValueMember = "min_id";
            lookMinisterio.Properties.DisplayMember = "min_nome";

            lookMinisterio.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("min_nome", "Nome"));
        }

        private void PreencherLookUpEditCargos()
        {
            UnitOfWork uou = new UnitOfWork(XpoDefault.DataLayer);

            var query = from cargo in new XPQuery<tb_cargosXPO>(uou)
                        orderby cargo.car_nome ascending
                        select new
                        {
                            cargo.car_id,
                            cargo.car_nome
                        };

            var cargos = query.ToList();
            lookCargo.Properties.DataSource = cargos;
            lookCargo.Properties.ValueMember = "car_id";
            lookCargo.Properties.DisplayMember = "car_nome";

            lookCargo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("car_nome", "Nome"));
        }
        private void form_CadastrarMembros_Load(object sender, EventArgs e)
        {
            dtDataCadastro.EditValue = DateTime.Today.Date;
        }

        private async Task CadastrarNovoMembro()
        {
            tb_membros novoMembro = new tb_membros
            {
                mem_nome = txtNomeMembro.Text,
                mem_telefone = txtTelefone.Text,
                mem_email = txtEmail.Text,
                mem_cep = txtCep.Text,
                mem_rua = txtRua.Text,
                mem_numero = txtNumero.Text,
                mem_bairro = txtBairro.Text,
                mem_cidade = txtCidade.Text,
                mem_estado = txtEstado.Text,
                mem_fk_min_id = lookMinisterio.EditValue == null ? (int?)null : Convert.ToInt32(lookMinisterio.EditValue),
                mem_fk_car_id = lookCargo.EditValue == null ? (int?)null : Convert.ToInt32(lookCargo.EditValue),
                mem_data_cadastro = DateTime.Now.Date,
                mem_data_nascimento = Convert.ToDateTime(dtDataNascimento.Text),
                mem_data_batismo = Convert.ToDateTime(dtDataBatismo.Text),
                mem_batizado = Convert.ToBoolean(chkBatizado.Checked)
            };

            using (ipgaContext context = new ipgaContext())
            {
                await context.tb_membros.AddAsync(novoMembro);
                await context.SaveChangesAsync();
            }

            XtraMessageBox.Show("Membro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparTextBoxMembros();
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
            txtEstado.Text = "";
            dtDataNascimento.EditValue = DateTime.Today.Date;
            dtDataBatismo.EditValue = DateTime.Today.Date;
            chkBatizado.Checked = false;
            txtCep.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            lookMinisterio.EditValue = null;
            lookCargo.EditValue = null;
        }
    }
}