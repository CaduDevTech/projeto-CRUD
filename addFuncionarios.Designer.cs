namespace projeto_CRUD
{
    partial class addFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFuncionarios));
            txtNome = new Label();
            nome = new TextBox();
            txtNumeroTelefone = new Label();
            numeroTelefone = new MaskedTextBox();
            txtNumeroCelular = new Label();
            numeroCelular = new MaskedTextBox();
            txtEmail = new Label();
            email = new TextBox();
            btnAdicionar = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            txtcCargo = new Label();
            cargo = new TextBox();
            txtIdFuncionario = new Label();
            idFuncionario = new TextBox();
            buscar = new Button();
            salvarAlteracoes = new Button();
            numeroCasa = new TextBox();
            numeroCasaTxt = new Label();
            validador = new Button();
            CEP = new MaskedTextBox();
            rua = new TextBox();
            label8 = new Label();
            bairro = new TextBox();
            label6 = new Label();
            label4 = new Label();
            cidade = new TextBox();
            txtEndereço = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(159, 147);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(50, 19);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome ";
            txtNome.Click += label1_Click;
            // 
            // nome
            // 
            nome.Location = new Point(208, 144);
            nome.Name = "nome";
            nome.Size = new Size(394, 23);
            nome.TabIndex = 1;
            // 
            // txtNumeroTelefone
            // 
            txtNumeroTelefone.AutoSize = true;
            txtNumeroTelefone.Font = new Font("Segoe UI", 10F);
            txtNumeroTelefone.Location = new Point(340, 190);
            txtNumeroTelefone.Name = "txtNumeroTelefone";
            txtNumeroTelefone.Size = new Size(113, 19);
            txtNumeroTelefone.TabIndex = 4;
            txtNumeroTelefone.Text = "Numero Telefone";
            // 
            // numeroTelefone
            // 
            numeroTelefone.Location = new Point(459, 186);
            numeroTelefone.Mask = "(00) 0 0000 - 0000";
            numeroTelefone.Name = "numeroTelefone";
            numeroTelefone.Size = new Size(114, 23);
            numeroTelefone.TabIndex = 5;
            // 
            // txtNumeroCelular
            // 
            txtNumeroCelular.AutoSize = true;
            txtNumeroCelular.Font = new Font("Segoe UI", 10F);
            txtNumeroCelular.Location = new Point(102, 190);
            txtNumeroCelular.Name = "txtNumeroCelular";
            txtNumeroCelular.Size = new Size(102, 19);
            txtNumeroCelular.TabIndex = 6;
            txtNumeroCelular.Text = "Numero celular";
            // 
            // numeroCelular
            // 
            numeroCelular.Location = new Point(210, 186);
            numeroCelular.Mask = "(00) 0000 - 0000";
            numeroCelular.Name = "numeroCelular";
            numeroCelular.Size = new Size(100, 23);
            numeroCelular.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(163, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(41, 19);
            txtEmail.TabIndex = 8;
            txtEmail.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(210, 229);
            email.Name = "email";
            email.Size = new Size(365, 23);
            email.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageAlign = ContentAlignment.TopCenter;
            btnAdicionar.Location = new Point(181, 20);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 65);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.TopCenter;
            btnAdicionar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(271, 20);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 65);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(358, 20);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 65);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(453, 20);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 65);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(549, 20);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 65);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtcCargo
            // 
            txtcCargo.AutoSize = true;
            txtcCargo.Font = new Font("Segoe UI", 10F);
            txtcCargo.Location = new Point(157, 408);
            txtcCargo.Name = "txtcCargo";
            txtcCargo.Size = new Size(46, 19);
            txtcCargo.TabIndex = 17;
            txtcCargo.Text = "Cargo";
            // 
            // cargo
            // 
            cargo.Location = new Point(211, 404);
            cargo.Name = "cargo";
            cargo.Size = new Size(230, 23);
            cargo.TabIndex = 18;
            // 
            // txtIdFuncionario
            // 
            txtIdFuncionario.AutoSize = true;
            txtIdFuncionario.Location = new Point(241, 108);
            txtIdFuncionario.Name = "txtIdFuncionario";
            txtIdFuncionario.Size = new Size(84, 15);
            txtIdFuncionario.TabIndex = 19;
            txtIdFuncionario.Text = "ID Funcionario";
            txtIdFuncionario.Visible = false;
            // 
            // idFuncionario
            // 
            idFuncionario.Location = new Point(331, 104);
            idFuncionario.Name = "idFuncionario";
            idFuncionario.Size = new Size(51, 23);
            idFuncionario.TabIndex = 20;
            idFuncionario.Visible = false;
            idFuncionario.TextChanged += idFuncionario_TextChanged;
            // 
            // buscar
            // 
            buscar.Location = new Point(388, 104);
            buscar.Name = "buscar";
            buscar.Size = new Size(55, 23);
            buscar.TabIndex = 21;
            buscar.Text = "buscar";
            buscar.TextAlign = ContentAlignment.TopCenter;
            buscar.UseVisualStyleBackColor = true;
            buscar.Visible = false;
            buscar.Click += buscar_Click;
            // 
            // salvarAlteracoes
            // 
            salvarAlteracoes.Location = new Point(449, 104);
            salvarAlteracoes.Name = "salvarAlteracoes";
            salvarAlteracoes.Size = new Size(64, 23);
            salvarAlteracoes.TabIndex = 22;
            salvarAlteracoes.Text = "Salvar";
            salvarAlteracoes.UseVisualStyleBackColor = true;
            salvarAlteracoes.Visible = false;
            salvarAlteracoes.Click += salvarAlteracoes_Click;
            // 
            // numeroCasa
            // 
            numeroCasa.Enabled = false;
            numeroCasa.Location = new Point(439, 277);
            numeroCasa.MaxLength = 3;
            numeroCasa.Name = "numeroCasa";
            numeroCasa.Size = new Size(56, 23);
            numeroCasa.TabIndex = 73;
            numeroCasa.TextAlign = HorizontalAlignment.Center;
            // 
            // numeroCasaTxt
            // 
            numeroCasaTxt.AutoSize = true;
            numeroCasaTxt.Enabled = false;
            numeroCasaTxt.Font = new Font("Segoe UI", 10F);
            numeroCasaTxt.Location = new Point(373, 280);
            numeroCasaTxt.Name = "numeroCasaTxt";
            numeroCasaTxt.Size = new Size(60, 19);
            numeroCasaTxt.TabIndex = 72;
            numeroCasaTxt.Text = "N° Casa:";
            // 
            // validador
            // 
            validador.BackgroundImageLayout = ImageLayout.Stretch;
            validador.FlatAppearance.BorderColor = Color.White;
            validador.FlatStyle = FlatStyle.Flat;
            validador.Location = new Point(336, 278);
            validador.Name = "validador";
            validador.Size = new Size(34, 23);
            validador.TabIndex = 71;
            validador.TextImageRelation = TextImageRelation.ImageAboveText;
            validador.UseVisualStyleBackColor = true;
            validador.Visible = false;
            validador.Click += validador_Click;
            // 
            // CEP
            // 
            CEP.Location = new Point(211, 278);
            CEP.Mask = "00000-000";
            CEP.Name = "CEP";
            CEP.Size = new Size(121, 23);
            CEP.TabIndex = 70;
            CEP.TextAlign = HorizontalAlignment.Center;
            CEP.TextChanged += CEP_TextChanged;
            // 
            // rua
            // 
            rua.Enabled = false;
            rua.Font = new Font("Segoe UI", 10F);
            rua.Location = new Point(544, 334);
            rua.MinimumSize = new Size(140, 23);
            rua.Multiline = true;
            rua.Name = "rua";
            rua.Size = new Size(140, 23);
            rua.TabIndex = 69;
            rua.TextAlign = HorizontalAlignment.Center;
            rua.WordWrap = false;
            rua.TextChanged += rua_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(511, 342);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 68;
            label8.Text = "RUA";
            // 
            // bairro
            // 
            bairro.Enabled = false;
            bairro.Font = new Font("Segoe UI", 10F);
            bairro.Location = new Point(341, 334);
            bairro.MinimumSize = new Size(140, 23);
            bairro.Multiline = true;
            bairro.Name = "bairro";
            bairro.Size = new Size(167, 23);
            bairro.TabIndex = 67;
            bairro.TextAlign = HorizontalAlignment.Center;
            bairro.TextChanged += bairro_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(84, 342);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 66;
            label6.Text = "CIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(287, 342);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 65;
            label4.Text = "BAIRRO";
            // 
            // cidade
            // 
            cidade.Enabled = false;
            cidade.Font = new Font("Segoe UI", 10F);
            cidade.Location = new Point(142, 334);
            cidade.MinimumSize = new Size(140, 23);
            cidade.Multiline = true;
            cidade.Name = "cidade";
            cidade.Size = new Size(140, 23);
            cidade.TabIndex = 64;
            cidade.TextAlign = HorizontalAlignment.Center;
            cidade.TextChanged += cidade_TextChanged;
            // 
            // txtEndereço
            // 
            txtEndereço.AutoSize = true;
            txtEndereço.Font = new Font("Segoe UI", 10F);
            txtEndereço.Location = new Point(170, 282);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(33, 19);
            txtEndereço.TabIndex = 63;
            txtEndereço.Text = "CEP";
            // 
            // addFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(791, 476);
            ControlBox = false;
            Controls.Add(numeroCasa);
            Controls.Add(numeroCasaTxt);
            Controls.Add(validador);
            Controls.Add(CEP);
            Controls.Add(rua);
            Controls.Add(label8);
            Controls.Add(bairro);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cidade);
            Controls.Add(txtEndereço);
            Controls.Add(salvarAlteracoes);
            Controls.Add(buscar);
            Controls.Add(idFuncionario);
            Controls.Add(txtIdFuncionario);
            Controls.Add(cargo);
            Controls.Add(txtcCargo);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnAdicionar);
            Controls.Add(email);
            Controls.Add(txtEmail);
            Controls.Add(numeroCelular);
            Controls.Add(txtNumeroCelular);
            Controls.Add(numeroTelefone);
            Controls.Add(txtNumeroTelefone);
            Controls.Add(nome);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "addFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNome;
        private TextBox nome;
        private Label txtNumeroTelefone;
        private MaskedTextBox numeroTelefone;
        private Label txtNumeroCelular;
        private MaskedTextBox numeroCelular;
        private Label txtEmail;
        private TextBox email;
        private Button btnAdicionar;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnVoltar;
        private Label txtcCargo;
        private TextBox cargo;
        private Label txtIdFuncionario;
        private TextBox idFuncionario;
        private Button buscar;
        private Button salvarAlteracoes;
        private TextBox numeroCasa;
        private Label numeroCasaTxt;
        private Button validador;
        private MaskedTextBox CEP;
        private TextBox rua;
        private Label label8;
        private TextBox bairro;
        private Label label6;
        private Label label4;
        private TextBox cidade;
        private Label txtEndereço;
    }
}