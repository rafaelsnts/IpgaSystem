using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IpgaSystem.Forms.Cargos
{
    public partial class form_ExibirCargos : DevExpress.XtraEditors.XtraForm
    {
        public form_ExibirCargos()
        {
            InitializeComponent();
            CarregarTabelaCargos();
        }

        private void CarregarTabelaCargos()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();
            linqInstantFeedbackSource.KeyExpression = "car_id";
            linqInstantFeedbackSource.DefaultSorting = "car_nome ASC";
            linqInstantFeedbackSource.GetQueryable += LinkqInstantFeedbackSource_GetQueryable;
            linqInstantFeedbackSource.DismissQueryable += LinkqInstantFeedbackSource_DismissQueryable;

            gridCargos.DataSource = linqInstantFeedbackSource;
        }

        private void LinkqInstantFeedbackSource_DismissQueryable(object sender, GetQueryableEventArgs e)
        {

        }

        private void LinkqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            ipgaContext context = new ipgaContext();
            var query =
                from cargos in context.tb_cargos
                orderby cargos.car_nome ascending
                select new
                {
                    cargos.car_id,
                    cargos.car_nome
                };
            e.QueryableSource = query;
        }

        private void viewCargos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupCargos.ShowPopup(gridCargos.PointToScreen(e.Point));
            }
        }

        private void btnNovoCargo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_CadastrarCargos formCadastrarCargos = new form_CadastrarCargos();
            formCadastrarCargos.ShowDialog();
        }

        private async Task ExcluirCargo()
        {
            var linhaSelecionada = viewCargos.GetFocusedRowCellValue("car_id");
            int idCargos = Convert.ToInt32(linhaSelecionada);

            if (XtraMessageBox.Show("Deseja realmente excluir este cargo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ipgaContext context = new ipgaContext())
                {
                    var cargo = context.tb_cargos.Find(idCargos);
                    var cargoAssociado = context.tb_membros.FirstOrDefault(m => m.mem_fk_car_id == idCargos);

                    if (cargoAssociado != null)
                    {
                        XtraMessageBox.Show("Não é possível excluir este cargo, pois existem membros associados a ele!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.tb_cargos.Remove(cargo);
                    context.SaveChanges();

                    XtraMessageBox.Show("Cargo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTabelaCargos();
                }
            }
        }
        private async void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            await ExcluirCargo();
        }

        private async Task EditarCargos()
        {
            var linhaSelecionada = viewCargos.GetFocusedRowCellValue("car_id");
            int idCargos = Convert.ToInt32(linhaSelecionada);

            form_EditarCargos formEditarCargos = new form_EditarCargos();
            formEditarCargos.IdCargo = idCargos;
            formEditarCargos.ShowDialog();
            CarregarTabelaCargos();

        }
        private async void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await EditarCargos();
        }
    }
}