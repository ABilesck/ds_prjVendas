namespace prjVendas
{
    partial class FrmCompra
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
            System.Windows.Forms.Label codForLabel;
            System.Windows.Forms.Label dataCompraLabel;
            System.Windows.Forms.Label datEntregaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label codProLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsVendas = new prjVendas.DsVendas();
            this.pc_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_compraTableAdapter = new prjVendas.DsVendasTableAdapters.pc_compraTableAdapter();
            this.tableAdapterManager = new prjVendas.DsVendasTableAdapters.TableAdapterManager();
            this.pc_fornecedorTableAdapter = new prjVendas.DsVendasTableAdapters.pc_fornecedorTableAdapter();
            this.pc_itemCompraTableAdapter = new prjVendas.DsVendasTableAdapters.pc_itemCompraTableAdapter();
            this.pc_ProdutoTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ProdutoTableAdapter();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.pcfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datEntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.obsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.pc_compraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpItemCompra = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codProComboBox = new System.Windows.Forms.ComboBox();
            this.pc_itemCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precoUnitTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_itemCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codForLabel = new System.Windows.Forms.Label();
            dataCompraLabel = new System.Windows.Forms.Label();
            datEntregaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            codProLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcfornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraDataGridView)).BeginInit();
            this.grpItemCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemCompraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codForLabel
            // 
            codForLabel.AutoSize = true;
            codForLabel.Location = new System.Drawing.Point(53, 62);
            codForLabel.Name = "codForLabel";
            codForLabel.Size = new System.Drawing.Size(61, 13);
            codForLabel.TabIndex = 2;
            codForLabel.Text = "Fornecedor";
            // 
            // dataCompraLabel
            // 
            dataCompraLabel.AutoSize = true;
            dataCompraLabel.Location = new System.Drawing.Point(44, 98);
            dataCompraLabel.Name = "dataCompraLabel";
            dataCompraLabel.Size = new System.Drawing.Size(70, 13);
            dataCompraLabel.TabIndex = 4;
            dataCompraLabel.Text = "data Compra:";
            // 
            // datEntregaLabel
            // 
            datEntregaLabel.AutoSize = true;
            datEntregaLabel.Location = new System.Drawing.Point(227, 98);
            datEntregaLabel.Name = "datEntregaLabel";
            datEntregaLabel.Size = new System.Drawing.Size(71, 13);
            datEntregaLabel.TabIndex = 6;
            datEntregaLabel.Text = "data Entrega:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(87, 133);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(27, 13);
            obsLabel.TabIndex = 8;
            obsLabel.Text = "obs:";
            // 
            // codProLabel
            // 
            codProLabel.AutoSize = true;
            codProLabel.Location = new System.Drawing.Point(31, 71);
            codProLabel.Name = "codProLabel";
            codProLabel.Size = new System.Drawing.Size(44, 13);
            codProLabel.TabIndex = 32;
            codProLabel.Text = "Produto";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(252, 71);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 34;
            quantidadeLabel.Text = "quantidade:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(343, 71);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(76, 13);
            precoUnitLabel.TabIndex = 36;
            precoUnitLabel.Text = "preco Unitário:";
            // 
            // dsVendas
            // 
            this.dsVendas.DataSetName = "DsVendas";
            this.dsVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_compraBindingSource
            // 
            this.pc_compraBindingSource.DataMember = "pc_compra";
            this.pc_compraBindingSource.DataSource = this.dsVendas;
            // 
            // pc_compraTableAdapter
            // 
            this.pc_compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_ClienteTableAdapter = null;
            this.tableAdapterManager.pc_compraTableAdapter = this.pc_compraTableAdapter;
            this.tableAdapterManager.pc_fornecedorTableAdapter = this.pc_fornecedorTableAdapter;
            this.tableAdapterManager.pc_itemCompraTableAdapter = this.pc_itemCompraTableAdapter;
            this.tableAdapterManager.pc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = this.pc_ProdutoTableAdapter;
            this.tableAdapterManager.pc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjVendas.DsVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_fornecedorTableAdapter
            // 
            this.pc_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // pc_itemCompraTableAdapter
            // 
            this.pc_itemCompraTableAdapter.ClearBeforeFill = true;
            // 
            // pc_ProdutoTableAdapter
            // 
            this.pc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_compraBindingSource, "codFor", true));
            this.cmbFornecedor.DataSource = this.pcfornecedorBindingSource;
            this.cmbFornecedor.DisplayMember = "razao";
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(120, 59);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(337, 21);
            this.cmbFornecedor.TabIndex = 3;
            this.cmbFornecedor.ValueMember = "codFor";
            // 
            // pcfornecedorBindingSource
            // 
            this.pcfornecedorBindingSource.DataMember = "pc_fornecedor";
            this.pcfornecedorBindingSource.DataSource = this.dsVendas;
            // 
            // dataCompraDateTimePicker
            // 
            this.dataCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_compraBindingSource, "dataCompra", true));
            this.dataCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataCompraDateTimePicker.Location = new System.Drawing.Point(120, 92);
            this.dataCompraDateTimePicker.Name = "dataCompraDateTimePicker";
            this.dataCompraDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dataCompraDateTimePicker.TabIndex = 5;
            // 
            // datEntregaDateTimePicker
            // 
            this.datEntregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_compraBindingSource, "datEntrega", true));
            this.datEntregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datEntregaDateTimePicker.Location = new System.Drawing.Point(304, 92);
            this.datEntregaDateTimePicker.Name = "datEntregaDateTimePicker";
            this.datEntregaDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.datEntregaDateTimePicker.TabIndex = 7;
            // 
            // obsRichTextBox
            // 
            this.obsRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_compraBindingSource, "obs", true));
            this.obsRichTextBox.Location = new System.Drawing.Point(120, 130);
            this.obsRichTextBox.Name = "obsRichTextBox";
            this.obsRichTextBox.Size = new System.Drawing.Size(482, 96);
            this.obsRichTextBox.TabIndex = 9;
            this.obsRichTextBox.Text = "";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(622, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(501, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(420, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(295, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(214, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(133, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(52, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(609, 130);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(88, 95);
            this.btnTodos.TabIndex = 27;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            // 
            // pc_compraDataGridView
            // 
            this.pc_compraDataGridView.AllowUserToAddRows = false;
            this.pc_compraDataGridView.AllowUserToDeleteRows = false;
            this.pc_compraDataGridView.AutoGenerateColumns = false;
            this.pc_compraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_compraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pc_compraDataGridView.DataSource = this.pc_compraBindingSource;
            this.pc_compraDataGridView.Location = new System.Drawing.Point(12, 232);
            this.pc_compraDataGridView.Name = "pc_compraDataGridView";
            this.pc_compraDataGridView.ReadOnly = true;
            this.pc_compraDataGridView.RowHeadersVisible = false;
            this.pc_compraDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pc_compraDataGridView.Size = new System.Drawing.Size(685, 173);
            this.pc_compraDataGridView.TabIndex = 27;
            this.pc_compraDataGridView.SelectionChanged += new System.EventHandler(this.pc_compraDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codFor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataCompra";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "data Compra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datEntrega";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn4.HeaderText = "data Entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "obs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 270;
            // 
            // grpItemCompra
            // 
            this.grpItemCompra.Controls.Add(this.txtTotal);
            this.grpItemCompra.Controls.Add(this.label1);
            this.grpItemCompra.Controls.Add(codProLabel);
            this.grpItemCompra.Controls.Add(this.codProComboBox);
            this.grpItemCompra.Controls.Add(quantidadeLabel);
            this.grpItemCompra.Controls.Add(this.quantidadeNumericUpDown);
            this.grpItemCompra.Controls.Add(precoUnitLabel);
            this.grpItemCompra.Controls.Add(this.precoUnitTextBox);
            this.grpItemCompra.Controls.Add(this.btnCancelarItem);
            this.grpItemCompra.Controls.Add(this.btnGravarItem);
            this.grpItemCompra.Controls.Add(this.btnPesquisarItem);
            this.grpItemCompra.Controls.Add(this.btnAlterarItem);
            this.grpItemCompra.Controls.Add(this.btnExcluirItem);
            this.grpItemCompra.Controls.Add(this.btnIncluirItem);
            this.grpItemCompra.Location = new System.Drawing.Point(13, 412);
            this.grpItemCompra.Name = "grpItemCompra";
            this.grpItemCompra.Size = new System.Drawing.Size(684, 125);
            this.grpItemCompra.TabIndex = 28;
            this.grpItemCompra.TabStop = false;
            this.grpItemCompra.Text = "Itens da compra";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(460, 88);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(87, 20);
            this.txtTotal.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Total";
            // 
            // codProComboBox
            // 
            this.codProComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemCompraBindingSource, "codPro", true));
            this.codProComboBox.DataSource = this.pcProdutoBindingSource;
            this.codProComboBox.DisplayMember = "descricao";
            this.codProComboBox.FormattingEnabled = true;
            this.codProComboBox.Location = new System.Drawing.Point(34, 87);
            this.codProComboBox.Name = "codProComboBox";
            this.codProComboBox.Size = new System.Drawing.Size(212, 21);
            this.codProComboBox.TabIndex = 33;
            this.codProComboBox.ValueMember = "codPro";
            // 
            // pc_itemCompraBindingSource
            // 
            this.pc_itemCompraBindingSource.DataMember = "pc_itemCompra";
            this.pc_itemCompraBindingSource.DataSource = this.dsVendas;
            // 
            // pcProdutoBindingSource
            // 
            this.pcProdutoBindingSource.DataMember = "pc_Produto";
            this.pcProdutoBindingSource.DataSource = this.dsVendas;
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_itemCompraBindingSource, "quantidade", true));
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(255, 87);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.quantidadeNumericUpDown.TabIndex = 35;
            // 
            // precoUnitTextBox
            // 
            this.precoUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemCompraBindingSource, "precoUnit", true));
            this.precoUnitTextBox.Location = new System.Drawing.Point(343, 88);
            this.precoUnitTextBox.Name = "precoUnitTextBox";
            this.precoUnitTextBox.Size = new System.Drawing.Size(111, 20);
            this.precoUnitTextBox.TabIndex = 37;
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Enabled = false;
            this.btnCancelarItem.Location = new System.Drawing.Point(495, 28);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarItem.TabIndex = 30;
            this.btnCancelarItem.Text = "&Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.Enabled = false;
            this.btnGravarItem.Location = new System.Drawing.Point(414, 28);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGravarItem.TabIndex = 29;
            this.btnGravarItem.Text = "&Gravar";
            this.btnGravarItem.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.Location = new System.Drawing.Point(333, 28);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarItem.TabIndex = 28;
            this.btnPesquisarItem.Text = "&Pesquisar";
            this.btnPesquisarItem.UseVisualStyleBackColor = true;
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Location = new System.Drawing.Point(252, 28);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarItem.TabIndex = 27;
            this.btnAlterarItem.Text = "&Alterar";
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(171, 28);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 26;
            this.btnExcluirItem.Text = "&Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.Location = new System.Drawing.Point(90, 28);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirItem.TabIndex = 25;
            this.btnIncluirItem.Text = "&Incluir";
            this.btnIncluirItem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "codPro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "preço Unitário";
            this.dataGridViewTextBoxColumn8.HeaderText = "precoUnit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // pc_itemCompraDataGridView
            // 
            this.pc_itemCompraDataGridView.AllowUserToAddRows = false;
            this.pc_itemCompraDataGridView.AllowUserToDeleteRows = false;
            this.pc_itemCompraDataGridView.AutoGenerateColumns = false;
            this.pc_itemCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_itemCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13});
            this.pc_itemCompraDataGridView.DataSource = this.pc_itemCompraBindingSource;
            this.pc_itemCompraDataGridView.Location = new System.Drawing.Point(13, 543);
            this.pc_itemCompraDataGridView.Name = "pc_itemCompraDataGridView";
            this.pc_itemCompraDataGridView.ReadOnly = true;
            this.pc_itemCompraDataGridView.RowHeadersVisible = false;
            this.pc_itemCompraDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pc_itemCompraDataGridView.Size = new System.Drawing.Size(684, 174);
            this.pc_itemCompraDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn12.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn10.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "precoUnit";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn11.HeaderText = "precoUnit";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "subtotal";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn13.HeaderText = "subtotal";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 735);
            this.Controls.Add(this.pc_itemCompraDataGridView);
            this.Controls.Add(this.grpItemCompra);
            this.Controls.Add(this.pc_compraDataGridView);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(codForLabel);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(dataCompraLabel);
            this.Controls.Add(this.dataCompraDateTimePicker);
            this.Controls.Add(datEntregaLabel);
            this.Controls.Add(this.datEntregaDateTimePicker);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.obsRichTextBox);
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcfornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraDataGridView)).EndInit();
            this.grpItemCompra.ResumeLayout(false);
            this.grpItemCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemCompraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsVendas dsVendas;
        private System.Windows.Forms.BindingSource pc_compraBindingSource;
        private DsVendasTableAdapters.pc_compraTableAdapter pc_compraTableAdapter;
        private DsVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private DsVendasTableAdapters.pc_fornecedorTableAdapter pc_fornecedorTableAdapter;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.DateTimePicker dataCompraDateTimePicker;
        private System.Windows.Forms.DateTimePicker datEntregaDateTimePicker;
        private System.Windows.Forms.RichTextBox obsRichTextBox;
        private System.Windows.Forms.BindingSource pcfornecedorBindingSource;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridView pc_compraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox grpItemCompra;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private DsVendasTableAdapters.pc_itemCompraTableAdapter pc_itemCompraTableAdapter;
        private System.Windows.Forms.BindingSource pc_itemCompraBindingSource;
        private System.Windows.Forms.ComboBox codProComboBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.TextBox precoUnitTextBox;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private DsVendasTableAdapters.pc_ProdutoTableAdapter pc_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView pc_itemCompraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}