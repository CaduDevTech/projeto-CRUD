using System.Security.Cryptography.X509Certificates;

namespace projeto_CRUD
{
    public partial class ADM : Form
    {
        public ADM()
        {
            InitializeComponent();
        }


        private void ADM_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você tem certeza da sua saida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica qual botão foi clicado
            if (resultado == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (resultado == DialogResult.No)
            {
                // Código a ser executado se o usuário clicar em "Não"
                return;
            }
        }

        private void addFuncionario_Click(object sender, EventArgs e)
        {
            addFuncionarios cadastroFuncionario = new addFuncionarios();
            cadastroFuncionario.ShowDialog();
        }

        private void consultarFuncionario_Click(object sender, EventArgs e)
        {
            consultarFuncionários consultarFuncionarios = new consultarFuncionários();
            consultarFuncionarios.ShowDialog();
        }

        private void adicionarAtualizarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroProdutos cadastroProdutos = new cadastroProdutos();
            cadastroProdutos.ShowDialog();
        }

        private void funcionarios_Click(object sender, EventArgs e)
        {

        }

        private void consultarProdutosMenu_Click(object sender, EventArgs e)
        {
            consultaEstoque consultaEstoque = new consultaEstoque();
            consultaEstoque.ShowDialog();
        }

        private void cadastrarCompra_Click(object sender, EventArgs e)
        {
            cadastroDeCompra cadastroDeCompra = new cadastroDeCompra();
            cadastroDeCompra.ShowDialog();
        }

        private void comprasRealizadas_Click(object sender, EventArgs e)
        {
            comprasRealizadas comprasRealizadas = new comprasRealizadas();
            comprasRealizadas.ShowDialog();
        }

        private void consultarClientes_Click(object sender, EventArgs e)
        {
           consultaCliente consultaCliente = new consultaCliente();
            consultaCliente.ShowDialog();
        }
    }
}

