using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int codigo;
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
            HabilitarBotoes(false);
            HabilitarCampos(true);
            limpaCampos();
            txtCodPro.Enabled = false;
            txtDescricao.Focus();
            incluir = true;
        }

        private void HabilitarCampos(bool hab)
        {
            txtCodPro.Enabled = hab;
            txtDescricao.Enabled = hab;
            txtPrecoUnit.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void HabilitarBotoes(bool hab)
        {
            btnAlterar.Enabled = hab;
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrecoUnit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (incluir)
                {
                    pc_ProdutoTableAdapter.InsertQuery(
                    txtDescricao.Text,
                    Convert.ToInt32(nudQuantidade.Value),
                    Convert.ToDouble(txtPrecoUnit.Text)
                    );
                    MessageBox.Show("Incluído com sucesso!", "Incluir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (alterar)
                {
                    pc_ProdutoTableAdapter.UpdateQuery(
                        txtDescricao.Text,
                        Convert.ToInt32(nudQuantidade.Value),
                        Convert.ToDouble(txtPrecoUnit.Text),
                        codigo
                        );
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmProduto_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Gravar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotoes(true);
            HabilitarCampos(false);
            limpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o produto selecionado?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_ProdutoTableAdapter.Delete(Convert.ToInt32(
                            ((DataRowView)pc_ProdutoBindingSource.Current).Row["codPro"].ToString())
                            );
                        FrmProduto_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um produto primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(null, "Ocorreu um erro ao excluir o produto!\n" +
                    "Pode ser que tenham vendas cadastradas com este produto", "Erro ao excluir:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro inesperado!\n" + ex.Message, "Erro ao excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Enabled == false)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
                HabilitarBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou" +
                    "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                pc_ProdutoTableAdapter.FillByDescricao(this.dsVendas.pc_Produto,
                    "%" + txtDescricao.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                alterar = true;
                HabilitarBotoes(false);
                HabilitarCampos(true);
                txtCodPro.Enabled = false;
                //txtCodPro.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
                codigo = Convert.ToInt32(((DataRowView)pc_ProdutoBindingSource.Current).Row["codPro"].ToString());
                //txtDescricao.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
                txtDescricao.Text = ((DataRowView)pc_ProdutoBindingSource.Current).Row["descricao"].ToString();
                txtPrecoUnit.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
                txtDescricao.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um produto primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
