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
    public partial class frm_modalidades3 : Form
    {
        public frm_modalidades3()
        {
            InitializeComponent();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            frm_modalidades frm_modalidades = new frm_modalidades();
            frm_modalidades.Show();
        }

        public void carregaComboboxModalidades()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarModalidades = new MySqlCommand("select * from modalidades " + "where Estado = 'Ativo'" + "order by nomeModalidade ", con);
                MySqlDataReader dr = carregarModalidades.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_modalidade.DisplayMember = "nomeModalidade";
                cbo_modalidade.ValueMember = "idModalidade";
                cbo_modalidade.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Modalidades!", "Lista Modalidades");
            }
        }

        private void frm_modalidades3_Load(object sender, EventArgs e)
        {
            carregaComboboxModalidades();
            ListarDetalheSocio();
        }

        public void ListarDetalheSocio()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarDetalheTreinadores = new MySqlCommand("SELECT modalidades.nomeModalidade FROM detalhesocio, modalidades WHERE detalhesocio.idModalidade = modalidades.idModalidade", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarDetalheTreinadores);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_detalhesocio.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_associar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand associarCliente = new MySqlCommand("INSERT INTO detalhesocio (idCliente, idModalidade) SELECT @idCliente, @idModalidade WHERE NOT EXISTS (SELECT * FROM detalhesocio WHERE idCliente = @idCliente AND idModalidade = @idModalidade)", con);

                associarCliente.Parameters.AddWithValue("@idCliente", user.id_user);
                associarCliente.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);

                int rowsAffected = associarCliente.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Você inscreveu-se na modalidade " + cbo_modalidade.Text + "!", "Inscrever-se em uma Modalidade");
                    ListarDetalheSocio();
                }
                else
                {
                    MessageBox.Show("Já se inscreveu nesta modalidade!", "Inscrever-se em uma Modalidade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_desassociar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                // Verificar se o sócio está inscrito em uma turma com a mesma modalidade
                string sqlVerificarTurma = "SELECT COUNT(*) FROM detalheturma dt JOIN turmas t ON dt.idTurma = t.idTurma WHERE dt.idCliente = @idCliente AND t.idModalidade = @idModalidade";
                MySqlCommand commandVerificarTurma = new MySqlCommand(sqlVerificarTurma, con);
                commandVerificarTurma.Parameters.AddWithValue("@idCliente", user.id_user);
                commandVerificarTurma.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                int numTurmas = Convert.ToInt32(commandVerificarTurma.ExecuteScalar());

                if (numTurmas > 0)
                {
                    MessageBox.Show("Você não pode se desassociar da modalidade " + cbo_modalidade.Text + " porque está inscrito em uma turma com essa modalidade.", "Desassociar da Modalidade");
                }
                else
                {
                    // Excluir a associação do sócio com a modalidade
                    MySqlCommand desassociarSocio = new MySqlCommand("DELETE FROM detalhesocio WHERE idCliente = @idCliente AND idModalidade = @idModalidade", con);

                    desassociarSocio.Parameters.AddWithValue("@idCliente", user.id_user);
                    desassociarSocio.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);

                    int rowsAffected = desassociarSocio.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Você desassociou-se da modalidade " + cbo_modalidade.Text + "!", "Desassociar da Modalidade");
                        ListarDetalheSocio();
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado nenhum registro com o cliente e modalidade selecionados!", "Desassociar da Modalidade");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
