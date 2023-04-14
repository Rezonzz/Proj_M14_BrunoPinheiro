using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proj_M14_BrunoPinheiro
{
    public partial class frm_login : Form
    {
        public frm_login()
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

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            txt_email.Clear();
            txt_password.Clear();
            txt_email.ResetText();
            txt_password.ResetText();
            txt_email.Focus();
            txt_password.Text = "Password";
            txt_password.UseSystemPasswordChar = true;
            pic_ocultado.Enabled = false;
            pic_ocultado.Visible = false;
            pic_mostrar.Enabled = true;
            pic_mostrar.Visible = true;
            lbl_limpar.Visible = false;
            lbl_limpar.Enabled = false;
            lbl_email.Visible = true;
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

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.ResetText();
                txt_email.Focus();
                lbl_email.Visible = true;
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
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
            if (txt_email.Text != "" && txt_email.Text != "Email")
            {
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
                lbl_limpar.Visible = true;
                lbl_limpar.Enabled = true;
                lbl_password.Visible = true;
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_password.Text == "Password")
                {
                    txt_password.UseSystemPasswordChar = false;
                    txt_password.ResetText();
                    txt_password.Focus();
                    lbl_password.Visible = true;
                    if (txt_email.Text == "")
                    {
                        txt_email.Text = "Email";
                        lbl_email.Visible = false;
                    }
                }
                else
                {
                    txt_password.UseSystemPasswordChar = false;
                    txt_password.Focus();
                    lbl_password.Visible = true;
                }
                e.SuppressKeyPress = true;
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
                btn_login.PerformClick();
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            if(txt_email.Text != "" && txt_email.Text != "Email")
            {
                if(txt_password.Text != "" && txt_password.Text != "Password")
                {
                    con.Open();
                    string senhaHash = GerarHashSenha(txt_password.Text);
                    MySqlCommand login = new MySqlCommand("SELECT idLogin FROM login WHERE email = @email AND password = @senha; SELECT LAST_INSERT_ID();", con);
                    login.Parameters.AddWithValue("@email", txt_email.Text);
                    login.Parameters.AddWithValue("@senha", senhaHash);

                    object resultado = login.ExecuteScalar();
                    int idLogin = resultado != null ? Convert.ToInt32(resultado) : -1;

                    if (idLogin > 0)
                    {
                        MySqlCommand buscarTipoLogin = new MySqlCommand("SELECT tl.TipoLogin FROM tipologin tl JOIN login l ON tl.idTipoLogin = l.idTipoLogin WHERE l.idLogin = @idLogin", con);
                        buscarTipoLogin.Parameters.AddWithValue("@idLogin", idLogin);

                        string tipoLogin = buscarTipoLogin.ExecuteScalar().ToString();

                        if (tipoLogin == "Cliente")
                        {
                            MySqlCommand buscarCliente = new MySqlCommand("SELECT nomeCliente FROM socios WHERE email = @email",
        con);
                            buscarCliente.Parameters.AddWithValue("@email", txt_email.Text);
                            string nomeCliente = buscarCliente.ExecuteScalar() as string;

                            if (nomeCliente != null)
                            {
                                user.id_user = login.ExecuteScalar().ToString();
                                user.nome_user = nomeCliente;
                                MessageBox.Show("Login feito com Sucesso!", "Login");
                                frm_areacliente frm_areacliente = new frm_areacliente();
                                frm_areacliente.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Cliente não encontrado!", "Login");
                            }
                        }
                        else if (tipoLogin == "Administrador")
                        {
                            MessageBox.Show("Login feito com Sucesso!", "Login");
                            frm_administracao frm_administracao = new frm_administracao();
                            frm_administracao.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro desconhecido!", "Inscrição");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email ou Password errados!", "Login");
                    }
                }
            }
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void lbl_registrar_Click(object sender, EventArgs e)
        {
            frm_inscricao frm_inscricao = new frm_inscricao();
            frm_inscricao.Show();
            this.Close();
        }
    }
}
