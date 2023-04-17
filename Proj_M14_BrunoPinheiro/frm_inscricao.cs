using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M14_BrunoPinheiro
{
    public partial class frm_inscricao : Form
    {
        public frm_inscricao()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pic_close_Click(object sender, EventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
            this.Close();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_mostrar_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = true;
            }
            pic_ocultado.Enabled = true;
            pic_ocultado.Visible = true;
            pic_mostrar.Enabled = false;
            pic_mostrar.Visible = false;
        }

        private void lbl_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_morada.Clear();
            txt_password.Clear();
            txt_telefone.Clear();
            txt_nif.Clear();
            txt_nome.ResetText();
            txt_email.ResetText();
            txt_morada.ResetText();
            txt_password.ResetText();
            txt_telefone.ResetText();
            txt_nif.ResetText();
            txt_nome.Focus();
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = true;
            txt_email.Text = "Email";
            txt_morada.Text = "Morada";
            txt_telefone.Text = "Telefone";
            txt_nif.Text = "NIF";
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
            lbl_limpar.Visible = false;
            lbl_limpar.Enabled = false;
            lbl_nome.Visible = true;
            lbl_email.Visible = false;
            lbl_morada.Visible = false;
            lbl_telefone.Visible = false;
            lbl_nif.Visible = false;
            lbl_password.Visible = false;
        }

        private void pic_ocultado_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                txt_password.UseSystemPasswordChar = false;
            }
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
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

            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = true;
                lbl_password.Visible = false;
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

            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = true;
                lbl_password.Visible = false;
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

            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = true;
                lbl_password.Visible = false;
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

            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = true;
                lbl_password.Visible = false;
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

            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = true;
                lbl_password.Visible = false;
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.UseSystemPasswordChar = false;
                txt_password.ResetText();
                txt_password.Focus();
                lbl_password.Visible = true;
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

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
            if (txt_email.Text != "" && txt_email.Text != "Email")
            {
                if (txt_email.Text.Any(char.IsWhiteSpace))
                {
                    txt_email.Text = new string(txt_email.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_email.SelectionStart = txt_email.Text.Length;
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_email.Visible = true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.MaxLength = 50;
            if (txt_password.Text != "" && txt_password.Text != "Password")
            {
                if (txt_password.Text.Any(char.IsWhiteSpace))
                {
                    txt_password.Text = new string(txt_password.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_password.SelectionStart = txt_password.Text.Length;
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_password.Visible = true;
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_nome.MaxLength = 50;
            if (txt_nome.Text != "" && txt_nome.Text != "Nome")
            {
                if (txt_nome.Text.Any(char.IsDigit))
                {
                    txt_nome.Text = new string(txt_nome.Text.Where(c => !char.IsDigit(c)).ToArray());

                    txt_nome.SelectionStart = txt_nome.Text.Length;
                }
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_nome.Visible = true;
            }
        }

        private void txt_morada_TextChanged(object sender, EventArgs e)
        {
            txt_morada.MaxLength = 100;
            if (txt_morada.Text != "" && txt_morada.Text != "Morada")
            {
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_morada.Visible = true;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            txt_telefone.MaxLength = 9;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
                if (txt_telefone.Text.Any(char.IsLetter))
                {
                    txt_telefone.Text = new string(txt_telefone.Text.Where(c => !char.IsLetter(c)).ToArray());
                }
                if (txt_telefone.Text.Any(char.IsWhiteSpace))
                {
                    txt_telefone.Text = new string(txt_telefone.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_telefone.SelectionStart = txt_telefone.Text.Length;

                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_telefone.Visible = true;
            }
        }

        private void txt_nif_TextChanged(object sender, EventArgs e)
        {
            txt_nif.MaxLength = 9;
            if (txt_nif.Text != "" && txt_nif.Text != "NIF")
            {
                if (txt_nif.Text.Any(char.IsLetter))
                {
                    txt_nif.Text = new string(txt_nif.Text.Where(c => !char.IsLetter(c)).ToArray());
                }
                if (txt_nif.Text.Any(char.IsWhiteSpace))
                {
                    txt_nif.Text = new string(txt_nif.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_nif.SelectionStart = txt_nif.Text.Length;
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_nif.Visible = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_password.Text == "")
                {
                    lbl_password.Visible = false;
                }
                btn_inscrevase.PerformClick();
                e.SuppressKeyPress = true;
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
                if (txt_password.Text == "Password")
                {
                    txt_password.ResetText();
                    txt_password.Focus();
                    lbl_password.Visible = true;
                }
                else
                {
                    txt_password.Focus();
                    lbl_password.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        public static string GerarHashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Converte a senha para um array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                // Converte o array de bytes para uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btn_inscrevase_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_nome.Text != "" && txt_nome.Text != "Nome")
                {
                    if (txt_email.Text != "" && txt_email.Text != "Email")
                    {
                        if (txt_morada.Text != "" && txt_morada.Text != "Morada")
                        {
                            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
                            {
                                if (txt_nif.Text != "" && txt_nif.Text != "NIF")
                                {
                                    if (dtp_nasc.Value.Date < DateTime.Today)
                                    {
                                        if (txt_password.Text != "")
                                        {
                                            con.Open();
                                            string senhaHash = GerarHashSenha(txt_password.Text);
                                            MySqlCommand login = new MySqlCommand("INSERT INTO login(email, password) VALUES (@email, @password); SELECT LAST_INSERT_ID();", con);
                                            login.Parameters.AddWithValue("@email", txt_email.Text);
                                            login.Parameters.AddWithValue("@password", senhaHash);

                                            int idLogin = Convert.ToInt32(login.ExecuteScalar());

                                            MySqlCommand inscrever = new MySqlCommand("INSERT INTO socios(nomeCliente,email,morada,telefone, NIF, idLogin ,dataNascimento, password) VALUES (@nomeCliente,@email,@morada,@telefone, @nif, @idLogin,@dataNascimento, @password); SELECT LAST_INSERT_ID();", con);
                                            inscrever.Parameters.AddWithValue("@nomeCliente", txt_nome.Text);
                                            inscrever.Parameters.AddWithValue("@email", txt_email.Text);
                                            inscrever.Parameters.AddWithValue("@morada", txt_morada.Text);
                                            inscrever.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                                            inscrever.Parameters.AddWithValue("@nif", txt_nif.Text);
                                            inscrever.Parameters.AddWithValue("@idLogin", idLogin);
                                            inscrever.Parameters.AddWithValue("@dataNascimento", dtp_nasc.Value);
                                            inscrever.Parameters.AddWithValue("@password", senhaHash);
                                            inscrever.ExecuteNonQuery();

                                            user.id_user = inscrever.ExecuteScalar().ToString();
                                            user.nome_user = txt_nome.Text;
                                            MessageBox.Show("Inscrição feita com Sucesso!", "Inscrição");
                                            frm_areacliente frm_areacliente = new frm_areacliente();
                                            frm_areacliente.Show();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Preenchimento da password é obrigatória", "Erro");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Preencha uma data de nascimento válida", "Erro");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Preenchimento do NIF é obrigatório", "Erro");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Preenchimento do telefone é obrigatório", "Erro");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preenchimento da morada é obrigatória", "Erro");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preenchimento do email é obrigatório", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Preenchimento do nome é obrigatório", "Erro");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void frm_inscricao_Load(object sender, EventArgs e)
        {

        }
    }
}
