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
            System.Windows.Forms.Label numCompraLabel;
            System.Windows.Forms.Label codForLabel;
            System.Windows.Forms.Label dataCompraLabel;
            System.Windows.Forms.Label datEntregaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompra));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dsVendas = new prjVendas.DsVendas();
            this.pc_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_compraTableAdapter = new prjVendas.DsVendasTableAdapters.pc_compraTableAdapter();
            this.tableAdapterManager = new prjVendas.DsVendasTableAdapters.TableAdapterManager();
            this.pc_fornecedorTableAdapter = new prjVendas.DsVendasTableAdapters.pc_fornecedorTableAdapter();
            this.txtNumCompra = new System.Windows.Forms.TextBox();
            this.cmbRazao = new System.Windows.Forms.ComboBox();
            this.pcfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTodos = new System.Windows.Forms.Button();
            this.grbItemCompra = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.pc_itemCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_itemCompraTableAdapter = new prjVendas.DsVendasTableAdapters.pc_itemCompraTableAdapter();
            this.dgvItemCompra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.pcProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_ProdutoTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ProdutoTableAdapter();
            numCompraLabel = new System.Windows.Forms.Label();
            codForLabel = new System.Windows.Forms.Label();
            dataCompraLabel = new System.Windows.Forms.Label();
            datEntregaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcfornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.grbItemCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numCompraLabel
            // 
            numCompraLabel.AutoSize = true;
            numCompraLabel.Location = new System.Drawing.Point(30, 60);
            numCompraLabel.Name = "numCompraLabel";
            numCompraLabel.Size = new System.Drawing.Size(69, 13);
            numCompraLabel.TabIndex = 27;
            numCompraLabel.Text = "num Compra:";
            // 
            // codForLabel
            // 
            codForLabel.AutoSize = true;
            codForLabel.Location = new System.Drawing.Point(208, 60);
            codForLabel.Name = "codForLabel";
            codForLabel.Size = new System.Drawing.Size(46, 13);
            codForLabel.TabIndex = 29;
            codForLabel.Text = "cod For:";
            // 
            // dataCompraLabel
            // 
            dataCompraLabel.AutoSize = true;
            dataCompraLabel.Location = new System.Drawing.Point(30, 96);
            dataCompraLabel.Name = "dataCompraLabel";
            dataCompraLabel.Size = new System.Drawing.Size(70, 13);
            dataCompraLabel.TabIndex = 31;
            dataCompraLabel.Text = "data Compra:";
            // 
            // datEntregaLabel
            // 
            datEntregaLabel.AutoSize = true;
            datEntregaLabel.Location = new System.Drawing.Point(206, 97);
            datEntregaLabel.Name = "datEntregaLabel";
            datEntregaLabel.Size = new System.Drawing.Size(65, 13);
            datEntregaLabel.TabIndex = 33;
            datEntregaLabel.Text = "dat Entrega:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(30, 120);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(27, 13);
            obsLabel.TabIndex = 35;
            obsLabel.Text = "obs:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(23, 80);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(47, 13);
            descricaoLabel.TabIndex = 32;
            descricaoLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(239, 80);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 28;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(321, 80);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(77, 13);
            precoUnitLabel.TabIndex = 30;
            precoUnitLabel.Text = "Preço Unitário:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(413, 80);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(56, 13);
            subtotalLabel.TabIndex = 34;
            subtotalLabel.Text = "Sub Total:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(560, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(438, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(357, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(276, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(195, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(114, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(33, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
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
            this.tableAdapterManager.pc_itemCompraTableAdapter = null;
            this.tableAdapterManager.pc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.pc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjVendas.DsVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_fornecedorTableAdapter
            // 
            this.pc_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // txtNumCompra
            // 
            this.txtNumCompra.Enabled = false;
            this.txtNumCompra.Location = new System.Drawing.Point(105, 57);
            this.txtNumCompra.Name = "txtNumCompra";
            this.txtNumCompra.Size = new System.Drawing.Size(84, 20);
            this.txtNumCompra.TabIndex = 28;
            // 
            // cmbRazao
            // 
            this.cmbRazao.DataSource = this.pcfornecedorBindingSource;
            this.cmbRazao.DisplayMember = "razao";
            this.cmbRazao.Enabled = false;
            this.cmbRazao.FormattingEnabled = true;
            this.cmbRazao.Location = new System.Drawing.Point(260, 57);
            this.cmbRazao.Name = "cmbRazao";
            this.cmbRazao.Size = new System.Drawing.Size(200, 21);
            this.cmbRazao.TabIndex = 30;
            this.cmbRazao.ValueMember = "codFor";
            // 
            // pcfornecedorBindingSource
            // 
            this.pcfornecedorBindingSource.DataMember = "pc_fornecedor";
            this.pcfornecedorBindingSource.DataSource = this.dsVendas;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Enabled = false;
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(105, 90);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCompra.TabIndex = 32;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(276, 91);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(95, 20);
            this.dtpDataEntrega.TabIndex = 34;
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_compraBindingSource, "obs", true));
            this.txtObs.Location = new System.Drawing.Point(33, 136);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(549, 55);
            this.txtObs.TabIndex = 36;
            this.txtObs.Text = "";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AutoGenerateColumns = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dgvCompra.DataSource = this.pc_compraBindingSource;
            this.dgvCompra.Location = new System.Drawing.Point(12, 197);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(657, 199);
            this.dgvCompra.TabIndex = 36;
            this.dgvCompra.SelectionChanged += new System.EventHandler(this.dgvCompra_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "numCompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codFor";
            this.dataGridViewTextBoxColumn2.HeaderText = "codFor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataCompra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "obs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(588, 136);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(81, 55);
            this.btnTodos.TabIndex = 37;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // grbItemCompra
            // 
            this.grbItemCompra.Controls.Add(this.cmbProduto);
            this.grbItemCompra.Controls.Add(this.txtTotal);
            this.grbItemCompra.Controls.Add(this.label1);
            this.grbItemCompra.Controls.Add(quantidadeLabel);
            this.grbItemCompra.Controls.Add(this.nudQuantidade);
            this.grbItemCompra.Controls.Add(precoUnitLabel);
            this.grbItemCompra.Controls.Add(this.txtPrecoUnit);
            this.grbItemCompra.Controls.Add(descricaoLabel);
            this.grbItemCompra.Controls.Add(subtotalLabel);
            this.grbItemCompra.Controls.Add(this.txtSubTotal);
            this.grbItemCompra.Controls.Add(this.btnCancelarItem);
            this.grbItemCompra.Controls.Add(this.btnGravarItem);
            this.grbItemCompra.Controls.Add(this.btnPesquisarItem);
            this.grbItemCompra.Controls.Add(this.btnAlterarItem);
            this.grbItemCompra.Controls.Add(this.btnExcluirItem);
            this.grbItemCompra.Controls.Add(this.btnIncluirItem);
            this.grbItemCompra.Location = new System.Drawing.Point(12, 402);
            this.grbItemCompra.Name = "grbItemCompra";
            this.grbItemCompra.Size = new System.Drawing.Size(657, 142);
            this.grbItemCompra.TabIndex = 38;
            this.grbItemCompra.TabStop = false;
            this.grbItemCompra.Text = "Itens da Venda";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(518, 97);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(87, 20);
            this.txtTotal.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Enabled = false;
            this.nudQuantidade.Location = new System.Drawing.Point(242, 97);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(61, 20);
            this.nudQuantidade.TabIndex = 29;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(322, 97);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.ReadOnly = true;
            this.txtPrecoUnit.Size = new System.Drawing.Size(87, 20);
            this.txtPrecoUnit.TabIndex = 31;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(416, 97);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(87, 20);
            this.txtSubTotal.TabIndex = 35;
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Enabled = false;
            this.btnCancelarItem.Location = new System.Drawing.Point(484, 35);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarItem.TabIndex = 24;
            this.btnCancelarItem.Text = "&Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.Enabled = false;
            this.btnGravarItem.Location = new System.Drawing.Point(403, 35);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGravarItem.TabIndex = 23;
            this.btnGravarItem.Text = "&Gravar";
            this.btnGravarItem.UseVisualStyleBackColor = true;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.Location = new System.Drawing.Point(322, 35);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarItem.TabIndex = 22;
            this.btnPesquisarItem.Text = "&Pesquisar";
            this.btnPesquisarItem.UseVisualStyleBackColor = true;
            this.btnPesquisarItem.Click += new System.EventHandler(this.btnPesquisarItem_Click);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Location = new System.Drawing.Point(241, 35);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarItem.TabIndex = 21;
            this.btnAlterarItem.Text = "&Alterar";
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(160, 35);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 20;
            this.btnExcluirItem.Text = "&Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.Location = new System.Drawing.Point(79, 35);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirItem.TabIndex = 19;
            this.btnIncluirItem.Text = "&Incluir";
            this.btnIncluirItem.UseVisualStyleBackColor = true;
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // pc_itemCompraBindingSource
            // 
            this.pc_itemCompraBindingSource.DataMember = "pc_itemCompra";
            this.pc_itemCompraBindingSource.DataSource = this.dsVendas;
            // 
            // pc_itemCompraTableAdapter
            // 
            this.pc_itemCompraTableAdapter.ClearBeforeFill = true;
            // 
            // dgvItemCompra
            // 
            this.dgvItemCompra.AllowUserToAddRows = false;
            this.dgvItemCompra.AllowUserToDeleteRows = false;
            this.dgvItemCompra.AutoGenerateColumns = false;
            this.dgvItemCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvItemCompra.DataSource = this.pc_itemCompraBindingSource;
            this.dgvItemCompra.Location = new System.Drawing.Point(12, 550);
            this.dgvItemCompra.Name = "dgvItemCompra";
            this.dgvItemCompra.ReadOnly = true;
            this.dgvItemCompra.RowHeadersVisible = false;
            this.dgvItemCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemCompra.Size = new System.Drawing.Size(657, 220);
            this.dgvItemCompra.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numCompra";
            this.dataGridViewTextBoxColumn6.HeaderText = "numCompra";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codPro";
            this.dataGridViewTextBoxColumn7.HeaderText = "codPro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "precoUnit";
            this.dataGridViewTextBoxColumn9.HeaderText = "precoUnit";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn10.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn11.HeaderText = "subtotal";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.pcProdutoBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(26, 97);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(209, 21);
            this.cmbProduto.TabIndex = 38;
            this.cmbProduto.ValueMember = "codPro";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // pcProdutoBindingSource
            // 
            this.pcProdutoBindingSource.DataMember = "pc_Produto";
            this.pcProdutoBindingSource.DataSource = this.dsVendas;
            // 
            // pc_ProdutoTableAdapter
            // 
            this.pc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 776);
            this.Controls.Add(this.dgvItemCompra);
            this.Controls.Add(this.grbItemCompra);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(numCompraLabel);
            this.Controls.Add(this.txtNumCompra);
            this.Controls.Add(codForLabel);
            this.Controls.Add(this.cmbRazao);
            this.Controls.Add(dataCompraLabel);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(datEntregaLabel);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompra";
            this.Text = "Cadastro de Compra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcfornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.grbItemCompra.ResumeLayout(false);
            this.grbItemCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private DsVendas dsVendas;
        private System.Windows.Forms.BindingSource pc_compraBindingSource;
        private DsVendasTableAdapters.pc_compraTableAdapter pc_compraTableAdapter;
        private DsVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNumCompra;
        private System.Windows.Forms.ComboBox cmbRazao;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.RichTextBox txtObs;
        private DsVendasTableAdapters.pc_fornecedorTableAdapter pc_fornecedorTableAdapter;
        private System.Windows.Forms.BindingSource pcfornecedorBindingSource;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.GroupBox grbItemCompra;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.BindingSource pc_itemCompraBindingSource;
        private DsVendasTableAdapters.pc_itemCompraTableAdapter pc_itemCompraTableAdapter;
        private System.Windows.Forms.DataGridView dgvItemCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource;
        private DsVendasTableAdapters.pc_ProdutoTableAdapter pc_ProdutoTableAdapter;
    }
}