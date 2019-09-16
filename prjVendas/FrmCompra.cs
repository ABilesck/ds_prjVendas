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
        double precoTemp = 0;
        Operacoes operacao;
        public FrmCompra()
        {
            InitializeComponent();
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVendas.pc_Produto' table. You can move, or remove it, as needed.
            pc_itemCompraTableAdapter.Fill(dsVendas.pc_itemCompra);
            pc_fornecedorTableAdapter.Fill(dsVendas.pc_fornecedor);
            pc_compraTableAdapter.Fill(dsVendas.pc_compra);
            pc_ProdutoTableAdapter.Fill(dsVendas.pc_Produto);
        }

        private void habilitaCampos(bool hab)
        {
            txtNumCompra.Enabled = hab;
            cmbRazao.Enabled = hab;
            dtpDataCompra.Enabled = hab;
            dtpDataEntrega.Enabled = hab;
            txtObs.Enabled = hab;
        }

        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
            btnSair.Enabled = hab;
        }

        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnExcluirItem.Enabled = hab;
            btnAlterarItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnGravarItem.Enabled = !hab;
            btnCancelarItem.Enabled = !hab;
        }

        private void limpaCampos(Control local)
        {
            foreach (Control item in local.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();

                    if (((TextBox)item).Name == "txtPrecounit"
                        || ((TextBox)item).Name == "txtSubTotal"
                        || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0,00";
                    }
                }

                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }

                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }

                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }

                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            operacao = Operacoes.incluir;
            habilitaCampos(true);
            habilitaBotoes(false);
            txtNumCompra.Enabled = false;
            cmbRazao.Focus();
        }

        private void dgvCompra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (dgvCompra.RowCount > 0)
                {
                    pc_itemCompraTableAdapter.FillByNumCompra(dsVendas.pc_itemCompra,
                        Convert.ToInt32(dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()));
                }
                if (dgvItemCompra.RowCount > 0)
                {
                    double total = (Double)pc_itemCompraTableAdapter.TotalCompra(
                        Convert.ToInt32(dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()));
                    txtTotal.Text = total.ToString("R$ #,###,##0.00");
                }
                else
                {
                    txtTotal.Text = "R$ 0.00";
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvCompra.SelectedRows.Count > 0)
                {
                    DialogResult drExcluir = MessageBox.Show("Deseja excluir a venda selecionada?", "Atenção", MessageBoxButtons.YesNo);
                    if (drExcluir == DialogResult.Yes)
                    {
                        int codigo = Convert.ToInt32(dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString());

                        pc_itemCompraTableAdapter.DeleteTodos(codigo);
                        btnCancelar_Click(null, null);
                        pc_compraTableAdapter.Delete(codigo);

                        FrmCompra_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione uma venda primeiro.", "Erro ao excluir a venda",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro ao excluir: \n" + ex.Message, "Erro ao excluir a venda",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == Operacoes.incluir)
                {

                    pc_compraTableAdapter.Insert(
                        (int)cmbRazao.SelectedValue,
                        dtpDataCompra.Value,
                        dtpDataEntrega.Value,
                        txtObs.Text);
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                if (operacao == Operacoes.editar)
                {
                    pc_compraTableAdapter.UpdateQuery((int)cmbRazao.SelectedValue, dtpDataCompra.Value,
                        dtpDataEntrega.Value, txtObs.Text, Convert.ToInt32(txtNumCompra.Text));
                }

                btnCancelar_Click(null, null);
                FrmCompra_Load(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro ao gravar: \n" + ex.Message, "Erro ao gravar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this);
            limpaCampos(grbItemCompra);
            habilitaCampos(false);
            habilitaBotoes(true);
            FrmCompra_Load(null, null);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                operacao = Operacoes.editar;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtNumCompra.Enabled = false;
                var venda_atual = (pc_compraBindingSource.Current as DataRowView).Row as DsVendas.pc_VendaRow;

                txtNumCompra.Text =
                    dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString();
                cmbRazao.SelectedValue = venda_atual.codCli;
                /*cmbNome.SelectedValue = Convert.ToInt32(
                    dgvVendas[1, dgvVendas.CurrentRow.Index].Value.ToString());
                */
                dtpDataCompra.Value = Convert.ToDateTime(
                    dgvCompra[3, dgvCompra.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(
                    dgvCompra[4, dgvCompra.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvCompra[5, dgvCompra.CurrentRow.Index].Value.ToString();
                cmbRazao.Focus();

            }
            else
            {
                MessageBox.Show(null, "Selecione uma venda primeiro!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!cmbRazao.Enabled)
            {
                cmbRazao.Enabled = true;
                cmbRazao.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;

                MessageBox.Show(null, "Digite o nome do cliente desejado.", "Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pc_compraTableAdapter.FillByRazao(dsVendas.pc_compra,
                    "%" + cmbRazao.Text + "%");
                btnCancelar.Enabled = true;
            }
        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            operacao = Operacoes.incluirItem;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = pc_ProdutoTableAdapter.GetDataByDescricao(cmbProduto.Text);
            precoTemp = 0;

            foreach (DataRow row in produto.Rows)
            {
                precoTemp = Convert.ToDouble(row["precoUnit"].ToString());
            }
            nudQuantidade.Value = 1;
            txtPrecoUnit.Text = precoTemp.ToString("R$ #,###,##0.00");
            txtSubTotal.Text = precoTemp.ToString("R$ #,###,##0.00");
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (int)nudQuantidade.Value * precoTemp;
            txtSubTotal.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvItemCompra.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja excluir o produto selecionado?",
                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        pc_itemCompraTableAdapter.Delete(
                            Convert.ToInt32(dgvCompra[0, dgvCompra.CurrentRow.Index].
                            Value.ToString()),
                            Convert.ToInt32(dgvItemCompra[0, dgvItemCompra.CurrentRow.Index].
                            Value.ToString())
                            );

                        //dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show("Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um produto primeiro!", "Erro ao " +
                        "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvCompra_SelectionChanged(null, null);
                btnCancelarItem_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(null, "Ocorreu um erro ao excluir um item: \n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if (dgvItemCompra.SelectedRows.Count > 0)
            {
                operacao = Operacoes.editarItem;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text =
                    dgvItemCompra[1, dgvItemCompra.CurrentRow.Index].Value.ToString();

                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(
                    dgvItemCompra[2, dgvItemCompra.CurrentRow.Index].Value.ToString());

                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um produto primeiro!", "Erro ao " +
                        "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvItemCompra.RowCount > 0)
                {
                    if (!cmbProduto.Enabled)
                    {
                        cmbProduto.Enabled = true;
                        cmbProduto.Focus();
                        habilitaBotoesItem(false);
                        btnPesquisarItem.Enabled = true;
                        btnCancelarItem.Enabled = false;
                        MessageBox.Show(null, "Digite o nome do produto desejado:",
                            "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        pc_itemCompraTableAdapter.FillByDescricao(dsVendas.pc_itemCompra,
                            Convert.ToInt32(
                                dgvCompra[0, dgvItemCompra.CurrentRow.Index].Value.ToString()),
                                "%" + cmbProduto.Text + "%");

                    }
                }
                else
                {
                    MessageBox.Show(null, "Sem produtos cadastrados!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            limpaCampos(grbItemCompra);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            dgvCompra_SelectionChanged(null, null);
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (operacao == Operacoes.incluirItem)
                {
                    pc_itemCompraTableAdapter.Insert(Convert.ToInt32(
                        dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()),
                        (int)cmbProduto.SelectedValue,
                        (int)nudQuantidade.Value,
                        precoTemp);

                    MessageBox.Show(null, "Inserido com sucesso!", "Inserção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (operacao == Operacoes.editarItem)
                {
                    pc_itemCompraTableAdapter.UpdateQuery(

                        (Int32)cmbProduto.SelectedValue,
                        (Int32)nudQuantidade.Value,
                        precoTemp,
                        Convert.ToInt32(
                            dgvCompra[0, dgvCompra.CurrentRow.Index].Value.ToString()
                            ),
                        Convert.ToInt32(
                            dgvItemCompra[0, dgvItemCompra.CurrentRow.Index].Value.ToString()
                            )
                        );
                    MessageBox.Show(null, "Alterado com sucesso", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnCancelarItem_Click(null, null);
                dgvCompra_SelectionChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro ao incluir:\n" + ex.Message, "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FrmCompra_Load(null, null);
        }
    }
}
