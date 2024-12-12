using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IpgaSystem.Forms.Membros
{
    public partial class form_ExibirMembros : DevExpress.XtraEditors.XtraForm
    {
        public form_ExibirMembros()
        {
            InitializeComponent();
            CarregarTabelaMembros();
        }

        private void CarregarTabelaMembros()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();
            linqInstantFeedbackSource.KeyExpression = "mem_id";
            linqInstantFeedbackSource.DefaultSorting = "mem_nome ASC";
            linqInstantFeedbackSource.GetQueryable += LinkqInstantFeedbackSource_GetQueryable;
            linqInstantFeedbackSource.DismissQueryable += LinkqInstantFeedbackSource_DismissQueryable;

            gridMembros.DataSource = linqInstantFeedbackSource;
        }

        private void LinkqInstantFeedbackSource_DismissQueryable(object sender, GetQueryableEventArgs e)
        {
           
        }

        private void LinkqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            ipgaContext context = new ipgaContext();
            var query =
                from membros in context.tb_membros
                orderby membros.mem_nome ascending
                select new
                {
                    membros.mem_id,
                    membros.mem_nome,
                    membros.mem_telefone,
                    membros.mem_email,
                    membros.mem_data_nascimento,
                    membros.mem_data_batismo,
                    membros.mem_data_cadastro,
                    membros.mem_rua,
                    membros.mem_cidade,
                    membros.mem_estado,
                    membros.mem_cep,
                    membros.mem_bairro,
                    membros.mem_numero,
                    membros.mem_fk_min_id,
                    membros.mem_fk_car_id
                };
            e.QueryableSource = query;

        }

        private void viewMembros_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupMembros.ShowPopup(gridMembros.PointToScreen(e.Point));
            }

        }

        private void btnNovoMembro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_CadastrarMembros formCadastrarMembros = new form_CadastrarMembros();
            formCadastrarMembros.ShowDialog();
        }

        private async Task EditarMembro()
        {
            var linhaSelecionada = viewMembros.GetFocusedRowCellValue("mem_id");
            int idMembros = Convert.ToInt32(linhaSelecionada);

            form_EditarMembros formEditarMembros = new form_EditarMembros();
            formEditarMembros.IdMembro = idMembros;
            formEditarMembros.ShowDialog();

        }
        private async void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await EditarMembro();
        }

        private async Task ExcluirMembro()
        {
            if (XtraMessageBox.Show("Deseja realmente excluir o membro selecionado?", "Excluir Membro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int mem_id = Convert.ToInt32(viewMembros.GetFocusedRowCellValue("mem_id"));
                using (ipgaContext context = new ipgaContext())
                {
                    tb_membros membro = context.tb_membros.Find(mem_id);
                    context.tb_membros.Remove(membro);

                    await context.SaveChangesAsync();
                    CarregarTabelaMembros();
                }
            }
        }
        private async void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await ExcluirMembro();
        }
    }
}