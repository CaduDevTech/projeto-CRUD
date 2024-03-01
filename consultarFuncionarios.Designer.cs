namespace projeto_CRUD
{
    partial class consultarFuncionários
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarFuncionários));
            gridFuncionarios = new ListView();
            buscar = new Button();
            txtBuscar = new TextBox();
            textoConsulta = new Label();
            textoBuscar = new Label();
            voltarConsulta = new Button();
            mostrarTudoConsulta = new Button();
            SuspendLayout();
            // 
            // gridFuncionarios
            // 
            gridFuncionarios.Location = new Point(12, 129);
            gridFuncionarios.Name = "gridFuncionarios";
            gridFuncionarios.Size = new Size(947, 384);
            gridFuncionarios.TabIndex = 35;
            gridFuncionarios.UseCompatibleStateImageBehavior = false;
            // 
            // buscar
            // 
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(449, 44);
            buscar.Name = "buscar";
            buscar.Size = new Size(50, 68);
            buscar.TabIndex = 36;
            buscar.Text = "Buscar";
            buscar.TextImageRelation = TextImageRelation.ImageAboveText;
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(166, 89);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(271, 23);
            txtBuscar.TabIndex = 37;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // textoConsulta
            // 
            textoConsulta.AutoSize = true;
            textoConsulta.Font = new Font("Segoe UI", 11F);
            textoConsulta.Location = new Point(275, 9);
            textoConsulta.Name = "textoConsulta";
            textoConsulta.Size = new Size(174, 20);
            textoConsulta.TabIndex = 39;
            textoConsulta.Text = "Consulta de Funcionarios";
            // 
            // textoBuscar
            // 
            textoBuscar.AutoSize = true;
            textoBuscar.Location = new Point(222, 71);
            textoBuscar.Name = "textoBuscar";
            textoBuscar.Size = new Size(163, 15);
            textoBuscar.TabIndex = 40;
            textoBuscar.Text = "Digite o nome do funcionario";
            // 
            // voltarConsulta
            // 
            voltarConsulta.Image = (Image)resources.GetObject("voltarConsulta.Image");
            voltarConsulta.Location = new Point(569, 44);
            voltarConsulta.Margin = new Padding(3, 0, 3, 3);
            voltarConsulta.Name = "voltarConsulta";
            voltarConsulta.Size = new Size(54, 67);
            voltarConsulta.TabIndex = 41;
            voltarConsulta.Text = "Voltar";
            voltarConsulta.TextImageRelation = TextImageRelation.ImageAboveText;
            voltarConsulta.UseVisualStyleBackColor = true;
            voltarConsulta.Click += voltarConsulta_Click;
            // 
            // mostrarTudoConsulta
            // 
            mostrarTudoConsulta.Location = new Point(505, 44);
            mostrarTudoConsulta.Name = "mostrarTudoConsulta";
            mostrarTudoConsulta.Size = new Size(58, 67);
            mostrarTudoConsulta.TabIndex = 42;
            mostrarTudoConsulta.Text = "Mostrar Todos";
            mostrarTudoConsulta.UseVisualStyleBackColor = true;
            mostrarTudoConsulta.Click += mostrarTudoConsulta_Click;
            // 
            // consultarFuncionários
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 525);
            Controls.Add(mostrarTudoConsulta);
            Controls.Add(voltarConsulta);
            Controls.Add(textoBuscar);
            Controls.Add(textoConsulta);
            Controls.Add(txtBuscar);
            Controls.Add(buscar);
            Controls.Add(gridFuncionarios);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "consultarFuncionários";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Funcionarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView gridFuncionarios;
        private Button buscar;
        private TextBox txtBuscar;
        private Label textoConsulta;
        private Label textoBuscar;
        private Button voltarConsulta;
        private Button mostrarTudoConsulta;
    }
}