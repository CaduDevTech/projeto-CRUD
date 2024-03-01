using MySql.Data.MySqlClient;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace projeto_CRUD
{
    public partial class cadastroProdutos : Form
    {
        public cadastroProdutos()
        {
            InitializeComponent();
            precoProduto.Leave += precoProduto_Leave;
            marcaProduto.Leave += marcaProduto_Leave;
            marcaProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            marcaProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            desativarButoes();
            listaMarcaProduto();
            carregarCategoriaProdutos();
        }

        MySqlConnection sqlcon = null;
        private string strcon = @"server=localhost;uid=root;pwd=Pubg123;database=kadivis";
        private string strSql = string.Empty;

        private void desativarButoes()
        {
            nomeProduto.Enabled = false;
            marcaProduto.Enabled = false;
            addMarcaProdutoBtn.Enabled = false;
            precoProduto.Enabled = false;
            categoriaProduto.Enabled = false;
            quantidadeProduto.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            idProduto.Enabled = false;
            buscar.Enabled = false;
            salvarAlteracoes.Enabled = false;
            categoriaProdutoBtn.Enabled = false;


        }

        private void addMarcaProdutoBtn_Click(object sender, EventArgs e)
        {
            addMarcaProduto.Visible = true;
            salvarAddMarcaProduto.Visible = true;
            MessageBox.Show("Escreva o nome da marca para atribuir ao produto");
        }

        private void salvarAddMarcaProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addMarcaProduto.Text) || double.TryParse(addMarcaProduto.Text, out _))
            {
                MessageBox.Show("A caixa está vazia ou contém somente números.");
                addMarcaProduto.Clear();
            }
            else
            {

                marcaProduto.Items.Add(addMarcaProduto.Text);
                MessageBox.Show("Marca adicionada à lista.");
                addMarcaProduto.Visible = false;
                salvarAddMarcaProduto.Visible = false;
                addMarcaProduto.Clear();
            }

        }

        private void precoProduto_Click(object sender, EventArgs e)
        {

        }

        private void precoProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(precoProduto.Text))
            {

                if (decimal.TryParse(precoProduto.Text, out decimal value))
                {

                    precoProduto.Text = value.ToString("C");

                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

            if (nomeProduto.Text == string.Empty || marcaProduto.Text == null || precoProduto.Text == null ||
                categoriaProduto.Text == string.Empty || quantidadeProduto.Text == string.Empty)
            {
                MessageBox.Show("ALGUM CAMPO ESTÁ COM INFORMAÇÕES FALTANDO", "CAMPOS IMCOMPLETOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                strSql = "INSERT INTO produtos (nomeProduto, marcaProduto, precoProduto, categoriaProduto, quantidadeProduto, dataChegadaProduto) " +
                    "VALUES (@nomeProduto, @marcaProduto, @precoProduto, @categoriaProduto, @quantidadeProduto,@dataChegadaProduto)";

                sqlcon = new MySqlConnection(strcon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@nomeProduto", MySqlDbType.VarChar).Value = nomeProduto.Text;
                comando.Parameters.Add("@marcaProduto", MySqlDbType.VarChar).Value = marcaProduto.Text;
                comando.Parameters.Add("@precoProduto", MySqlDbType.VarChar).Value = precoProduto.Text;
                comando.Parameters.Add("@categoriaProduto", MySqlDbType.VarChar).Value = categoriaProduto.Text;
                comando.Parameters.Add("@quantidadeProduto", MySqlDbType.VarChar).Value = quantidadeProduto.Text;
                comando.Parameters.Add("@dataChegadaProduto", MySqlDbType.Date).Value = dataCadastro;

                try
                {
                    sqlcon.Open();

                    comando.ExecuteNonQuery();


                    MessageBox.Show("CADASTRO EFETUADO COM SUCESO");


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO NO CADASTRO: " + ex.Message);
                }

                finally
                {
                    sqlcon.Close();

                    nomeProduto.Clear();
                    precoProduto.Clear();
                    desativarButoes();
                    addMarcaProduto.Clear();
                    addMarcaProduto.Visible = false;
                    salvarAddMarcaProduto.Visible = false;
                    btnAdicionar.Enabled = true;
                    marcaProduto.Text = null;
                    quantidadeProduto.Text = null;
                    categoriaProduto.Text = null;

                }

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            nomeProduto.Enabled = true;
            marcaProduto.Enabled = true;
            addMarcaProdutoBtn.Enabled = true;
            precoProduto.Enabled = true;
            categoriaProduto.Enabled = true;
            quantidadeProduto.Enabled = true;
            idProduto.Enabled = false;
            buscar.Enabled = false;
            salvarAlteracoes.Enabled = false;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = true;
            nomeProduto.Clear();
            precoProduto.Clear();
            idProduto.Clear();
            categoriaProduto.Text = null;
            quantidadeProduto.Text = null;
            marcaProduto.Text = null;
            categoriaProdutoBtn.Enabled = true;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            desativarButoes();
            idProduto.Enabled = true;
            salvarAlteracoes.Enabled = true;
            buscar.Enabled = true;
            addMarcaProduto.Visible = false;
            salvarAddMarcaProduto.Visible = false;
            nomeProduto.Clear();
            precoProduto.Clear();
            categoriaProduto.Text = string.Empty;
            quantidadeProduto.Text = string.Empty;
            marcaProduto.Text = null;
            MessageBox.Show("Digite o ID do Produto após faça as alterações necessarias", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        private void listaMarcaProduto()
        {
            strSql = "SELECT DISTINCT  marcaProduto FROM produtos;";

            using (MySqlConnection sqlcon = new MySqlConnection(strcon))
            {
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                try
                {
                    sqlcon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marcaProduto.Items.Add(reader["marcaProduto"].ToString());
                        }
                    }


                }
                catch (MySqlException Ex)
                {
                    MessageBox.Show("Erro: " + Ex.Message);
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void marcaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void marcaProduto_Leave(object sender, EventArgs e)
        {

            if (!marcaProduto.Items.Contains(marcaProduto.Text) && marcaProduto.Text != string.Empty)
            {
                MessageBox.Show("O item não está na lista do ComboBox. Por favor, selecione um item da lista.");
                marcaProduto.Text = string.Empty;
                return;
            }
        }

        private void precoProduto_Click(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void quantidadeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(idProduto.Text, out _))
            {
                MessageBox.Show("Voçê precisa digitar um ID Válido");
                idProduto.Clear();
            }
            else
            {


                sqlcon = new MySqlConnection(strcon);



                string sql = "SELECT * FROM produtos WHERE idProduto=@idProduto";



                MySqlCommand comando = new MySqlCommand(sql, sqlcon);




                comando.Parameters.Add("@idProduto", MySqlDbType.Int64).Value = Convert.ToDouble(idProduto.Text);




                try
                {
                    if (!double.TryParse(idProduto.Text, out _))
                    {
                        throw new Exception("Voçê precisa digitar um ID");

                    }

                    sqlcon.Open();
                    MySqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idProduto.Text = Convert.ToString(dr["idProduto"]);
                            nomeProduto.Text = Convert.ToString(dr["nomeProduto"]);
                            marcaProduto.Text = Convert.ToString(dr["marcaProduto"]);
                            precoProduto.Text = Convert.ToString(dr["precoProduto"]);
                            categoriaProduto.Text = Convert.ToString(dr["categoriaProduto"]);
                            quantidadeProduto.Text = Convert.ToString(dr["quantidadeProduto"]);


                            btnExcluir.Enabled = true;
                            idProduto.Enabled = true;
                            nomeProduto.Enabled = true;
                            marcaProduto.Enabled = true;
                            precoProduto.Enabled = true;
                            categoriaProduto.Enabled = true;
                            quantidadeProduto.Enabled = true;
                            addMarcaProdutoBtn.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID não cadastrado");

                        idProduto.Clear();
                        nomeProduto.Clear();
                        precoProduto.Clear();
                        categoriaProduto.Text = null;
                        quantidadeProduto.Text = null;
                        marcaProduto.Text = null;
                        idProduto.Enabled = true;
                        buscar.Enabled = true;
                        btnAdicionar.Enabled = true;
                    }



                }
                catch (MySqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    sqlcon.Close();


                }
            }
        }

        private void salvarAlteracoes_Click(object sender, EventArgs e)
        {
            string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

            if (!int.TryParse(idProduto.Text, out _))
            {
                MessageBox.Show("Você não pode salvar IDs invalidos ou inexistentes");

                nomeProduto.Clear();
                precoProduto.Clear();
                desativarButoes();
                btnAdicionar.Enabled = true;
                marcaProduto.Text = null;
                quantidadeProduto.Text = null;
                categoriaProduto.Text = null;
                idProduto.Enabled = true;
                buscar.Enabled = true;
                btnAdicionar.Enabled = true;
            }
            else
            {
                strSql = "UPDATE produtos SET nomeProduto = @nomeProduto, precoProduto = @precoProduto, quantidadeProduto=" +
                    " @quantidadeProduto, marcaProduto = @marcaProduto, categoriaProduto = @categoriaProduto, dataChegadaProduto = @dataChegadaProduto WHERE idProduto = @idProduto";


                sqlcon = new MySqlConnection(strcon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@idProduto", MySqlDbType.Int64).Value = idProduto.Text;
                comando.Parameters.Add("@nomeProduto", MySqlDbType.VarChar).Value = nomeProduto.Text;
                comando.Parameters.Add("@precoProduto", MySqlDbType.VarChar).Value = precoProduto.Text;
                comando.Parameters.Add("@quantidadeProduto", MySqlDbType.VarChar).Value = quantidadeProduto.Text;
                comando.Parameters.Add("@categoriaProduto", MySqlDbType.VarChar).Value = categoriaProduto.Text;
                comando.Parameters.Add("@marcaProduto", MySqlDbType.VarChar).Value = marcaProduto.Text;
                comando.Parameters.Add("@dataChegadaProduto", MySqlDbType.VarChar).Value = dataCadastro;

                try
                {
                    sqlcon.Open();

                    comando.ExecuteNonQuery();


                    MessageBox.Show("ATUALIZAÇÃO ADICIONADA AO ESTOQUE");


                }
                catch (MySqlException Ex)
                {
                    MessageBox.Show("ERRO AO ADICIONAR AO ESTOQUE: " + Ex.Message);
                }

                finally
                {
                    sqlcon.Close();

                    desativarButoes();
                    nomeProduto.Clear();
                    precoProduto.Clear();
                    desativarButoes();
                    btnAdicionar.Enabled = true;
                    marcaProduto.Text = null;
                    quantidadeProduto.Text = null;
                    categoriaProduto.Text = null;
                    idProduto.Text = null;

                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja retirar o'" + nomeProduto.Text + " '' com o ID '" + idProduto.Text + "'' do estoque?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada, Produto não foi retirado do estoque");

            }
            else
            {
                strSql = "DELETE FROM produtos WHERE idProduto=@idProduto";
                sqlcon = new MySqlConnection(strcon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@idProduto", MySqlDbType.Int64).Value = Convert.ToInt64(idProduto.Text);

                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto retirado do estoque com sucesso");


                    desativarButoes();
                    nomeProduto.Clear();
                    precoProduto.Clear();
                    desativarButoes();
                    btnAdicionar.Enabled = true;
                    marcaProduto.Text = null;
                    quantidadeProduto.Text = null;
                    categoriaProduto.Text = null;
                    idProduto.Text = null;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    sqlcon.Close();



                }


            }
        }

        private void precoProduto_TextChanged(object sender, EventArgs e)
        {




        }

        private void salvarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoriaProduto.Text) || double.TryParse(categoriaProduto.Text, out _))
            {
                MessageBox.Show("A caixa está vazia ou contém somente números.");
                addCategoriaProduto.Clear(); ;
            }
            else
            {
                categoriaProduto.Items.Add(addCategoriaProduto.Text);
                MessageBox.Show("Marca adicionada, selecione ela na caixa.");

                addCategoriaProduto.Visible = false;
                salvarCategoria.Visible = false;
            }
        }

        private void categoriaProdutoBtn_Click(object sender, EventArgs e)
        {
            addCategoriaProduto.Visible = true;
            salvarCategoria.Visible = true;
        }

        private void carregarCategoriaProdutos()
        {
            strSql = "SELECT DISTINCT  categoriaProduto FROM produtos;";

            using (MySqlConnection sqlcon = new MySqlConnection(strcon))
            {
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                try
                {
                    sqlcon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoriaProduto.Items.Add(reader["categoriaProduto"].ToString());
                        }
                    }


                }
                catch (MySqlException Ex)
                {
                    MessageBox.Show("Erro: " + Ex.Message);
                }
            }


        }
    }
}
