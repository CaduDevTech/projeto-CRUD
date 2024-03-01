namespace projeto_CRUD
{
    partial class ADM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADM));
            menu = new MenuStrip();
            funcionarios = new ToolStripMenuItem();
            addFuncionario = new ToolStripMenuItem();
            consultarFuncionario = new ToolStripMenuItem();
            comprasRealizadas = new ToolStripMenuItem();
            clientes = new ToolStripMenuItem();
            consultarClientes = new ToolStripMenuItem();
            estoque = new ToolStripMenuItem();
            addProdutosMenu = new ToolStripMenuItem();
            consultarProdutosMenu = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCompra = new Button();
            RMA = new Button();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AllowMerge = false;
            menu.Dock = DockStyle.None;
            menu.Font = new Font("Segoe UI", 11F);
            menu.Items.AddRange(new ToolStripItem[] { funcionarios, comprasRealizadas, clientes, estoque, sairToolStripMenuItem });
            menu.Location = new Point(127, 62);
            menu.Name = "menu";
            menu.Size = new Size(488, 68);
            menu.TabIndex = 0;
            menu.TabStop = true;
            menu.Text = "menuStrip1";
            // 
            // funcionarios
            // 
            funcionarios.AutoSize = false;
            funcionarios.DropDownItems.AddRange(new ToolStripItem[] { addFuncionario, consultarFuncionario });
            funcionarios.Font = new Font("Segoe UI Historic", 11F);
            funcionarios.Image = (Image)resources.GetObject("funcionarios.Image");
            funcionarios.ImageScaling = ToolStripItemImageScaling.None;
            funcionarios.Name = "funcionarios";
            funcionarios.RightToLeftAutoMirrorImage = true;
            funcionarios.Size = new Size(104, 64);
            funcionarios.Text = "Funcionarios";
            funcionarios.TextImageRelation = TextImageRelation.ImageAboveText;
            funcionarios.Click += funcionarios_Click;
            // 
            // addFuncionario
            // 
            addFuncionario.Name = "addFuncionario";
            addFuncionario.Size = new Size(282, 24);
            addFuncionario.Text = "Adicionar/modificar funcinario";
            addFuncionario.Click += addFuncionario_Click;
            // 
            // consultarFuncionario
            // 
            consultarFuncionario.Name = "consultarFuncionario";
            consultarFuncionario.Size = new Size(282, 24);
            consultarFuncionario.Text = "Consultar Funcionario";
            consultarFuncionario.Click += consultarFuncionario_Click;
            // 
            // comprasRealizadas
            // 
            comprasRealizadas.Image = (Image)resources.GetObject("comprasRealizadas.Image");
            comprasRealizadas.ImageScaling = ToolStripItemImageScaling.None;
            comprasRealizadas.Margin = new Padding(0, 3, 0, 0);
            comprasRealizadas.Name = "comprasRealizadas";
            comprasRealizadas.Size = new Size(151, 61);
            comprasRealizadas.Text = "Compras realizadas";
            comprasRealizadas.TextImageRelation = TextImageRelation.ImageAboveText;
            comprasRealizadas.Click += comprasRealizadas_Click;
            // 
            // clientes
            // 
            clientes.DropDownItems.AddRange(new ToolStripItem[] { consultarClientes });
            clientes.Image = (Image)resources.GetObject("clientes.Image");
            clientes.ImageScaling = ToolStripItemImageScaling.None;
            clientes.Name = "clientes";
            clientes.Size = new Size(73, 64);
            clientes.Text = "Clientes";
            clientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // consultarClientes
            // 
            consultarClientes.Name = "consultarClientes";
            consultarClientes.Size = new Size(194, 24);
            consultarClientes.Text = "Consultar clientes";
            consultarClientes.Click += consultarClientes_Click;
            // 
            // estoque
            // 
            estoque.DropDownItems.AddRange(new ToolStripItem[] { addProdutosMenu, consultarProdutosMenu });
            estoque.Image = (Image)resources.GetObject("estoque.Image");
            estoque.ImageScaling = ToolStripItemImageScaling.None;
            estoque.Margin = new Padding(8, 0, 8, 0);
            estoque.Name = "estoque";
            estoque.Size = new Size(80, 64);
            estoque.Text = "Produtos";
            estoque.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // addProdutosMenu
            // 
            addProdutosMenu.Name = "addProdutosMenu";
            addProdutosMenu.Size = new Size(278, 24);
            addProdutosMenu.Text = "Adicionar / Atualizar Produtos";
            addProdutosMenu.Click += adicionarAtualizarProdutosToolStripMenuItem_Click;
            // 
            // consultarProdutosMenu
            // 
            consultarProdutosMenu.Name = "consultarProdutosMenu";
            consultarProdutosMenu.Size = new Size(278, 24);
            consultarProdutosMenu.Text = "Consultar Produtos";
            consultarProdutosMenu.Click += consultarProdutosMenu_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Padding = new Padding(8, 0, 4, 0);
            sairToolStripMenuItem.ShowShortcutKeys = false;
            sairToolStripMenuItem.Size = new Size(56, 64);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarCompra
            // 
            cadastrarCompra.BackColor = Color.White;
            cadastrarCompra.BackgroundImageLayout = ImageLayout.Center;
            cadastrarCompra.FlatAppearance.BorderColor = Color.White;
            cadastrarCompra.FlatAppearance.MouseDownBackColor = Color.White;
            cadastrarCompra.FlatAppearance.MouseOverBackColor = Color.White;
            cadastrarCompra.FlatStyle = FlatStyle.Flat;
            cadastrarCompra.Font = new Font("Segoe UI", 9F);
            cadastrarCompra.ForeColor = Color.Black;
            cadastrarCompra.Image = (Image)resources.GetObject("cadastrarCompra.Image");
            cadastrarCompra.Location = new Point(243, 153);
            cadastrarCompra.Name = "cadastrarCompra";
            cadastrarCompra.Size = new Size(85, 86);
            cadastrarCompra.TabIndex = 1;
            cadastrarCompra.Text = "Cadastrar Compra";
            cadastrarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            cadastrarCompra.UseMnemonic = false;
            cadastrarCompra.UseVisualStyleBackColor = false;
            cadastrarCompra.Click += cadastrarCompra_Click;
            // 
            // RMA
            // 
            RMA.BackColor = Color.White;
            RMA.BackgroundImageLayout = ImageLayout.Stretch;
            RMA.FlatAppearance.BorderColor = Color.White;
            RMA.FlatStyle = FlatStyle.Flat;
            RMA.Font = new Font("Segoe UI", 8F);
            RMA.Image = (Image)resources.GetObject("RMA.Image");
            RMA.Location = new Point(359, 151);
            RMA.Margin = new Padding(3, 0, 3, 0);
            RMA.Name = "RMA";
            RMA.Size = new Size(81, 88);
            RMA.TabIndex = 2;
            RMA.Text = "RMA e\r\n Devolucões";
            RMA.TextAlign = ContentAlignment.TopCenter;
            RMA.TextImageRelation = TextImageRelation.ImageAboveText;
            RMA.UseVisualStyleBackColor = false;
            // 
            // ADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(RMA);
            Controls.Add(cadastrarCompra);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menu;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicativo de Adiministração";
            Load += ADM_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem funcionarios;
        private ToolStripMenuItem clientes;
        private ToolStripMenuItem estoque;
        private ToolStripMenuItem addFuncionario;
        private ToolStripMenuItem consultarFuncionario;
        private ToolStripMenuItem consultarClientes;
        private ToolStripMenuItem comprasRealizadas;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem addProdutosMenu;
        private ToolStripMenuItem consultarProdutosMenu;
        private Button cadastrarCompra;
        private Button RMA;
    }
}
