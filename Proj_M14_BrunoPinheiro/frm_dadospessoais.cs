using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M14_BrunoPinheiro
{
    public partial class frm_dadospessoais : Form
    {
        public frm_dadospessoais()
        {
            InitializeComponent();
        }

        private void frm_dadospessoais_Load(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();

            try
            {
                con.Open();

                // Crie um comando SQL para buscar o registro do cliente selecionado
                MySqlCommand cmd = new MySqlCommand("SELECT nomeCliente, email, morada, telefone, NIF, estado FROM socios WHERE idCliente = @idCliente", con);
                cmd.Parameters.AddWithValue("@idCliente", user.id_user); // Substitua idCliente pelo valor do ID do cliente selecionado

                // Execute o comando SQL e leia os dados do registro do cliente
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Preencha os campos do formulário com os dados do registro do cliente
                    txt_nome.Text = dr.GetString("nomeCliente");
                    txt_email.Text = dr.GetString("email");
                    txt_morada.Text = dr.GetString("morada");
                    txt_telefone.Text = dr.GetString("telefone");
                    txt_nif.Text = dr.GetString("NIF");
                    cbo_estado.SelectedItem = dr.GetString("estado"); // Certifique-se de que o valor da coluna 'estado' corresponde a um item válido na lista suspensa
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do cliente: " + ex.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();

            try
            {
                con.Open();

                // Crie um comando SQL para atualizar os dados do cliente
                MySqlCommand cmd = new MySqlCommand("UPDATE socios SET nomeCliente = @nomeCliente, email = @email, morada = @morada, telefone = @telefone, NIF = @NIF, estado = @estado WHERE idCliente = @idCliente", con);
                cmd.Parameters.AddWithValue("@nomeCliente", txt_nome.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@morada", txt_morada.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                cmd.Parameters.AddWithValue("@NIF", txt_nif.Text);
                cmd.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString()); // Certifique-se de que o valor selecionado é um dos itens válidos na lista suspensa
                cmd.Parameters.AddWithValue("@idCliente", user.id_user); // Substitua idCliente pelo valor do ID do cliente selecionado

                // Execute o comando SQL e atualize os dados do cliente no banco de dados
                int numRowsAffected = cmd.ExecuteNonQuery();

                if (numRowsAffected > 0)
                {
                    user.nome_user = txt_nome.Text;
                    MessageBox.Show("Dados do cliente atualizados com sucesso.");
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar os dados do cliente.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do cliente: " + ex.Message);
            }
        }
    }
}
