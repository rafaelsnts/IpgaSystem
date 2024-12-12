using DevExpress.Data.Linq;
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
    public partial class form_ExibirMinisterios : DevExpress.XtraEditors.XtraForm
    {
        public form_ExibirMinisterios()
        {
            InitializeComponent();
            CarregarTabelaMinisterios();
        }
        private void CarregarTabelaMinisterios()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();
            linqInstantFeedbackSource.KeyExpression = "min_id";
            linqInstantFeedbackSource.DefaultSorting = "min_nome ASC";
            linqInstantFeedbackSource.GetQueryable += LinkqInstantFeedbackSource_GetQueryable;
            linqInstantFeedbackSource.DismissQueryable += LinkqInstantFeedbackSource_DismissQueryable;

            gridMinisterio.DataSource = linqInstantFeedbackSource;
        }

        private void LinkqInstantFeedbackSource_DismissQueryable(object sender, GetQueryableEventArgs e)
        {
            
        }

        private void LinkqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            ipgaContext context = new ipgaContext();
            var query =
                from ministerios in context.tb_ministerios
                orderby ministerios.min_nome ascending
                select new
                {
                    ministerios.min_id,
                    ministerios.min_data_criacao,
                    ministerios.min_nome,
                    ministerios.min_descricao
                };
            e.QueryableSource = query;
        }

        private async Task ExcluirMinisterio()
        {
            var linhaSelecionada = viewMinisterio.GetFocusedRowCellValue("min_id");
            int idMinisterio = Convert.ToInt32(linhaSelecionada);

            if (XtraMessageBox.Show("Deseja realmente excluir este ministério?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                using (ipgaContext context = new ipgaContext())
                {
                    var ministerio = context.tb_ministerios.Find(idMinisterio);
                    var ministerioAssociado = context.tb_membros.FirstOrDefault(m => m.mem_fk_min_id== idMinisterio);

                    if (ministerioAssociado != null)
                    {
                        XtraMessageBox.Show("Não é possível excluir este ministério, pois existem membros associados a ele!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.tb_ministerios.Remove(ministerio);
                    await context.SaveChangesAsync();

                    XtraMessageBox.Show("Ministério excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTabelaMinisterios();
                }
            }
        }
        private async void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await ExcluirMinisterio();
        }

        private async Task EditarMinisterio()
        {
            var linhaSelecionada = viewMinisterio.GetFocusedRowCellValue("min_id");
            int idMinisterio = Convert.ToInt32(linhaSelecionada);
            form_EditarMinisterios formEditarMinisterio = new form_EditarMinisterios();
            formEditarMinisterio.IdMinisterio = idMinisterio;
            formEditarMinisterio.ShowDialog();
            CarregarTabelaMinisterios();
        }
        private async void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await EditarMinisterio();
        }

        private void btnNovoMinisterio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_CadastrarMinisterios formNovoMinisterio = new form_CadastrarMinisterios();
            formNovoMinisterio.ShowDialog();
        }

        private void viewMinisterio_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                e.Allow = false;
                popupMinisterio.ShowPopup(gridMinisterio.PointToScreen(e.Point));
            }
        }
    }
}