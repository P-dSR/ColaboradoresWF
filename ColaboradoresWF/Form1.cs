using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ColaboradoresWF
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strsql;

        public Form1()
        {
            InitializeComponent();
        }

        private void novo_button_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_colab;Uid=root;Pwd=123456;");
                strsql="INSERT INTO COLAB (NOME,NUMERO) VALUES(@NOME,@NUMERO)";
                comando = new MySqlCommand(strsql, conexao) ;
                comando.Parameters.AddWithValue("@NOME", nome_TextBox.Text);
                comando.Parameters.AddWithValue("@NUMERO",numero_textBox.Text);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
            finally 
            {
                
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void editar_button_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_colab;Uid=root;Pwd=123456;");
                strsql = "UPDATE COLAB SET NOME = @NOME,  NUMERO = @NUMERO WHERE ID = @ID ";
                comando = new MySqlCommand(strsql, conexao);
                comando.Parameters.AddWithValue("@ID", ID_textBox.Text);
                comando.Parameters.AddWithValue("@NOME", nome_TextBox.Text);
                comando.Parameters.AddWithValue("@NUMERO", numero_textBox.Text);
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {

                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void consultar_button_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_colab;Uid=root;Pwd=123456;");
                strsql = "SELECT * FROM COLAB WHERE ID = @ID  ";
                comando = new MySqlCommand(strsql, conexao);
                comando.Parameters.AddWithValue("@ID", ID_textBox.Text);

                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    nome_TextBox.Text = Convert.ToString(dr["nome"]);
                    numero_textBox.Text = Convert.ToString(dr["numero"]);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {

                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void excluir_button_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_colab;Uid=root;Pwd=123456;");
                strsql = "DELETE FROM COLAB WHERE ID = @ID  ";
                comando = new MySqlCommand(strsql, conexao);
                comando.Parameters.AddWithValue("@ID", ID_textBox.Text);
                
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {

                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void exibir_button_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_colab;Uid=root;Pwd=123456;");
                strsql = "SELECT * FROM COLAB ";
                da = new MySqlDataAdapter(strsql, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dados_dataGridView.DataSource = dt;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {

                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
