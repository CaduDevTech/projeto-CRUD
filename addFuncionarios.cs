using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using Mysqlx.Prepare;
using System.Diagnostics.Eventing.Reader;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using Correios.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;




namespace projeto_CRUD
{
    public partial class addFuncionarios : Form
    {

        //<sumário>
        //Esta classe representa um formulário para adicionar, editar, excluir e visualizar funcionários em um banco de dados MySQL.
        //</sumário>
        public addFuncionarios()
        {
            InitializeComponent();

            desativarButoes();
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;



        }

        //<sumário>
        // Strings de conexão com o banco de dados que está no codigo
        //</sumário>

        MySqlConnection sqlcon = null;
        private string strcon = @"server=localhost;uid=root;pwd=Pubg123;database=kadivis";
        private string strSql = string.Empty;


        //<sumário>
        // Um atalho para desativar todos os butões do layout
        //</sumário>
        private void desativarButoes()
        {
            btnAdicionar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            nome.Enabled = false;
            numeroCelular.Enabled = false;
            numeroTelefone.Enabled = false;
            cargo.Enabled = false;
            email.Enabled = false;
            buscar.Enabled = false;
            salvarAlteracoes.Enabled = false;
            idFuncionario.Enabled = false;
            CEP.Enabled = false;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();


        }

        //<sumário>
        // Ativa a maioria dos butoões do layout e limpa o que há nos butoes
        //</sumário>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            nome.Enabled = true;
            numeroCelular.Enabled = true;
            numeroTelefone.Enabled = true;
            cargo.Enabled = true;
            email.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = true;
            buscar.Visible = false;
            salvarAlteracoes.Visible = false;
            idFuncionario.Visible = false;
            CEP.Enabled = true;
            btnAdicionar.Enabled = false;
            validador.Visible = false;
            CEP.Clear();
            numeroCasa.Clear();
            nome.Clear();
            numeroCelular.Clear();
            numeroTelefone.Clear();
            cargo.Clear();
            email.Clear();
            idFuncionario.Clear();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (nome.Text == string.Empty || numeroCelular.Text == null || numeroTelefone.Text == null ||
                email.Text == string.Empty || numeroCasa.Text == string.Empty || cargo.Text == string.Empty)
            {
                MessageBox.Show("ALGUM CAMPO ESTÁ COM INFORMAÇÕES FALTANDO", "CAMPOS IMCOMPLETOS OU INVÁLIDOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                strSql = "INSERT INTO funcionarios (Nome, Celular, Telefone, Email, Cargo, numeroCasa, CEP) VALUES (@nome, @numeroCelular, @numeroTelefone, @email, @cargo, @numeroCasa, @cepFuncionario)";

                sqlcon = new MySqlConnection(strcon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome.Text;
                comando.Parameters.Add("@numeroCelular", MySqlDbType.VarChar).Value = numeroCelular.Text;
                comando.Parameters.Add("@numeroTelefone", MySqlDbType.VarChar).Value = numeroTelefone.Text;
                comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
                comando.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = cargo.Text;
                comando.Parameters.Add("@numeroCasa", MySqlDbType.VarChar).Value = numeroCasa.Text;
                comando.Parameters.Add("@cepFuncionario", MySqlDbType.VarChar).Value = Convert.ToString(CEP.Text);



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

                    nome.Clear();
                    numeroCelular.Clear();
                    numeroTelefone.Clear();
                    cargo.Clear();
                    CEP.Clear();
                    email.Clear();
                    desativarButoes();
                    validador.Visible= false;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnAdicionar.Enabled = true;

                }

            }
        }

        //<sumário>

        //</sumário>
        private void btnEditar_Click(object sender, EventArgs e)
        {

            desativarButoes();
            idFuncionario.Enabled = true;
            btnAdicionar.Enabled = true;
            buscar.Enabled = true;
            validador.Visible = false;
            buscar.Visible = true;
            salvarAlteracoes.Visible = true;
            idFuncionario.Visible = true;
            nome.Clear();
            numeroCelular.Clear();
            numeroTelefone.Clear();
            cargo.Clear();
            CEP.Clear();
            email.Clear();

            MessageBox.Show("Digite o ID do funcionario após faça as alterações necessarias", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        //<sumário>

        //</sumário>
        private void buscar_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(idFuncionario.Text, out _))
            {
                MessageBox.Show("Voçê precisa digitar um ID Válido");
                idFuncionario.Clear();
            }
            else
            {




                sqlcon = new MySqlConnection(strcon);



                string sql = "SELECT * FROM funcionarios WHERE ID=@idFuncionario";



                MySqlCommand comando = new MySqlCommand(sql, sqlcon);




                comando.Parameters.Add("@idFuncionario", MySqlDbType.Int64).Value = Convert.ToDouble(idFuncionario.Text);




                try
                {
                    if (!double.TryParse(idFuncionario.Text, out _))
                    {
                        throw new Exception("Voçê precisa digitar um ID");

                    }

                    sqlcon.Open();
                    MySqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idFuncionario.Text = Convert.ToString(dr["ID"]);
                            nome.Text = Convert.ToString(dr["Nome"]);
                            email.Text = Convert.ToString(dr["Email"]);
                            cargo.Text = Convert.ToString(dr["Cargo"]);
                            numeroCelular.Text = Convert.ToString(dr["Celular"]);
                            numeroTelefone.Text = Convert.ToString(dr["Telefone"]);
                            CEP.Text = Convert.ToString(dr["CEP"]);
                            numeroCasa.Text = Convert.ToString(dr["numeroCasa"]);


                            btnExcluir.Enabled = true;
                            nome.Enabled = true;
                            numeroCelular.Enabled = true;
                            numeroTelefone.Enabled = true;
                            cargo.Enabled = true;
                            CEP.Enabled = true;
                            numeroCasa.Enabled = true;
                            email.Enabled = true;
                            salvarAlteracoes.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID não cadastrado");

                        idFuncionario.Clear();
                        nome.Clear();
                        numeroCelular.Clear();
                        numeroTelefone.Clear();
                        cargo.Clear();
                        CEP.Clear();
                        email.Clear();
                        desativarButoes();
                        idFuncionario.Enabled = true;
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

        //<sumário>

        //</sumário>
        private void salvarAlteracoes_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(idFuncionario.Text) || string.IsNullOrEmpty(nome.Text) || string.IsNullOrEmpty(numeroCelular.Text) || string.IsNullOrEmpty(numeroTelefone.Text) ||
                string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(numeroCasa.Text) || string.IsNullOrEmpty(CEP.Text) || string.IsNullOrEmpty(cargo.Text))
            {
                MessageBox.Show("Você não pode salvar IDs invalidos ou inexistentes");
                idFuncionario.Clear();
                numeroTelefone.Clear();
                nome.Clear();
                numeroCelular.Clear();
                cargo.Clear();
                email.Clear();
                CEP.Clear();
                desativarButoes();
                idFuncionario.Enabled = true;
                buscar.Enabled = true;
                btnAdicionar.Enabled = true;
            }
            else
            {
                strSql = "UPDATE funcionarios SET Nome = @nome, Celular = @numeroCelular, Telefone = @numeroTelefone, Email = @email, CEP = @CEP, numeroCasa = @numeroCasa, Cargo = @cargo WHERE ID = @idFuncionario";


                sqlcon = new MySqlConnection(strcon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@idFuncionario", MySqlDbType.Int64).Value = idFuncionario.Text;

                comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome.Text;
                comando.Parameters.Add("@numeroCelular", MySqlDbType.VarChar).Value = numeroCelular.Text;
                comando.Parameters.Add("@numeroTelefone", MySqlDbType.VarChar).Value = numeroTelefone.Text;
                comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
                comando.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = cargo.Text;
                comando.Parameters.Add("@CEP", MySqlDbType.VarChar).Value = CEP.Text;
                comando.Parameters.Add("@numeroCasa", MySqlDbType.VarChar).Value = numeroCasa.Text;

                try
                {
                    sqlcon.Open();

                    comando.ExecuteNonQuery();


                    MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO");


                }
                catch (MySqlException Ex)
                {
                    MessageBox.Show("ERRO NO CADASTRO: " + Ex.Message);
                }

                finally
                {
                    sqlcon.Close();

                    desativarButoes();
                    nome.Clear();
                    numeroCelular.Clear();
                    numeroTelefone.Clear();
                    cargo.Clear();
                    CEP.Clear();
                    email.Clear();
                    idFuncionario.Clear();
                    btnAdicionar.Enabled = true;

                }
            }
        }

        //<sumário>

        //</sumário>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer excluir o usuario '" + nome.Text + "' com o ID '" + idFuncionario.Text + "'?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada, usuario não foi apagado");

            }
            else
            {
                strSql = "DELETE FROM funcionarios WHERE ID=@idFuncionario";
                sqlcon = new MySqlConnection(strcon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@idFuncionario", MySqlDbType.Int64).Value = Convert.ToInt64(idFuncionario.Text);

                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionario deletado com sucesso");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    sqlcon.Close();

                    desativarButoes();
                    nome.Clear();
                    numeroCelular.Clear();
                    numeroTelefone.Clear();
                    cargo.Clear();
                    CEP.Clear();
                    email.Clear();
                    idFuncionario.Clear();
                    btnAdicionar.Enabled = true;
                }
            }


        }

        private void idFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void validador_Click(object sender, EventArgs e)
        {

        }

        private async void CEP_TextChanged(object sender, EventArgs e)
        {
            string cep = CEP.Text;
            string caminhoImagemCerto = @"C:\Users\SUeduardo\Documents\Projeto CRUD\Fotos Projeto CRUD\certo1.png";
            string caminhoImagemErrado = @"C:\Users\SUeduardo\Documents\Projeto CRUD\Fotos Projeto CRUD\errado1.png";

            validador.Image = Image.FromFile(caminhoImagemErrado);
            validador.BackgroundImageLayout = ImageLayout.Stretch;

            // Verifica conexão de rede
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("Sem conexão de rede. Verifique sua conexão e tente novamente.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cep.Length == 9)
            {
                try
                {
                    // Verifica conexão de rede
                    if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {
                        MessageBox.Show("Sem conexão de rede. Verifique sua conexão e tente novamente.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Exibe feedback visual
                    validador.Visible = false;

                    // Consulta de endereço em uma thread separada
                    var addresses = await Task.Run(() =>
                    {
                        try
                        {
                            // Instancia o serviço dos Correios
                            CorreiosService correiosService = new CorreiosService();

                            // Realiza a consulta de endereço
                            return correiosService.GetAddresses(cep);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Ocorreu um erro ao consultar o CEP: " + ex.Message);
                        }
                    });

                    // Atualiza a interface com os resultados da consulta
                    foreach (var address in addresses)
                    {
                        if (address != null)
                        {
                            rua.Text = address.Street;
                            bairro.Text = address.District;
                            cidade.Text = address.City;
                            validador.Image = Image.FromFile(caminhoImagemCerto);
                            validador.BackgroundImageLayout = ImageLayout.Stretch;
                            numeroCasa.Enabled = true;
                            numeroCasaTxt.Enabled = true;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar o CEP: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Restaura o estado do botão após a consulta
                    validador.Visible = true;
                }
            }
            else
            {
                rua.Text = null;
                cidade.Text = null;
                bairro.Text = null;
                numeroCasa.Text = null;
                numeroCasa.Enabled = false;
                numeroCasaTxt.Enabled = false;
                validador.BackgroundImageLayout = ImageLayout.Stretch;
                validador.Image = Image.FromFile(caminhoImagemErrado);

                return;
            }
        }

        private void rua_TextChanged(object sender, EventArgs e)
        {
            // codigo para quebrar a linha deacordo com o tamnaho do texto
            TextBox rua = (TextBox)sender;
            rua.Height = TextRenderer.MeasureText(rua.Text, rua.Font, rua.ClientSize, TextFormatFlags.WordBreak).Height;

        }

        private void bairro_TextChanged(object sender, EventArgs e)
        {
            // codigo para quebrar a linha deacordo com o tamnaho do texto
            TextBox bairro = (TextBox)sender;
            bairro.Height = TextRenderer.MeasureText(bairro.Text, bairro.Font, bairro.ClientSize, TextFormatFlags.WordBreak).Height;
        }

        private void cidade_TextChanged(object sender, EventArgs e)
        {
            // codigo para quebrar a linha deacordo com o tamnaho do texto
            TextBox cidade = (TextBox)sender;
            cidade.Height = TextRenderer.MeasureText(cidade.Text, cidade.Font, cidade.ClientSize, TextFormatFlags.WordBreak).Height;
        }
    }
}

