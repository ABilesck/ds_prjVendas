﻿namespace prjVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadCliente = new System.Windows.Forms.ToolStripButton();
            this.btnProduto = new System.Windows.Forms.ToolStripButton();
            this.btnVenda = new System.Windows.Forms.ToolStripButton();
            this.tsbFornecedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.tsbCompra = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFecharTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.relatórioToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCliente,
            this.mnuProduto,
            this.mnuVenda,
            this.mnuFornecedor,
            this.mnuCompra,
            this.toolStripSeparator1,
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // mnuCliente
            // 
            this.mnuCliente.Image = ((System.Drawing.Image)(resources.GetObject("mnuCliente.Image")));
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(211, 22);
            this.mnuCliente.Text = "Cadastro de &Clientes";
            this.mnuCliente.Click += new System.EventHandler(this.mnuCliente_Click);
            // 
            // mnuProduto
            // 
            this.mnuProduto.Image = ((System.Drawing.Image)(resources.GetObject("mnuProduto.Image")));
            this.mnuProduto.Name = "mnuProduto";
            this.mnuProduto.Size = new System.Drawing.Size(211, 22);
            this.mnuProduto.Text = "Cadastro de &Produtos";
            this.mnuProduto.Click += new System.EventHandler(this.mnuProduto_Click);
            // 
            // mnuVenda
            // 
            this.mnuVenda.Image = ((System.Drawing.Image)(resources.GetObject("mnuVenda.Image")));
            this.mnuVenda.Name = "mnuVenda";
            this.mnuVenda.Size = new System.Drawing.Size(211, 22);
            this.mnuVenda.Text = "Cadastro de &Vendas";
            this.mnuVenda.Click += new System.EventHandler(this.mnuVenda_Click);
            // 
            // mnuFornecedor
            // 
            this.mnuFornecedor.Image = global::prjVendas.Properties.Resources.untitled;
            this.mnuFornecedor.Name = "mnuFornecedor";
            this.mnuFornecedor.Size = new System.Drawing.Size(211, 22);
            this.mnuFornecedor.Text = "Cadastro de Fornecedores";
            this.mnuFornecedor.Click += new System.EventHandler(this.mnuFornecedor_Click);
            // 
            // mnuCompra
            // 
            this.mnuCompra.Image = ((System.Drawing.Image)(resources.GetObject("mnuCompra.Image")));
            this.mnuCompra.Name = "mnuCompra";
            this.mnuCompra.Size = new System.Drawing.Size(211, 22);
            this.mnuCompra.Text = "Cadastro de Compras";
            this.mnuCompra.Click += new System.EventHandler(this.mnuCompra_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(211, 22);
            this.mnuSair.Text = "&Sair";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatorioCliente});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // mnuRelatorioCliente
            // 
            this.mnuRelatorioCliente.Name = "mnuRelatorioCliente";
            this.mnuRelatorioCliente.Size = new System.Drawing.Size(116, 22);
            this.mnuRelatorioCliente.Text = "Clientes";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascata,
            this.mnuVertical,
            this.mnuHorizontal,
            this.toolStripSeparator4,
            this.mnuFecharTodos});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "&Janela";
            // 
            // mnuCascata
            // 
            this.mnuCascata.Name = "mnuCascata";
            this.mnuCascata.Size = new System.Drawing.Size(201, 22);
            this.mnuCascata.Text = "Cascata";
            this.mnuCascata.Click += new System.EventHandler(this.mnuCascata_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(201, 22);
            this.mnuVertical.Text = "Lado a lado - vertical";
            this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
            // 
            // mnuHorizontal
            // 
            this.mnuHorizontal.Name = "mnuHorizontal";
            this.mnuHorizontal.Size = new System.Drawing.Size(201, 22);
            this.mnuHorizontal.Text = "Lado a lado - Horizontal";
            this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadCliente,
            this.btnProduto,
            this.btnVenda,
            this.tsbFornecedor,
            this.tsbCompra,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCliente.Image")));
            this.btnCadCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(23, 22);
            this.btnCadCliente.Text = "Cliente";
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(23, 22);
            this.btnProduto.Text = "Produto";
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(23, 22);
            this.btnVenda.Text = "Venda";
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // tsbFornecedor
            // 
            this.tsbFornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFornecedor.Image = global::prjVendas.Properties.Resources.untitled;
            this.tsbFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFornecedor.Name = "tsbFornecedor";
            this.tsbFornecedor.Size = new System.Drawing.Size(23, 22);
            this.tsbFornecedor.Text = "Fornecedor";
            this.tsbFornecedor.Click += new System.EventHandler(this.tsbFornecedor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(615, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = false;
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(170, 17);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // tsbCompra
            // 
            this.tsbCompra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCompra.Image = ((System.Drawing.Image)(resources.GetObject("tsbCompra.Image")));
            this.tsbCompra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCompra.Name = "tsbCompra";
            this.tsbCompra.Size = new System.Drawing.Size(23, 22);
            this.tsbCompra.Text = "Compra";
            this.tsbCompra.Click += new System.EventHandler(this.tsbCompra_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // mnuFecharTodos
            // 
            this.mnuFecharTodos.Name = "mnuFecharTodos";
            this.mnuFecharTodos.Size = new System.Drawing.Size(201, 22);
            this.mnuFecharTodos.Text = "Fechar Todos";
            this.mnuFecharTodos.Click += new System.EventHandler(this.mnuFecharTodos_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuProduto;
        private System.Windows.Forms.ToolStripMenuItem mnuVenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripButton btnCadCliente;
        private System.Windows.Forms.ToolStripButton btnVenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFornecedor;
        private System.Windows.Forms.ToolStripButton btnProduto;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCascata;
        private System.Windows.Forms.ToolStripMenuItem mnuVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem mnuCompra;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioCliente;
        private System.Windows.Forms.ToolStripButton tsbCompra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuFecharTodos;
    }
}