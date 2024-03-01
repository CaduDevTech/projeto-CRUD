namespace projeto_CRUD
{
    partial class cadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroProdutos));
            salvarAlteracoes = new Button();
            buscar = new Button();
            idProduto = new TextBox();
            txtMarcaProduto = new Label();
            btnVoltar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnAdicionar = new Button();
            txtPrecoProduto = new Label();
            nomeProduto = new TextBox();
            txtNomeProduto = new Label();
            txtCategoriaProduto = new Label();
            txtQuantidadeProduto = new Label();
            categoriaProduto = new ComboBox();
            txtIDProduto = new Label();
            addMarcaProdutoBtn = new Button();
            addMarcaProduto = new TextBox();
            marcaProduto = new ComboBox();
            salvarAddMarcaProduto = new Button();
            precoProduto = new MaskedTextBox();
            quantidadeProduto = new ComboBox();
            label1 = new Label();
            salvarCategoria = new Button();
            addCategoriaProduto = new TextBox();
            categoriaProdutoBtn = new Button();
            SuspendLayout();
            // 
            // salvarAlteracoes
            // 
            salvarAlteracoes.Location = new Point(449, 153);
            salvarAlteracoes.Name = "salvarAlteracoes";
            salvarAlteracoes.Size = new Size(62, 23);
            salvarAlteracoes.TabIndex = 43;
            salvarAlteracoes.Text = "Salvar";
            salvarAlteracoes.UseVisualStyleBackColor = true;
            salvarAlteracoes.Click += salvarAlteracoes_Click;
            // 
            // buscar
            // 
            buscar.Location = new Point(388, 153);
            buscar.Name = "buscar";
            buscar.Size = new Size(53, 23);
            buscar.TabIndex = 42;
            buscar.Text = "buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // idProduto
            // 
            idProduto.Location = new Point(319, 153);
            idProduto.Name = "idProduto";
            idProduto.Size = new Size(61, 23);
            idProduto.TabIndex = 41;
            // 
            // txtMarcaProduto
            // 
            txtMarcaProduto.AutoSize = true;
            txtMarcaProduto.Font = new Font("Segoe UI", 10F);
            txtMarcaProduto.Location = new Point(177, 251);
            txtMarcaProduto.Name = "txtMarcaProduto";
            txtMarcaProduto.Size = new Size(101, 19);
            txtMarcaProduto.TabIndex = 38;
            txtMarcaProduto.Text = "Marca produto";
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(566, 48);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 65);
            btnVoltar.TabIndex = 37;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(465, 48);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 65);
            btnExcluir.TabIndex = 36;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(366, 48);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 65);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(269, 48);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 65);
            btnSalvar.TabIndex = 34;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageAlign = ContentAlignment.TopCenter;
            btnAdicionar.Location = new Point(177, 48);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 65);
            btnAdicionar.TabIndex = 33;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.TopCenter;
            btnAdicionar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.AutoSize = true;
            txtPrecoProduto.Font = new Font("Segoe UI", 10F);
            txtPrecoProduto.Location = new Point(181, 296);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(97, 19);
            txtPrecoProduto.TabIndex = 31;
            txtPrecoProduto.Text = "Preço produto";
            // 
            // nomeProduto
            // 
            nomeProduto.Location = new Point(284, 204);
            nomeProduto.Name = "nomeProduto";
            nomeProduto.Size = new Size(394, 23);
            nomeProduto.TabIndex = 24;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.AutoSize = true;
            txtNomeProduto.Font = new Font("Segoe UI", 10F);
            txtNomeProduto.Location = new Point(158, 208);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(120, 19);
            txtNomeProduto.TabIndex = 23;
            txtNomeProduto.Text = "Nome do produto";
            // 
            // txtCategoriaProduto
            // 
            txtCategoriaProduto.AutoSize = true;
            txtCategoriaProduto.Font = new Font("Segoe UI", 10F);
            txtCategoriaProduto.Location = new Point(156, 350);
            txtCategoriaProduto.Name = "txtCategoriaProduto";
            txtCategoriaProduto.Size = new Size(122, 19);
            txtCategoriaProduto.TabIndex = 46;
            txtCategoriaProduto.Text = "Categoria Produto";
            // 
            // txtQuantidadeProduto
            // 
            txtQuantidadeProduto.AutoSize = true;
            txtQuantidadeProduto.Font = new Font("Segoe UI", 10F);
            txtQuantidadeProduto.Location = new Point(197, 394);
            txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            txtQuantidadeProduto.Size = new Size(81, 19);
            txtQuantidadeProduto.TabIndex = 48;
            txtQuantidadeProduto.Text = "Quantidade";
            // 
            // categoriaProduto
            // 
            categoriaProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriaProduto.FormattingEnabled = true;
            categoriaProduto.Location = new Point(284, 346);
            categoriaProduto.Name = "categoriaProduto";
            categoriaProduto.Size = new Size(148, 23);
            categoriaProduto.TabIndex = 50;
            // 
            // txtIDProduto
            // 
            txtIDProduto.AutoSize = true;
            txtIDProduto.Font = new Font("Segoe UI", 9F);
            txtIDProduto.Location = new Point(349, 135);
            txtIDProduto.Name = "txtIDProduto";
            txtIDProduto.Size = new Size(140, 15);
            txtIDProduto.TabIndex = 51;
            txtIDProduto.Text = "Buscar por ID do produto";
            txtIDProduto.UseWaitCursor = true;
            // 
            // addMarcaProdutoBtn
            // 
            addMarcaProdutoBtn.Location = new Point(432, 251);
            addMarcaProdutoBtn.Name = "addMarcaProdutoBtn";
            addMarcaProdutoBtn.Size = new Size(20, 23);
            addMarcaProdutoBtn.TabIndex = 52;
            addMarcaProdutoBtn.Text = "+";
            addMarcaProdutoBtn.UseVisualStyleBackColor = true;
            addMarcaProdutoBtn.Click += addMarcaProdutoBtn_Click;
            // 
            // addMarcaProduto
            // 
            addMarcaProduto.Location = new Point(458, 250);
            addMarcaProduto.Name = "addMarcaProduto";
            addMarcaProduto.Size = new Size(130, 23);
            addMarcaProduto.TabIndex = 53;
            addMarcaProduto.Visible = false;
            // 
            // marcaProduto
            // 
            marcaProduto.FormattingEnabled = true;
            marcaProduto.Location = new Point(284, 251);
            marcaProduto.Name = "marcaProduto";
            marcaProduto.Size = new Size(142, 23);
            marcaProduto.TabIndex = 54;
            marcaProduto.SelectedIndexChanged += marcaProduto_SelectedIndexChanged;
            // 
            // salvarAddMarcaProduto
            // 
            salvarAddMarcaProduto.Font = new Font("Segoe UI", 8F);
            salvarAddMarcaProduto.Location = new Point(594, 241);
            salvarAddMarcaProduto.Name = "salvarAddMarcaProduto";
            salvarAddMarcaProduto.Size = new Size(56, 42);
            salvarAddMarcaProduto.TabIndex = 55;
            salvarAddMarcaProduto.Text = "Salvar \r\nMarca";
            salvarAddMarcaProduto.UseVisualStyleBackColor = true;
            salvarAddMarcaProduto.Visible = false;
            salvarAddMarcaProduto.Click += salvarAddMarcaProduto_Click;
            // 
            // precoProduto
            // 
            precoProduto.CutCopyMaskFormat = MaskFormat.IncludePrompt;
            precoProduto.Location = new Point(284, 296);
            precoProduto.Name = "precoProduto";
            precoProduto.Size = new Size(115, 23);
            precoProduto.TabIndex = 56;
            precoProduto.MaskInputRejected += precoProduto_Click;
            precoProduto.TextChanged += precoProduto_TextChanged;
            // 
            // quantidadeProduto
            // 
            quantidadeProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            quantidadeProduto.FormattingEnabled = true;
            quantidadeProduto.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            quantidadeProduto.Location = new Point(284, 393);
            quantidadeProduto.Name = "quantidadeProduto";
            quantidadeProduto.Size = new Size(121, 23);
            quantidadeProduto.TabIndex = 57;
            quantidadeProduto.SelectedIndexChanged += quantidadeProduto_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 58;
            label1.Text = "Cadastro de Produtos";
            // 
            // salvarCategoria
            // 
            salvarCategoria.Font = new Font("Segoe UI", 8F);
            salvarCategoria.Location = new Point(604, 335);
            salvarCategoria.Name = "salvarCategoria";
            salvarCategoria.Size = new Size(67, 42);
            salvarCategoria.TabIndex = 61;
            salvarCategoria.Text = "Salvar\r\nCategoria";
            salvarCategoria.UseVisualStyleBackColor = true;
            salvarCategoria.Visible = false;
            salvarCategoria.Click += salvarCategoria_Click;
            // 
            // addCategoriaProduto
            // 
            addCategoriaProduto.Location = new Point(468, 344);
            addCategoriaProduto.Name = "addCategoriaProduto";
            addCategoriaProduto.Size = new Size(130, 23);
            addCategoriaProduto.TabIndex = 60;
            addCategoriaProduto.Visible = false;
            // 
            // categoriaProdutoBtn
            // 
            categoriaProdutoBtn.Location = new Point(442, 345);
            categoriaProdutoBtn.Name = "categoriaProdutoBtn";
            categoriaProdutoBtn.Size = new Size(20, 23);
            categoriaProdutoBtn.TabIndex = 59;
            categoriaProdutoBtn.Text = "+";
            categoriaProdutoBtn.UseVisualStyleBackColor = true;
            categoriaProdutoBtn.Click += categoriaProdutoBtn_Click;
            // 
            // cadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 445);
            ControlBox = false;
            Controls.Add(salvarCategoria);
            Controls.Add(addCategoriaProduto);
            Controls.Add(categoriaProdutoBtn);
            Controls.Add(label1);
            Controls.Add(quantidadeProduto);
            Controls.Add(precoProduto);
            Controls.Add(salvarAddMarcaProduto);
            Controls.Add(marcaProduto);
            Controls.Add(addMarcaProduto);
            Controls.Add(addMarcaProdutoBtn);
            Controls.Add(txtIDProduto);
            Controls.Add(categoriaProduto);
            Controls.Add(txtQuantidadeProduto);
            Controls.Add(txtCategoriaProduto);
            Controls.Add(salvarAlteracoes);
            Controls.Add(buscar);
            Controls.Add(idProduto);
            Controls.Add(txtMarcaProduto);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPrecoProduto);
            Controls.Add(nomeProduto);
            Controls.Add(txtNomeProduto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadastroProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastroProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button salvarAlteracoes;
        private Button buscar;
        private TextBox idProduto;
        private Label txtMarcaProduto;
        private Button btnVoltar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnAdicionar;
        private Label txtPrecoProduto;
        private TextBox nomeProduto;
        private Label txtNomeProduto;
        private Label txtCategoriaProduto;
        private Label txtQuantidadeProduto;
        private ComboBox categoriaProduto;
        private Label txtIDProduto;
        private Button addMarcaProdutoBtn;
        private TextBox addMarcaProduto;
        private ComboBox marcaProduto;
        private Button salvarAddMarcaProduto;
        private MaskedTextBox precoProduto;
        private ComboBox quantidadeProduto;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button salvarCategoria;
        private TextBox addCategoriaProduto;
        private Button categoriaProdutoBtn;
    }
}