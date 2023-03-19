using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_nome.MaxLength = 50;
            if (txt_nome.Text != "" && txt_nome.Text != "Nome")
            {
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
            txt_telefone.MaxLength = 15;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
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
    }
}
