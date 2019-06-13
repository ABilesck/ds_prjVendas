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
    public partial class FrmProduto : Form
    {
        bool incluir = false;
        bool alterar = false;

        public FrmProduto()
        {
            InitializeComponent();
        }

        

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVendas.pc_Produto' table. You can move, or remove it, as needed.
            this.pc_ProdutoTableAdapter.Fill(this.dsVendas.pc_Produto);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void HabilitarCampos(bool hab)
        {
            
        }

        private void HabilitarBotoes(bool hab)
        {

        }
    }
}
