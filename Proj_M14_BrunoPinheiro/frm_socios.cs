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
    public partial class frm_socios : Form
    {
        public frm_socios()
        {
            InitializeComponent();
        }

        public void ListarSocios()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarSocios = new MySqlCommand("select idCliente, nomeCliente, email, morada, telefone, NIF, dataNascimento, estado, observacoes from socios", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarSocios);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_socios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarSocios();
        }

        private void frm_socios_Load(object sender, EventArgs e)
        {
            cbo_estado.SelectedIndex = 0;
        }

        private void dgv_socios_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.Focus();
            txt_idsocio.Text = dgv_socios.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dgv_socios.SelectedRows[0].Cells[1].Value.ToString();
            txt_email.Text = dgv_socios.SelectedRows[0].Cells[2].Value.ToString();
            txt_morada.Text = dgv_socios.SelectedRows[0].Cells[3].Value.ToString();
            txt_telefone.Text = dgv_socios.SelectedRows[0].Cells[4].Value.ToString();
            txt_nif.Text = dgv_socios.SelectedRows[0].Cells[5].Value.ToString();
            dtp_nasc.Value = Convert.ToDateTime(dgv_socios.SelectedRows[0].Cells[6].Value);
            if (dgv_socios.SelectedRows[0].Cells[7].Value.ToString() == "Ativo")
            {
                cbo_estado.SelectedIndex = 0;
            }
            else if (dgv_socios.SelectedRows[0].Cells[7].Value.ToString() == "Inativo")
            {
                cbo_estado.SelectedIndex = 1;
            }
            txt_obs.Text = dgv_socios.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idsocio.Text.Length > 0)
                {
                    con.Open();

                    MySqlCommand atualizarsocio = new MySqlCommand("update socios set nomeCliente=@nomeCliente, email=@email, morada = @morada, telefone = @telefone, NIF = @NIF, dataNascimento = @dataNascimento, estado = @estado, observacoes = @observacoes where idCliente = @idCliente", con);
        

                    atualizarsocio.Parameters.AddWithValue("@nomeCliente", txt_nome.Text);
                    atualizarsocio.Parameters.AddWithValue("@email", txt_email.Text);
                    atualizarsocio.Parameters.AddWithValue("@morada", txt_morada.Text);
                    atualizarsocio.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    atualizarsocio.Parameters.AddWithValue("@NIF", txt_nif.Text);
                    atualizarsocio.Parameters.AddWithValue("@dataNascimento", dtp_nasc.Value);
                    atualizarsocio.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                    atualizarsocio.Parameters.AddWithValue("@observacoes", txt_obs.Text);
                    atualizarsocio.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txt_idsocio.Text));

                    atualizarsocio.ExecuteNonQuery();
                    MessageBox.Show("Sócio atualizado!", "Atualizar Sócio");
                    ListarSocios();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar num Sócio!!!", "Atualizar Sócio");
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

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
            if (txt_email.Text != "" && txt_email.Text != "Email")
            {
                lbl_email.Visible = true;
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

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            txt_telefone.MaxLength = 9;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
                lbl_telefone.Visible = true;
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

        private void txt_obs_TextChanged(object sender, EventArgs e)
        {
            txt_obs.MaxLength = 100;
            if (txt_obs.Text != "" && txt_obs.Text != "Observações")
            {
                lbl_obs.Visible = true;
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

            if (txt_obs.Text == "")
            {
                txt_obs.Text = "Observações";
                lbl_obs.Visible = false;
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

            if (txt_obs.Text == "")
            {
                txt_obs.Text = "Observações";
                lbl_obs.Visible = false;
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

            if (txt_obs.Text == "")
            {
                txt_obs.Text = "Observações";
                lbl_obs.Visible = false;
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

            if (txt_obs.Text == "")
            {
                txt_obs.Text = "Observações";
                lbl_obs.Visible = false;
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

            if (txt_obs.Text == "")
            {
                txt_obs.Text = "Observações";
                lbl_obs.Visible = false;
            }
        }

        private void txt_obs_Click(object sender, EventArgs e)
        {
            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
            if (txt_obs.Text == "Observações")
            {
                txt_obs.ResetText();
                txt_obs.Focus();
                lbl_obs.Visible = true;
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

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_email.Text == "Email")
                {
                    txt_email.ResetText();
                    txt_email.Focus();
                    lbl_email.Visible = true;
                    if (txt_nome.Text == "")
                    {
                        txt_nome.Text = "Nome";
                        lbl_nome.Visible = false;
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
                if (txt_morada.Text == "Morada")
                {
                    txt_morada.ResetText();
                    txt_morada.Focus();
                    lbl_morada.Visible = true;
                    if (txt_email.Text == "")
                    {
                        txt_email.Text = "Email";
                        lbl_email.Visible = false;
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
                if (txt_telefone.Text == "Telefone")
                {
                    txt_telefone.ResetText();
                    txt_telefone.Focus();
                    lbl_telefone.Visible = true;
                    if (txt_morada.Text == "")
                    {
                        txt_morada.Text = "Morada";
                        lbl_morada.Visible = false;
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

        private void txt_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_nif.Text == "NIF")
                {
                    txt_nif.ResetText();
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                    if (txt_telefone.Text == "")
                    {
                        txt_telefone.Text = "Telefone";
                        lbl_telefone.Visible = false;
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
                dtp_nasc.Focus();
                if (txt_nif.Text == "")
                {
                    txt_nif.Text = "NIF";
                    lbl_nif.Visible = false;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void dtp_nasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbo_estado.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cbo_estado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_obs.Focus();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (txt_obs.Text == "Observações")
                {
                    txt_obs.ResetText();
                    txt_obs.Focus();
                    lbl_obs.Visible = true;
                }
                else
                {
                    txt_obs.Focus();
                    lbl_obs.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
