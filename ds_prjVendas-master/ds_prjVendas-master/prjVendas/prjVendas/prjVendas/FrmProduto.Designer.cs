namespace prjVendas
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codProLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precoUnitLabel;
            this.dsVendas = new prjVendas.DsVendas();
            this.pc_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_ProdutoTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ProdutoTableAdapter();
            this.tableAdapterManager = new prjVendas.DsVendasTableAdapters.TableAdapterManager();
            this.pc_ProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecoUnit = new System.Windows.Forms.MaskedTextBox();
            codProLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ProdutoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dsVendas
            // 
            this.dsVendas.DataSetName = "DsVendas";
            this.dsVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_ProdutoBindingSource
            // 
            this.pc_ProdutoBindingSource.DataMember = "pc_Produto";
            this.pc_ProdutoBindingSource.DataSource = this.dsVendas;
            // 
            // pc_ProdutoTableAdapter
            // 
            this.pc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_ClienteTableAdapter = null;
            this.tableAdapterManager.pc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = this.pc_ProdutoTableAdapter;
            this.tableAdapterManager.pc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjVendas.DsVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_ProdutoDataGridView
            // 
            this.pc_ProdutoDataGridView.AllowUserToAddRows = false;
            this.pc_ProdutoDataGridView.AllowUserToDeleteRows = false;
            this.pc_ProdutoDataGridView.AutoGenerateColumns = false;
            this.pc_ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_ProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pc_ProdutoDataGridView.DataSource = this.pc_ProdutoBindingSource;
            this.pc_ProdutoDataGridView.Location = new System.Drawing.Point(29, 113);
            this.pc_ProdutoDataGridView.Name = "pc_ProdutoDataGridView";
            this.pc_ProdutoDataGridView.ReadOnly = true;
            this.pc_ProdutoDataGridView.Size = new System.Drawing.Size(451, 155);
            this.pc_ProdutoDataGridView.TabIndex = 1;
            // 
            // codProLabel
            // 
            codProLabel.AutoSize = true;
            codProLabel.Location = new System.Drawing.Point(16, 50);
            codProLabel.Name = "codProLabel";
            codProLabel.Size = new System.Drawing.Size(98, 13);
            codProLabel.TabIndex = 2;
            codProLabel.Text = "Código do Produto:";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Enabled = false;
            this.txtCodPro.Location = new System.Drawing.Point(120, 47);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(120, 20);
            this.txtCodPro.TabIndex = 3;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(16, 76);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(120, 73);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(120, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(246, 50);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 6;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Enabled = false;
            this.nudQuantidade.Location = new System.Drawing.Point(350, 50);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 7;
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(246, 79);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(77, 13);
            precoUnitLabel.TabIndex = 8;
            precoUnitLabel.Text = "Preço Unitário:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(395, 283);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(420, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(339, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(258, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(177, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(96, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(15, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codPro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precoUnit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(350, 79);
            this.txtPrecoUnit.Mask = "$ 9999990.00";
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(120, 20);
            this.txtPrecoUnit.TabIndex = 27;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 317);
            this.Controls.Add(this.txtPrecoUnit);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(codProLabel);
            this.Controls.Add(this.txtCodPro);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(this.pc_ProdutoDataGridView);
            this.Name = "FrmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ProdutoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsVendas dsVendas;
        private System.Windows.Forms.BindingSource pc_ProdutoBindingSource;
        private DsVendasTableAdapters.pc_ProdutoTableAdapter pc_ProdutoTableAdapter;
        private DsVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pc_ProdutoDataGridView;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MaskedTextBox txtPrecoUnit;
    }
}