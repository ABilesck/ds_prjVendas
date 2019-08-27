using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVendas
{
    public partial class FrmCompra : Form
    {
        Utility u = new Utility();
        Operacao oper;

        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVendas.pc_Produto' table. You can move, or remove it, as needed.
            pc_ProdutoTableAdapter.Fill(dsVendas.pc_Produto);
            // TODO: This line of code loads data into the 'dsVendas.pc_itemCompra' table. You can move, or remove it, as needed.
            pc_itemCompraTableAdapter.Fill(dsVendas.pc_itemCompra);
            // TODO: This line of code loads data into the 'dsVendas.pc_fornecedor' table. You can move, or remove it, as needed.
            pc_fornecedorTableAdapter.Fill(dsVendas.pc_fornecedor);
            // TODO: This line of code loads data into the 'dsVendas.pc_compra' table. You can move, or remove it, as needed.
            pc_compraTableAdapter.Fill(dsVendas.pc_compra);
            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            oper = Operacao.incluir;
            u.HabilitaCampos(this, true);
            u.HabilitaBotoes(this);
            cmbFornecedor.Focus();
        }

        private void pc_compraDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVendas.RowCount > 0)
            {
                this.pc_itemCompraBindingSource.FillByNumVenda(this.dsVendas.pc_ItemVenda,
                    Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
            }
            if (dgvItemVendas.RowCount > 0)
            {
                double total = (Double)pc_ItemVendaTableAdapter.TotalVenda(
                    Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                txtTotal.Text = total.ToString("R$ #,###,##0.00");
            }
            else
            {
                txtTotal.Text = "R$ 0.00";
            }
        }
    }
}
