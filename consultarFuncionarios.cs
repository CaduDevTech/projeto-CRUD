using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projeto_CRUD
{
    public partial class consultarFuncionários : Form
    {
        private MySqlConnection sqlcon;
        private string bancoDados = @"server=localhost;uid=root;pwd=Pubg123;database=kadivis";

        public consultarFuncionários()
        {
            InitializeComponent();
            LoadFuncionarios();
            gridFuncionarios.View = View.Details;
            gridFuncionarios.LabelEdit = true;
            gridFuncionarios.AllowColumnReorder = true;
            gridFuncionarios.FullRowSelect = true;
            gridFuncionarios.GridLines = true;
            gridFuncionarios.Columns.Add("ID", 30, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("Celular", 120, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("Telefone", 120, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("E-Mail", 170, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("N° Endereço", 100, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("CEP", 150, HorizontalAlignment.Left);
            gridFuncionarios.Columns.Add("Cargo", 90, HorizontalAlignment.Left);

            buscar.Enabled = false;


        }

        private void executarConsulta(string consulta)
        {
            try
            {
                sqlcon = new MySqlConnection(bancoDados);

                MySqlCommand comando = new MySqlCommand(consulta, sqlcon);

                sqlcon.Open();

                MySqlDataReader leitor = comando.ExecuteReader();

                gridFuncionarios.Items.Clear();

                while (leitor.Read())
                {
                    string[] row = {
               leitor.GetInt16(0).ToString(),
                leitor.GetString(1),
                leitor.GetString(2),
                leitor.GetString(3),
                leitor.GetString(4),
                leitor.GetString(5),
                leitor.GetString(6),
                leitor.GetString(7)
            };

                    var linhaListView = new ListViewItem(row);
                    gridFuncionarios.Items.Add(linhaListView);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void atualizarTxtBuscar()
        {
            string q = "'%" + txtBuscar.Text + "%'";
            string sql = "SELECT * FROM funcionarios WHERE Nome LIKE " + q + " OR Email LIKE " + q;
            executarConsulta(sql);
        }

        private void LoadFuncionarios()
        {
            string sql = "SELECT * FROM funcionarios";
            executarConsulta(sql);
        }


        private void buscar_Click(object sender, EventArgs e)
        {
            atualizarTxtBuscar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(buscar.Text))
            {
                buscar.Enabled = false;

            }
            else
            {
                buscar.Enabled = true;

            }

            atualizarTxtBuscar();


        }


        private void mostrarTudoConsulta_Click(object sender, EventArgs e)
        {
            LoadFuncionarios();
        }

        private void voltarConsulta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
