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
    public partial class frm_areacliente : Form
    {
        public frm_areacliente()
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

        private void frm_areacliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void frm_areacliente_Load(object sender, EventArgs e)
        {
            lbl_nome.Text = user.nome_user;
            OpenChildForm(new frm_dadospessoais());
            pnl_selected1.Visible = true;
            pnl_selected1.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
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

        private void pic_close_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja fazer logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frm_menu frm_menu = new frm_menu();
                frm_menu.Show();
            }
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btn_dados_Click(object sender, EventArgs e)
        {
            lbl_nome.Text = user.nome_user;
            OpenChildForm(new frm_dadospessoais());
            pnl_selected1.Visible = true;
            pnl_selected1.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
        }

        private void btn_quotas_Click(object sender, EventArgs e)
        {
            lbl_nome.Text = user.nome_user;
            OpenChildForm(new frm_quotas2());
            pnl_selected2.Visible = true;
            pnl_selected2.Enabled = true;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
        }

        private void btn_modalidades_Click(object sender, EventArgs e)
        {
            lbl_nome.Text = user.nome_user;
            OpenChildForm(new frm_modalidades3());
            pnl_selected3.Visible = true;
            pnl_selected3.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja fazer logout?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frm_menu frm_menu = new frm_menu();
                frm_menu.Show();
            }
        }
    }
}
