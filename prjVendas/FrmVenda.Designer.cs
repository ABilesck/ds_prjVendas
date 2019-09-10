namespace prjVendas
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numVendaLabel;
            System.Windows.Forms.Label dataVendaLabel;
            System.Windows.Forms.Label dataEntregaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label obsLabel1;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.dsVendas = new prjVendas.DsVendas();
            this.pc_VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_VendaTableAdapter = new prjVendas.DsVendasTableAdapters.pc_VendaTableAdapter();
            this.tableAdapterManager = new prjVendas.DsVendasTableAdapters.TableAdapterManager();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNumVenda = new System.Windows.Forms.TextBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.pcClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.grbItemVenda = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.pcProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.pcProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_ItemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_ItemVendaTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ItemVendaTableAdapter();
            this.pc_ClienteTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ClienteTableAdapter();
            this.dsVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_ProdutoTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ProdutoTableAdapter();
            this.pcClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pcClienteBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dgvItemVendas = new System.Windows.Forms.DataGridView();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.pcClienteBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.pcProdutoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numVendaLabel = new System.Windows.Forms.Label();
            dataVendaLabel = new System.Windows.Forms.Label();
            dataEntregaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            obsLabel1 = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource)).BeginInit();
            this.grbItemVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ItemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // numVendaLabel
            // 
            numVendaLabel.AutoSize = true;
            numVendaLabel.Location = new System.Drawing.Point(12, 60);
            numVendaLabel.Name = "numVendaLabel";
            numVendaLabel.Size = new System.Drawing.Size(41, 13);
            numVendaLabel.TabIndex = 19;
            numVendaLabel.Text = "Venda:";
            // 
            // dataVendaLabel
            // 
            dataVendaLabel.AutoSize = true;
            dataVendaLabel.Location = new System.Drawing.Point(12, 93);
            dataVendaLabel.Name = "dataVendaLabel";
            dataVendaLabel.Size = new System.Drawing.Size(82, 13);
            dataVendaLabel.TabIndex = 21;
            dataVendaLabel.Text = "Data da Venda:";
            // 
            // dataEntregaLabel
            // 
            dataEntregaLabel.AutoSize = true;
            dataEntregaLabel.Location = new System.Drawing.Point(219, 93);
            dataEntregaLabel.Name = "dataEntregaLabel";
            dataEntregaLabel.Size = new System.Drawing.Size(88, 13);
            dataEntregaLabel.TabIndex = 23;
            dataEntregaLabel.Text = "Data de Entrega:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(188, 60);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(42, 13);
            nomeLabel.TabIndex = 29;
            nomeLabel.Text = "Cliente:";
            // 
            // obsLabel1
            // 
            obsLabel1.AutoSize = true;
            obsLabel1.Location = new System.Drawing.Point(12, 126);
            obsLabel1.Name = "obsLabel1";
            obsLabel1.Size = new System.Drawing.Size(73, 13);
            obsLabel1.TabIndex = 30;
            obsLabel1.Text = "Observações:";
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
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(23, 80);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(47, 13);
            descricaoLabel.TabIndex = 32;
            descricaoLabel.Text = "Produto:";
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
            // dsVendas
            // 
            this.dsVendas.DataSetName = "DsVendas";
            this.dsVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_VendaBindingSource
            // 
            this.pc_VendaBindingSource.DataMember = "pc_Venda";
            this.pc_VendaBindingSource.DataSource = this.dsVendas;
            // 
            // pc_VendaTableAdapter
            // 
            this.pc_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_ClienteTableAdapter = null;
            this.tableAdapterManager.pc_compraTableAdapter = null;
            this.tableAdapterManager.pc_fornecedorTableAdapter = null;
            this.tableAdapterManager.pc_itemCompraTableAdapter = null;
            this.tableAdapterManager.pc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.pc_VendaTableAdapter = this.pc_VendaTableAdapter;
            this.tableAdapterManager.UpdateOrder = prjVendas.DsVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(59, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 13;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(140, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(221, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(302, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(383, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(464, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(586, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNumVenda
            // 
            this.txtNumVenda.Enabled = false;
            this.txtNumVenda.Location = new System.Drawing.Point(59, 57);
            this.txtNumVenda.Name = "txtNumVenda";
            this.txtNumVenda.Size = new System.Drawing.Size(92, 20);
            this.txtNumVenda.TabIndex = 20;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Enabled = false;
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(100, 87);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(100, 20);
            this.dtpDataVenda.TabIndex = 22;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(313, 87);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEntrega.TabIndex = 24;
            // 
            // pcClienteBindingSource1
            // 
            this.pcClienteBindingSource1.DataMember = "pc_Cliente";
            this.pcClienteBindingSource1.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource
            // 
            this.pcClienteBindingSource.DataMember = "pc_Cliente";
            this.pcClienteBindingSource.DataSource = this.dsVendas;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(94, 123);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(480, 55);
            this.txtObs.TabIndex = 31;
            this.txtObs.Text = "";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(580, 123);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(81, 55);
            this.btnTodos.TabIndex = 32;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // grbItemVenda
            // 
            this.grbItemVenda.Controls.Add(this.cmbProduto);
            this.grbItemVenda.Controls.Add(this.txtTotal);
            this.grbItemVenda.Controls.Add(this.label1);
            this.grbItemVenda.Controls.Add(quantidadeLabel);
            this.grbItemVenda.Controls.Add(this.nudQuantidade);
            this.grbItemVenda.Controls.Add(precoUnitLabel);
            this.grbItemVenda.Controls.Add(this.txtPrecoUnit);
            this.grbItemVenda.Controls.Add(descricaoLabel);
            this.grbItemVenda.Controls.Add(subtotalLabel);
            this.grbItemVenda.Controls.Add(this.txtSubTotal);
            this.grbItemVenda.Controls.Add(this.btnCancelarItem);
            this.grbItemVenda.Controls.Add(this.btnGravarItem);
            this.grbItemVenda.Controls.Add(this.btnPesquisarItem);
            this.grbItemVenda.Controls.Add(this.btnAlterarItem);
            this.grbItemVenda.Controls.Add(this.btnExcluirItem);
            this.grbItemVenda.Controls.Add(this.btnIncluirItem);
            this.grbItemVenda.Location = new System.Drawing.Point(15, 433);
            this.grbItemVenda.Name = "grbItemVenda";
            this.grbItemVenda.Size = new System.Drawing.Size(646, 142);
            this.grbItemVenda.TabIndex = 33;
            this.grbItemVenda.TabStop = false;
            this.grbItemVenda.Text = "Itens da Venda";
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
            // pcProdutoBindingSource1
            // 
            this.pcProdutoBindingSource1.DataMember = "pc_Produto";
            this.pcProdutoBindingSource1.DataSource = this.dsVendas;
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
            // pcProdutoBindingSource
            // 
            this.pcProdutoBindingSource.DataMember = "pc_Produto";
            this.pcProdutoBindingSource.DataSource = this.dsVendas;
            // 
            // pc_ItemVendaBindingSource
            // 
            this.pc_ItemVendaBindingSource.DataMember = "pc_ItemVenda";
            this.pc_ItemVendaBindingSource.DataSource = this.dsVendas;
            // 
            // pc_ItemVendaTableAdapter
            // 
            this.pc_ItemVendaTableAdapter.ClearBeforeFill = true;
            // 
            // pc_ClienteTableAdapter
            // 
            this.pc_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // dsVendasBindingSource
            // 
            this.dsVendasBindingSource.DataSource = this.dsVendas;
            this.dsVendasBindingSource.Position = 0;
            // 
            // pc_ProdutoTableAdapter
            // 
            this.pc_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // pcClienteBindingSource2
            // 
            this.pcClienteBindingSource2.DataMember = "pc_Cliente";
            this.pcClienteBindingSource2.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource8
            // 
            this.pcClienteBindingSource8.DataMember = "pc_Cliente";
            this.pcClienteBindingSource8.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource7
            // 
            this.pcClienteBindingSource7.DataMember = "pc_Cliente";
            this.pcClienteBindingSource7.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource6
            // 
            this.pcClienteBindingSource6.DataMember = "pc_Cliente";
            this.pcClienteBindingSource6.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource3
            // 
            this.pcClienteBindingSource3.DataMember = "pc_Cliente";
            this.pcClienteBindingSource3.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource4
            // 
            this.pcClienteBindingSource4.DataMember = "pc_Cliente";
            this.pcClienteBindingSource4.DataSource = this.dsVendas;
            // 
            // pcClienteBindingSource5
            // 
            this.pcClienteBindingSource5.DataMember = "pc_Cliente";
            this.pcClienteBindingSource5.DataSource = this.dsVendas;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvVendas.DataSource = this.pc_VendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(15, 197);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(646, 220);
            this.dgvVendas.TabIndex = 34;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            // 
            // dgvItemVendas
            // 
            this.dgvItemVendas.AllowUserToAddRows = false;
            this.dgvItemVendas.AllowUserToDeleteRows = false;
            this.dgvItemVendas.AutoGenerateColumns = false;
            this.dgvItemVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.dgvItemVendas.DataSource = this.pc_ItemVendaBindingSource;
            this.dgvItemVendas.Location = new System.Drawing.Point(15, 581);
            this.dgvItemVendas.Name = "dgvItemVendas";
            this.dgvItemVendas.ReadOnly = true;
            this.dgvItemVendas.RowHeadersVisible = false;
            this.dgvItemVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVendas.Size = new System.Drawing.Size(646, 220);
            this.dgvItemVendas.TabIndex = 33;
            // 
            // cmbNome
            // 
            this.cmbNome.DataSource = this.pcClienteBindingSource9;
            this.cmbNome.DisplayMember = "nome";
            this.cmbNome.Enabled = false;
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(236, 57);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(222, 21);
            this.cmbNome.TabIndex = 35;
            this.cmbNome.ValueMember = "codCli";
            // 
            // pcClienteBindingSource9
            // 
            this.pcClienteBindingSource9.DataMember = "pc_Cliente";
            this.pcClienteBindingSource9.DataSource = this.dsVendas;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.pcProdutoBindingSource2;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(26, 96);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(207, 21);
            this.cmbProduto.TabIndex = 38;
            this.cmbProduto.ValueMember = "codPro";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // pcProdutoBindingSource2
            // 
            this.pcProdutoBindingSource2.DataMember = "pc_Produto";
            this.pcProdutoBindingSource2.DataSource = this.dsVendas;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codPro";
            this.dataGridViewTextBoxColumn8.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "precoUnit";
            this.dataGridViewTextBoxColumn10.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn12.HeaderText = "Sub Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numVenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "numVenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dataVenda";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "dataVenda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataEntrega";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataEntrega";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codCli";
            this.dataGridViewTextBoxColumn4.HeaderText = "codCli";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "obs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 837);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.dgvItemVendas);
            this.Controls.Add(this.grbItemVenda);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(obsLabel1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(numVendaLabel);
            this.Controls.Add(this.txtNumVenda);
            this.Controls.Add(dataVendaLabel);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(dataEntregaLabel);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenda";
            this.Text = "Cadastro de Venda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource)).EndInit();
            this.grbItemVenda.ResumeLayout(false);
            this.grbItemVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ItemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClienteBindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdutoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsVendas dsVendas;
        private System.Windows.Forms.BindingSource pc_VendaBindingSource;
        private DsVendasTableAdapters.pc_VendaTableAdapter pc_VendaTableAdapter;
        private DsVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNumVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.GroupBox grbItemVenda;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.BindingSource pc_ItemVendaBindingSource;
        private DsVendasTableAdapters.pc_ItemVendaTableAdapter pc_ItemVendaTableAdapter;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pcClienteBindingSource;
        private DsVendasTableAdapters.pc_ClienteTableAdapter pc_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource dsVendasBindingSource;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource;
        private DsVendasTableAdapters.pc_ProdutoTableAdapter pc_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource pcClienteBindingSource1;
        private System.Windows.Forms.BindingSource pcClienteBindingSource2;
        private System.Windows.Forms.BindingSource pcClienteBindingSource3;
        private System.Windows.Forms.BindingSource pcClienteBindingSource4;
        private System.Windows.Forms.BindingSource pcClienteBindingSource5;
        private System.Windows.Forms.BindingSource pcClienteBindingSource6;
        private System.Windows.Forms.BindingSource pcClienteBindingSource7;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.BindingSource pcClienteBindingSource8;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource1;
        private System.Windows.Forms.DataGridView dgvItemVendas;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.BindingSource pcClienteBindingSource9;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.BindingSource pcProdutoBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}