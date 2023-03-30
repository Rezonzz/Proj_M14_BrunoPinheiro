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
    public partial class frm_treinadores : Form
    {
        public frm_treinadores()
        {
            InitializeComponent();
        }

        public void ListarTreinadores()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarTreinadores = new MySqlCommand("select * from treinadores", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarTreinadores);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_treinadores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarTreinadores();
        }

        private void frm_treinadores_Load(object sender, EventArgs e)
        {

        }

        private void dgv_treinadores_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.Focus();
            txt_idtreinador.Text = dgv_treinadores.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dgv_treinadores.SelectedRows[0].Cells[1].Value.ToString();
            txt_morada.Text = dgv_treinadores.SelectedRows[0].Cells[2].Value.ToString();
            txt_nif.Text = dgv_treinadores.SelectedRows[0].Cells[3].Value.ToString();
            txt_email.Text = dgv_treinadores.SelectedRows[0].Cells[4].Value.ToString();
            txt_telefone.Text = dgv_treinadores.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idtreinador.Text.Length > 0)
                {
                    con.Open();

                    MySqlCommand atualizartreinador = new MySqlCommand("update treinadores set nomeTreinador=@nomeTreinador, morada = @morada, NIF = @NIF, email=@email, telefone = @telefone where idTreinador = @idTreinador", con);

                    atualizartreinador.Parameters.AddWithValue("@nomeTreinador", txt_nome.Text);
                    atualizartreinador.Parameters.AddWithValue("@morada", txt_morada.Text);
                    atualizartreinador.Parameters.AddWithValue("@NIF", txt_nif.Text);
                    atualizartreinador.Parameters.AddWithValue("@email", txt_email.Text);
                    atualizartreinador.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    atualizartreinador.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txt_idtreinador.Text));

                    atualizartreinador.ExecuteNonQuery();
                    MessageBox.Show("Treinador atualizado!", "Atualizar Treinador");
                    ListarTreinadores();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar num Treinador!!!", "Atualizar Treinador");
                    txt_nome.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Erro: Não Estabeleceu Ligação!!!", "Ligar Base Dados MySQL");
            }
        }
    }
}
