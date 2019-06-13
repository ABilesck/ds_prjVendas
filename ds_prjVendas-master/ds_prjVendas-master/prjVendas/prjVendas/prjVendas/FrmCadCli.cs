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
    public partial class FrmCadCli : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmCadCli()
        {
            InitializeComponent();
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            this.pc_ClienteTableAdapter.Fill(this.dsVendas.pc_Cliente);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            txtCodCli.Enabled = false;
            txtNome.Focus();
            incluir = true;
            txtCodCli.Focus();
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
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void habilitaCampos(bool hab)
        {
            txtCodCli.Enabled = hab;
            txtNome.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            txtuf.Enabled = hab;
            txtCep.Enabled = hab;
            txtTelefone.Enabled = hab;
            dtpDataNasc.Enabled = hab;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCodCli.Enabled = false;
                txtCodCli.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCep.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                txtuf.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                txtTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString());
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_ClienteTableAdapter.InsertQuery(
                        txtNome.Text, //nome
                        txtEndereco.Text, //endereco
                        txtCidade.Text, //cidade
                        txtBairro.Text, //bairro
                        txtuf.Text.ToUpper(), //uf
                        txtCep.Text, //cep
                        txtTelefone.Text, //telefone
                        dtpDataNasc.Value); //nascimento
                    MessageBox.Show("Incluído com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pc_ClienteTableAdapter.Update(txtNome.Text, txtEndereco.Text,
                        txtCidade.Text, txtBairro.Text, txtuf.Text, txtCep.Text,
                        txtTelefone.Text, dtpDataNasc.Value, Convert.ToInt32(txtCodCli.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmCadClientes_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_ClienteTableAdapter.Delete(Convert.ToInt32(
                            dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        FrmCadClientes_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou" +
                    "\nparte dele.", "Pesquisa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                pc_ClienteTableAdapter.FillByNome(this.dsVendas.pc_Cliente,
                    "%" + txtNome.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "telefone" ||
                this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone2")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5)
                            + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-"
                            + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }/*
            else if(this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "dataNasc")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value.ToString();
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 10);
                        e.Value = stringValue;
                    }
                }
            }*/
        }

        private void pc_ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_ClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsVendas);

        }

        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVendas.pc_Cliente' table. You can move, or remove it, as needed.
            dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            this.pc_ClienteTableAdapter.Fill(this.dsVendas.pc_Cliente);
            btnCancelar_Click(null, null);

        }
    }
}
