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
    public partial class frm_administracao : Form
    {
        public frm_administracao()
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

        private void frm_administracao_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_fundo.Controls.Add(childForm);
            pnl_fundo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_socios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_socios());
        }

        private void btn_treinadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_treinadores());
        }

        private void btn_modalidades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_modalidades2());
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_abertofechado_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarLabel()
        {
            DateTime horaAtual = DateTime.Now;

            if (horaAtual.Hour >= 16 && horaAtual.Hour < 22)
            {
                lbl_abertofechado.Text = "Aberto";
                lbl_abertofechado.ForeColor = Color.Green;
            }
            else
            {
                lbl_abertofechado.Text = "Fechado";
                lbl_abertofechado.ForeColor = Color.Red;
            }
        }

        private void tmr_data_Tick(object sender, EventArgs e)
        {
            lbl_horas.Text = DateTime.Now.ToString("HH:mm:ss");
            AtualizarLabel();
        }

        private void pnl_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
