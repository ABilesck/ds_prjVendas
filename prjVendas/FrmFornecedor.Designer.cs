namespace prjVendas
{
    partial class FrmFornecedor
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
            System.Windows.Forms.Label razaoLabel;
            System.Windows.Forms.Label fantasiaLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label ieLabel;
            System.Windows.Forms.Label datacadLabel;
            System.Windows.Forms.Label ufLabel;
            this.dsVendas = new prjVendas.DsVendas();
            this.pc_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_fornecedorTableAdapter = new prjVendas.DsVendasTableAdapters.pc_fornecedorTableAdapter();
            this.tableAdapterManager = new prjVendas.DsVendasTableAdapters.TableAdapterManager();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtIe = new System.Windows.Forms.MaskedTextBox();
            this.dtpDatacad = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtUf = new System.Windows.Forms.MaskedTextBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            razaoLabel = new System.Windows.Forms.Label();
            fantasiaLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ieLabel = new System.Windows.Forms.Label();
            datacadLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // razaoLabel
            // 
            razaoLabel.AutoSize = true;
            razaoLabel.Location = new System.Drawing.Point(57, 65);
            razaoLabel.Name = "razaoLabel";
            razaoLabel.Size = new System.Drawing.Size(41, 13);
            razaoLabel.TabIndex = 3;
            razaoLabel.Text = "Razão:";
            // 
            // fantasiaLabel
            // 
            fantasiaLabel.AutoSize = true;
            fantasiaLabel.Location = new System.Drawing.Point(23, 91);
            fantasiaLabel.Name = "fantasiaLabel";
            fantasiaLabel.Size = new System.Drawing.Size(78, 13);
            fantasiaLabel.TabIndex = 5;
            fantasiaLabel.Text = "Nome fantasia:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(42, 118);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(313, 91);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(319, 118);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 11;
            bairroLabel.Text = "Bairro:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(325, 68);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 15;
            cepLabel.Text = "CEP:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(49, 144);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "Telefone:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(71, 172);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 19;
            faxLabel.Text = "Fax:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(325, 144);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(31, 13);
            cnpjLabel.TabIndex = 21;
            cnpjLabel.Text = "Cnpj:";
            // 
            // ieLabel
            // 
            ieLabel.AutoSize = true;
            ieLabel.Location = new System.Drawing.Point(336, 172);
            ieLabel.Name = "ieLabel";
            ieLabel.Size = new System.Drawing.Size(20, 13);
            ieLabel.TabIndex = 23;
            ieLabel.Text = "IE:";
            // 
            // datacadLabel
            // 
            datacadLabel.AutoSize = true;
            datacadLabel.Location = new System.Drawing.Point(5, 202);
            datacadLabel.Name = "datacadLabel";
            datacadLabel.Size = new System.Drawing.Size(93, 13);
            datacadLabel.TabIndex = 25;
            datacadLabel.Text = "Data de Cadastro:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(332, 198);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(24, 13);
            ufLabel.TabIndex = 13;
            ufLabel.Text = "UF:";
            // 
            // dsVendas
            // 
            this.dsVendas.DataSetName = "DsVendas";
            this.dsVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_fornecedorBindingSource
            // 
            this.pc_fornecedorBindingSource.DataMember = "pc_fornecedor";
            this.pc_fornecedorBindingSource.DataSource = this.dsVendas;
            // 
            // pc_fornecedorTableAdapter
            // 
            this.pc_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_ClienteTableAdapter = null;
            this.tableAdapterManager.pc_compraTableAdapter = null;
            this.tableAdapterManager.pc_fornecedorTableAdapter = this.pc_fornecedorTableAdapter;
            this.tableAdapterManager.pc_itemCompraTableAdapter = null;
            this.tableAdapterManager.pc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.pc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjVendas.DsVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtRazao
            // 
            this.txtRazao.Enabled = false;
            this.txtRazao.Location = new System.Drawing.Point(104, 62);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(200, 20);
            this.txtRazao.TabIndex = 4;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Enabled = false;
            this.txtFantasia.Location = new System.Drawing.Point(104, 88);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(200, 20);
            this.txtFantasia.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(104, 115);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(362, 88);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(212, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(362, 115);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(212, 20);
            this.txtBairro.TabIndex = 12;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(362, 61);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(212, 20);
            this.txtCep.TabIndex = 16;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(104, 141);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtTelefone.TabIndex = 18;
            // 
            // txtFax
            // 
            this.txtFax.Enabled = false;
            this.txtFax.Location = new System.Drawing.Point(104, 169);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(200, 20);
            this.txtFax.TabIndex = 20;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(362, 141);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(212, 20);
            this.txtCnpj.TabIndex = 22;
            // 
            // txtIe
            // 
            this.txtIe.Enabled = false;
            this.txtIe.Location = new System.Drawing.Point(362, 169);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(212, 20);
            this.txtIe.TabIndex = 24;
            // 
            // dtpDatacad
            // 
            this.dtpDatacad.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_fornecedorBindingSource, "datacad", true));
            this.dtpDatacad.Enabled = false;
            this.dtpDatacad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatacad.Location = new System.Drawing.Point(104, 196);
            this.dtpDatacad.Name = "dtpDatacad";
            this.dtpDatacad.Size = new System.Drawing.Size(95, 20);
            this.dtpDatacad.TabIndex = 26;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(498, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(417, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(336, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 31;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(255, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(174, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(93, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 27;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtUf
            // 
            this.txtUf.Enabled = false;
            this.txtUf.Location = new System.Drawing.Point(362, 195);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(38, 20);
            this.txtUf.TabIndex = 34;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AutoGenerateColumns = false;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dgvFornecedores.DataSource = this.pc_fornecedorBindingSource;
            this.dgvFornecedores.Location = new System.Drawing.Point(12, 222);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(561, 214);
            this.dgvFornecedores.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "razao";
            this.dataGridViewTextBoxColumn2.HeaderText = "razao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fantasia";
            this.dataGridViewTextBoxColumn3.HeaderText = "fantasia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn7.HeaderText = "uf";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn8.HeaderText = "cep";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn9.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fax";
            this.dataGridViewTextBoxColumn10.HeaderText = "fax";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn11.HeaderText = "cnpj";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ie";
            this.dataGridViewTextBoxColumn12.HeaderText = "ie";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "datacad";
            this.dataGridViewTextBoxColumn13.HeaderText = "datacad";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 448);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(razaoLabel);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(fantasiaLabel);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(ufLabel);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(ieLabel);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(datacadLabel);
            this.Controls.Add(this.dtpDatacad);
            this.Name = "FrmFornecedor";
            this.Text = "FrmFornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsVendas dsVendas;
        private System.Windows.Forms.BindingSource pc_fornecedorBindingSource;
        private DsVendasTableAdapters.pc_fornecedorTableAdapter pc_fornecedorTableAdapter;
        private DsVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtIe;
        private System.Windows.Forms.DateTimePicker dtpDatacad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.MaskedTextBox txtUf;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}