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
    public partial class FrmFornecedor : Form
    {
        Utility utility = new Utility();
        Operacao operacao;
        int codigo;

        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVendas.pc_fornecedor' table. You can move, or remove it, as needed.
            pc_fornecedorTableAdapter.Fill(dsVendas.pc_fornecedor);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            utility.LimpaCampos(this);
            utility.HabilitaCampos(this, true);
            utility.HabilitaBotoes(this);
            operacao = Operacao.incluir;
            txtRazao.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvFornecedores.RowCount > 0)
            {
                if (MessageBox.Show(null, "Deseja mesmo excluir o fornecedor selecionado?",
                       "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    pc_fornecedorTableAdapter.Delete(Convert.ToInt32(
                        ((DataRowView)pc_fornecedorBindingSource.Current).Row["codFor"].ToString())
                        );
                    FrmFornecedor_Load(null, null);
                    MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            utility.LimpaCampos(this);
            utility.HabilitaCampos(this, true);
            utility.HabilitaBotoes(this);
            operacao = Operacao.alterar;
            codigo = Convert.ToInt32(((DataRowView)pc_fornecedorBindingSource.Current).Row["codFor"].ToString());
            txtRazao.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["razao"].ToString();
            txtFantasia.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["fantasia"].ToString();
            txtEndereco.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["endereco"].ToString();
            txtCidade.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["cidade"].ToString();
            txtBairro.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["bairro"].ToString();
            txtUf.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["uf"].ToString().ToUpper();
            txtCep.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["cep"].ToString();
            txtTelefone.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["telefone"].ToString();
            txtFax.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["fax"].ToString();
            txtCnpj.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["cnpj"].ToString();
            txtIe.Text = ((DataRowView)pc_fornecedorBindingSource.Current).Row["ie"].ToString();
            dtpDatacad.Value = Convert.ToDateTime(((DataRowView)pc_fornecedorBindingSource.Current).Row["datacad"].ToString());
            txtRazao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtRazao.Enabled)
            {
                txtRazao.Enabled = true;
                txtRazao.Focus();
                utility.HabilitaBotoes(this);
                btnGravar.Enabled = false;
                btnCancelar.Enabled = true;
                btnPesquisar.Enabled = true;

                MessageBox.Show(null, "Digite a razão social desejada ou" +
                    "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                pc_fornecedorTableAdapter.FillByRazao(dsVendas.pc_fornecedor, "%" + txtRazao.Text + "%");
                btnPesquisar.Enabled = false;
                btnGravar.Enabled = true;
                //btnCancelar_Click(null, null);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(operacao == Operacao.incluir)
            {
                pc_fornecedorTableAdapter.Insert(
                    txtRazao.Text,
                    txtFantasia.Text,
                    txtEndereco.Text,
                    txtCidade.Text,
                    txtBairro.Text,
                    txtUf.Text,
                    txtCep.Text,
                    txtTelefone.Text,
                    txtFax.Text,
                    txtCnpj.Text,
                    txtIe.Text,
                    dtpDatacad.Value
                    );
            }else
            {
                pc_fornecedorTableAdapter.Update(
                    txtRazao.Text,
                    txtFantasia.Text,
                    txtEndereco.Text,
                    txtCidade.Text,
                    txtBairro.Text,
                    txtUf.Text,
                    txtCep.Text,
                    txtTelefone.Text,
                    txtFax.Text,
                    txtCnpj.Text,
                    txtIe.Text,
                    dtpDatacad.Value,
                    codigo
                    );
            }
            MessageBox.Show("Salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancelar_Click(null, null);
            FrmFornecedor_Load(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            utility.HabilitaCampos(this, false);
            utility.HabilitaBotoes(this);
            utility.LimpaCampos(this);
            FrmFornecedor_Load(null, null);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
