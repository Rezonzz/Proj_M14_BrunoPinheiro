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
    }
}
