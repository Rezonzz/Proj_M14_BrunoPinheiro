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

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_nome.MaxLength = 50;
            if (txt_nome.Text != "" && txt_nome.Text != "Nome")
            {
                lbl_nome.Visible = true;
            }
        }

        private void txt_morada_TextChanged(object sender, EventArgs e)
        {
            txt_morada.MaxLength = 100;
            if (txt_morada.Text != "" && txt_morada.Text != "Morada")
            {
                lbl_morada.Visible = true;
            }
        }

        private void txt_nif_TextChanged(object sender, EventArgs e)
        {
            txt_nif.MaxLength = 9;
            if (txt_nif.Text != "" && txt_nif.Text != "NIF")
            {
                lbl_nif.Visible = true;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
            if (txt_email.Text != "" && txt_email.Text != "Email")
            {
                lbl_email.Visible = true;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            txt_telefone.MaxLength = 9;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
                lbl_telefone.Visible = true;
            }
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Nome")
            {
                txt_nome.ResetText();
                txt_nome.Focus();
                lbl_nome.Visible = true;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_morada_Click(object sender, EventArgs e)
        {
            if (txt_morada.Text == "Morada")
            {
                txt_morada.ResetText();
                txt_morada.Focus();
                lbl_morada.Visible = true;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_nif_Click(object sender, EventArgs e)
        {
            if (txt_nif.Text == "NIF")
            {
                txt_nif.ResetText();
                txt_nif.Focus();
                lbl_nif.Visible = true;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.ResetText();
                txt_email.Focus();
                lbl_email.Visible = true;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            if (txt_telefone.Text == "Telefone")
            {
                txt_telefone.ResetText();
                txt_telefone.Focus();
                lbl_telefone.Visible = true;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_morada.Text == "Morada")
                {
                    txt_morada.ResetText();
                    txt_morada.Focus();
                    lbl_morada.Visible = true;
                    if (txt_nome.Text == "")
                    {
                        txt_nome.Text = "Nome";
                        lbl_nome.Visible = false;
                    }
                }
                else
                {
                    txt_morada.Focus();
                    lbl_morada.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_morada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_nif.Text == "NIF")
                {
                    txt_nif.ResetText();
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                    if (txt_morada.Text == "")
                    {
                        txt_morada.Text = "Morada";
                        lbl_morada.Visible = false;
                    }
                }
                else
                {
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_nif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_email.Text == "Email")
                {
                    txt_email.ResetText();
                    txt_email.Focus();
                    lbl_email.Visible = true;
                    if (txt_nif.Text == "")
                    {
                        txt_nif.Text = "NIF";
                        lbl_nif.Visible = false;
                    }
                }
                else
                {
                    txt_email.Focus();
                    lbl_email.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_telefone.Text == "Telefone")
                {
                    txt_telefone.ResetText();
                    txt_telefone.Focus();
                    lbl_telefone.Visible = true;
                    if (txt_email.Text == "")
                    {
                        txt_email.Text = "Email";
                        lbl_email.Visible = false;
                    }
                }
                else
                {
                    txt_telefone.Focus();
                    lbl_telefone.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
