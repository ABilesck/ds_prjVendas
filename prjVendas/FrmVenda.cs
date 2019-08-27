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
    public partial class FrmVenda : Form
    {
        double precoTemp = 0;
        Operacoes operacao;

        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVendas.pc_Produto' table. You can move, or remove it, as needed.
            this.pc_ProdutoTableAdapter.Fill(this.dsVendas.pc_Produto);
            // TODO: This line of code loads data into the 'dsVendas.pc_Cliente' table. You can move, or remove it, as needed.
            this.pc_ClienteTableAdapter.Fill(this.dsVendas.pc_Cliente);
            // TODO: This line of code loads data into the 'dsVendas.pc_Venda' table. You can move, or remove it, as needed.
            this.pc_VendaTableAdapter.Fill(this.dsVendas.pc_Venda);
            
        }
        private void habilitaCampos(bool hab)
        {
            txtNumVenda.Enabled = hab;
            cmbNome.Enabled = hab;
            dtpDataVenda.Enabled = hab;
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
                if(item is TextBox)
                {
                    ((TextBox)item).Clear();

                    if(((TextBox)item).Name == "txtPrecounit" 
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

                if(item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }

                if(item is DateTimePicker)
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
            txtNumVenda.Enabled = false;
            cmbNome.Focus();

        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if(dgvVendas.RowCount > 0)
                {
                    this.pc_ItemVendaTableAdapter.FillByNumVenda(this.dsVendas.pc_ItemVenda,
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                }
                if(dgvItemVendas.RowCount > 0)
                {
                    double total = (Double)pc_ItemVendaTableAdapter.TotalVenda(
                        Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    txtTotal.Text = total.ToString("R$ #,###,##0.00");
                }else
                {
                    txtTotal.Text = "R$ 0.00";
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message,
                    "Erro ao acessar os itens da venda", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if(dgvVendas.SelectedRows.Count > 0)
                {
                    if(MessageBox.Show(null,"Deseja excluir a venda selecionada?",
                        "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_ItemVendaTableAdapter.DeleteTodos(Convert.ToInt32(
                            dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        pc_VendaTableAdapter.DeleteQuery(Convert.ToInt32(
                            dgvVendas[0,dgvVendas.CurrentRow.Index].Value.ToString()));
                        FrmVenda_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exlusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else
                {
                    MessageBox.Show(null, "Selecione uma venda primeiro.", "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == Operacoes.incluir)
                {

                    pc_VendaTableAdapter.InsertQuery(
                        (Int32)cmbNome.SelectedValue,
                        dtpDataVenda.Value,
                        dtpDataEntrega.Value,
                        txtObs.Text);
                    MessageBox.Show(null, "Incluido com sucesso!","Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if(operacao == Operacoes.editar)
                {
                    pc_VendaTableAdapter.UpdateQuery((Int32)cmbNome.SelectedValue, dtpDataVenda.Value,
                        dtpDataEntrega.Value, txtObs.Text, Convert.ToInt32(txtNumVenda.Text));
                }

                btnCancelar_Click(null, null);
                FrmVenda_Load(null, null);
            }catch(Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro ao excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos(this);
            limpaCampos(grbItemVenda);
            habilitaCampos(false);
            habilitaBotoes(true);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(dgvVendas.SelectedRows.Count > 0)
            {
                operacao = Operacoes.editar;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtNumVenda.Enabled = false;
                var venda_atual = (pc_VendaBindingSource.Current as DataRowView).Row as DsVendas.pc_VendaRow;
                
                txtNumVenda.Text =
                    dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbNome.SelectedValue = venda_atual.codCli;
                /*cmbNome.SelectedValue = Convert.ToInt32(
                    dgvVendas[1, dgvVendas.CurrentRow.Index].Value.ToString());
                */
                dtpDataVenda.Value = Convert.ToDateTime(
                    dgvVendas[3, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(
                    dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[5, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbNome.Focus();

            }else
            {
                MessageBox.Show(null, "Selecione uma venda primeiro!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(!cmbNome.Enabled)
            {
                cmbNome.Enabled = true;
                cmbNome.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;

                MessageBox.Show(null, "Digite o nome do cliente desejado.", "Pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else
            {
                pc_VendaTableAdapter.FillByNome(this.dsVendas.pc_Venda,
                    "%" + cmbNome.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            operacao = Operacoes.incluirItem;
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            //cmbProduto_SelectedIndexChanged(null, null);
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
            double subTotal = (Int32)nudQuantidade.Value * precoTemp;
            txtSubTotal.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvItemVendas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja excluir o produto selecionado?",
                        "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                    {
                        pc_ItemVendaTableAdapter.DeleteQuery(
                            Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].
                            Value.ToString()),
                            Convert.ToInt32(dgvItemVendas[0, dgvItemVendas.CurrentRow.Index].
                            Value.ToString())
                            );

                        dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show("Apagado com sucesso!","Exclusão",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um produto primeiro!", "Erro ao " +
                        "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if(dgvItemVendas.SelectedRows.Count > 0)
            {
                operacao = Operacoes.editarItem;
                habilitaBotoesItem(false);
                habilitaCamposItem(true);
                cmbProduto.Text =
                    dgvItemVendas[1, dgvItemVendas.CurrentRow.Index].Value.ToString();

                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(
                    dgvItemVendas[2, dgvItemVendas.CurrentRow.Index].Value.ToString());

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

                if (dgvItemVendas.RowCount > 0)
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
                    }else
                    {
                        
                        pc_ItemVendaTableAdapter.FillByDescricao(
                            this.dsVendas.pc_ItemVenda,
                            Convert.ToInt32(
                                dgvVendas[0, dgvItemVendas.CurrentRow.Index].Value.ToString()),
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
            limpaCampos(grbItemVenda);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            try
            {

                if(operacao == Operacoes.incluirItem)
                {
                    pc_ItemVendaTableAdapter.InsertQuery(Convert.ToInt32(
                        dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()),
                        (Int32)cmbProduto.SelectedValue,
                        (Int32)nudQuantidade.Value,
                        precoTemp);

                    MessageBox.Show(null, "Inserido com sucesso!", "Inserção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else if(operacao == Operacoes.editarItem)
                {
                    pc_ItemVendaTableAdapter.UpdateQuery(

                        (Int32)cmbProduto.SelectedValue,
                        (Int32)nudQuantidade.Value,
                        precoTemp,
                        Convert.ToInt32(
                            dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()
                            ),
                        Convert.ToInt32(
                            dgvItemVendas[0, dgvItemVendas.CurrentRow.Index].Value.ToString()
                            )
                        );
                    MessageBox.Show(null, "Alterado com sucesso", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvVendas_SelectionChanged(null, null);
                btnCancelarItem_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FrmVenda_Load(null, null);
        }
    }
    public enum Operacoes
    {
        incluir,
        editar,
        incluirItem,
        editarItem
    }
}
