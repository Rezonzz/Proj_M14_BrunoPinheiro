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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lbl_historia_Click(object sender, EventArgs e)
        {
            frm_historia frm_historia = new frm_historia();
            frm_historia.Show();
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void lbl_historia_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_historia.ForeColor = Color.FromArgb(36, 77, 159);
        }

        private void lbl_login_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_login.ForeColor = Color.FromArgb(36, 77, 159);
        }

        private void lbl_inscrevase_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_inscrevase.ForeColor = Color.FromArgb(36, 77, 159);
        }

        private void lbl_historia_MouseLeave(object sender, EventArgs e)
        {
            lbl_historia.ForeColor = Color.FromArgb(28, 59, 122);
        }

        private void lbl_login_MouseLeave(object sender, EventArgs e)
        {
            lbl_login.ForeColor = Color.FromArgb(28, 59, 122);
        }

        private void lbl_inscrevase_MouseLeave(object sender, EventArgs e)
        {
            lbl_inscrevase.ForeColor = Color.FromArgb(28, 59, 122);
        }

        private void lbl_modalidades_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_modalidades.ForeColor = Color.FromArgb(36, 77, 159);
        }

        private void lbl_modalidades_MouseLeave(object sender, EventArgs e)
        {
            lbl_modalidades.ForeColor = Color.FromArgb(28, 59, 122);
        }

        private void lbl_inscrevase_Click(object sender, EventArgs e)
        {
            frm_inscricao frm_inscricao = new frm_inscricao();
            frm_inscricao.Show();
            this.Hide();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            frm_login frm_login = new frm_login();
            frm_login.Show();
            this.Hide();
        }
    }
}
