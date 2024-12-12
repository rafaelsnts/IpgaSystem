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

namespace IpgaSystem.Forms.Membros
{
    public partial class form_EditarMembros : DevExpress.XtraEditors.XtraForm
    {
        ipgaContext context = new ipgaContext();
        private int idMembro;
        public form_EditarMembros()
        {
            InitializeComponent();
        }

        public int IdMembro
        {
            get
            {
                return idMembro;
            }
            set
            {
                idMembro = value;
                var membro = context.tb_membros.Find(idMembro);
                txtNomeMembro.Text = membro.mem_nome;
                txtTelefone.Text = membro.mem_telefone;
                txtEmail.Text = membro.mem_email;
                txtRua.Text = membro.mem_rua;
                txtCidade.Text = membro.mem_cidade;
                txtEstado.Text = membro.mem_estado;
                txtCep.Text = membro.mem_cep;
                txtBairro.Text = membro.mem_bairro;
                txtNumero.Text = membro.mem_numero;
                dtDataNascimento.EditValue = membro.mem_data_nascimento;
                dtDataBatismo.EditValue = membro.mem_data_batismo;
                dtDataCadastro.EditValue = membro.mem_data_cadastro;
            }
        }

        private async Task EditarMembro()
        {
            var membro = context.tb_membros.Find(idMembro);
            membro.mem_nome = txtNomeMembro.Text;
            membro.mem_telefone = txtTelefone.Text;
            membro.mem_email = txtEmail.Text;
            membro.mem_rua = txtRua.Text;
            membro.mem_cidade = txtCidade.Text;
            membro.mem_estado = txtEstado.Text;
            membro.mem_cep = txtCep.Text;
            membro.mem_bairro = txtBairro.Text;
            membro.mem_numero = txtNumero.Text;
            membro.mem_data_nascimento = dtDataNascimento.DateTimeOffset.Date;
            membro.mem_data_batismo = dtDataBatismo.DateTimeOffset.Date;
            membro.mem_data_cadastro = dtDataCadastro.DateTimeOffset.Date;

            await context.SaveChangesAsync();
            XtraMessageBox.Show("Membro editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async void btnEditarMembro_Click(object sender, EventArgs e)
        {
            await EditarMembro();
        }
    }
}