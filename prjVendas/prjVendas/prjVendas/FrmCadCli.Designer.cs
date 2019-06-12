namespace prjVendas
{
    partial class FrmCadCli
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
            System.Windows.Forms.Label codCliLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label dataNascLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCli));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.pc_ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVendas = new prjVendas.DsVendas();
            this.codCliTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.ufMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataNascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pc_ClienteTableAdapter = new prjVendas.DsVendasTableAdapters.pc_ClienteTableAdapter();
            this.tableAdapterManager = new prjVendas.DsVendasTableAdapters.TableAdapterManager();
            codCliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            dataNascLabel = new System.Windows.Forms.Label();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codCliLabel
            // 
            codCliLabel.AutoSize = true;
            codCliLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codCliLabel.ForeColor = System.Drawing.Color.White;
            codCliLabel.Location = new System.Drawing.Point(9, 17);
            codCliLabel.Name = "codCliLabel";
            codCliLabel.Size = new System.Drawing.Size(140, 18);
            codCliLabel.TabIndex = 0;
            codCliLabel.Text = "Código do Cliente:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(293, 17);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 18);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.ForeColor = System.Drawing.Color.White;
            enderecoLabel.Location = new System.Drawing.Point(9, 99);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(81, 18);
            enderecoLabel.TabIndex = 4;
            enderecoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.Color.White;
            cidadeLabel.Location = new System.Drawing.Point(7, 140);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(62, 18);
            cidadeLabel.TabIndex = 6;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.Color.White;
            bairroLabel.Location = new System.Drawing.Point(439, 99);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(56, 18);
            bairroLabel.TabIndex = 8;
            bairroLabel.Text = "Bairro:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ufLabel.ForeColor = System.Drawing.Color.White;
            ufLabel.Location = new System.Drawing.Point(343, 140);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(32, 18);
            ufLabel.TabIndex = 10;
            ufLabel.Text = "UF:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.ForeColor = System.Drawing.Color.White;
            cepLabel.Location = new System.Drawing.Point(439, 140);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(43, 18);
            cepLabel.TabIndex = 12;
            cepLabel.Text = "CEP:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.ForeColor = System.Drawing.Color.White;
            telefoneLabel.Location = new System.Drawing.Point(4, 181);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 18);
            telefoneLabel.TabIndex = 14;
            telefoneLabel.Text = "Telefone:";
            // 
            // dataNascLabel
            // 
            dataNascLabel.AutoSize = true;
            dataNascLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataNascLabel.ForeColor = System.Drawing.Color.White;
            dataNascLabel.Location = new System.Drawing.Point(294, 181);
            dataNascLabel.Name = "dataNascLabel";
            dataNascLabel.Size = new System.Drawing.Size(153, 18);
            dataNascLabel.TabIndex = 16;
            dataNascLabel.Text = "Data de Nascimento:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(953, 61);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampos.BackColor = System.Drawing.Color.Transparent;
            this.pnlCampos.Controls.Add(this.pc_ClienteDataGridView);
            this.pnlCampos.Controls.Add(codCliLabel);
            this.pnlCampos.Controls.Add(this.codCliTextBox);
            this.pnlCampos.Controls.Add(nomeLabel);
            this.pnlCampos.Controls.Add(this.nomeTextBox);
            this.pnlCampos.Controls.Add(enderecoLabel);
            this.pnlCampos.Controls.Add(this.enderecoTextBox);
            this.pnlCampos.Controls.Add(cidadeLabel);
            this.pnlCampos.Controls.Add(this.cidadeTextBox);
            this.pnlCampos.Controls.Add(bairroLabel);
            this.pnlCampos.Controls.Add(this.bairroTextBox);
            this.pnlCampos.Controls.Add(ufLabel);
            this.pnlCampos.Controls.Add(this.ufMaskedTextBox);
            this.pnlCampos.Controls.Add(cepLabel);
            this.pnlCampos.Controls.Add(this.cepMaskedTextBox);
            this.pnlCampos.Controls.Add(telefoneLabel);
            this.pnlCampos.Controls.Add(this.telefoneMaskedTextBox);
            this.pnlCampos.Controls.Add(dataNascLabel);
            this.pnlCampos.Controls.Add(this.dataNascDateTimePicker);
            this.pnlCampos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCampos.ForeColor = System.Drawing.Color.Black;
            this.pnlCampos.Location = new System.Drawing.Point(13, 76);
            this.pnlCampos.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(954, 511);
            this.pnlCampos.TabIndex = 3;
            // 
            // pc_ClienteDataGridView
            // 
            this.pc_ClienteDataGridView.AllowUserToAddRows = false;
            this.pc_ClienteDataGridView.AllowUserToDeleteRows = false;
            this.pc_ClienteDataGridView.AutoGenerateColumns = false;
            this.pc_ClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pc_ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pc_ClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pc_ClienteDataGridView.DataSource = this.pc_ClienteBindingSource;
            this.pc_ClienteDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.pc_ClienteDataGridView.Location = new System.Drawing.Point(0, 236);
            this.pc_ClienteDataGridView.Name = "pc_ClienteDataGridView";
            this.pc_ClienteDataGridView.ReadOnly = true;
            this.pc_ClienteDataGridView.Size = new System.Drawing.Size(954, 273);
            this.pc_ClienteDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codCli";
            this.dataGridViewTextBoxColumn1.HeaderText = "codCli";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn5.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn6.HeaderText = "uf";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn7.HeaderText = "cep";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn8.HeaderText = "telefone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dataNasc";
            this.dataGridViewTextBoxColumn9.HeaderText = "dataNasc";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // pc_ClienteBindingSource
            // 
            this.pc_ClienteBindingSource.DataMember = "pc_Cliente";
            this.pc_ClienteBindingSource.DataSource = this.dsVendas;
            // 
            // dsVendas
            // 
            this.dsVendas.DataSetName = "DsVendas";
            this.dsVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codCliTextBox
            // 
            this.codCliTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.codCliTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codCliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "codCli", true));
            this.codCliTextBox.Location = new System.Drawing.Point(155, 15);
            this.codCliTextBox.Name = "codCliTextBox";
            this.codCliTextBox.Size = new System.Drawing.Size(89, 25);
            this.codCliTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(352, 15);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(405, 25);
            this.nomeTextBox.TabIndex = 3;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(96, 97);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(320, 25);
            this.enderecoTextBox.TabIndex = 5;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(75, 137);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(262, 25);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bairroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(501, 97);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(238, 25);
            this.bairroTextBox.TabIndex = 9;
            // 
            // ufMaskedTextBox
            // 
            this.ufMaskedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ufMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ufMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "uf", true));
            this.ufMaskedTextBox.Location = new System.Drawing.Point(381, 137);
            this.ufMaskedTextBox.Name = "ufMaskedTextBox";
            this.ufMaskedTextBox.Size = new System.Drawing.Size(52, 25);
            this.ufMaskedTextBox.TabIndex = 11;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cepMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "cep", true));
            this.cepMaskedTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cepMaskedTextBox.Location = new System.Drawing.Point(488, 137);
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(238, 25);
            this.cepMaskedTextBox.TabIndex = 13;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.telefoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_ClienteBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(85, 178);
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(200, 25);
            this.telefoneMaskedTextBox.TabIndex = 15;
            // 
            // dataNascDateTimePicker
            // 
            this.dataNascDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dataNascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_ClienteBindingSource, "dataNasc", true));
            this.dataNascDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascDateTimePicker.Location = new System.Drawing.Point(453, 178);
            this.dataNascDateTimePicker.Name = "dataNascDateTimePicker";
            this.dataNascDateTimePicker.Size = new System.Drawing.Size(114, 25);
            this.dataNascDateTimePicker.TabIndex = 17;
            // 
            // pc_ClienteTableAdapter
            // 
            this.pc_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_ClienteTableAdapter = this.pc_ClienteTableAdapter;
            this.tableAdapterManager.pc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.pc_ProdutoTableAdapter = null;
            this.tableAdapterManager.pc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjVendas.DsVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(978, 632);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadCli";
            this.Text = "Cadastro de Clientes";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private DsVendas dsVendas;
        private System.Windows.Forms.BindingSource pc_ClienteBindingSource;
        private DsVendasTableAdapters.pc_ClienteTableAdapter pc_ClienteTableAdapter;
        private DsVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codCliTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.MaskedTextBox ufMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dataNascDateTimePicker;
        private System.Windows.Forms.DataGridView pc_ClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

