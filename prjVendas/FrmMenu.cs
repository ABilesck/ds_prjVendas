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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmCadCli)
                {
                    item.Focus();
                    return;

                }
            }
            FrmCadCli frmCadCli = new FrmCadCli();
            frmCadCli.MdiParent = this;
            frmCadCli.Show();
        }

        private void mnuVenda_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmVenda)
                {
                    item.Focus();
                    return;

                }
            }
            FrmVenda frmVenda = new FrmVenda();
            frmVenda.MdiParent = this;
            frmVenda.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            mnuCliente_Click(null, null);
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            mnuVenda_Click(null, null);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCascata_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuProduto_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmProduto)
                {
                    item.Focus();
                    return;

                }
            }
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            mnuProduto_Click(null, null);
        }

        private void mnuFornecedor_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmFornecedor)
                {
                    item.Focus();
                    return;

                }
            }
            FrmFornecedor frmFornecedor = new FrmFornecedor();
            frmFornecedor.MdiParent = this;
            frmFornecedor.Show();
        }

        private void mnuCompra_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if(item is FrmCompra)
                {
                    item.Focus();
                    return;
                }
            }
            FrmCompra frmCompra = new FrmCompra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }
    }
}
