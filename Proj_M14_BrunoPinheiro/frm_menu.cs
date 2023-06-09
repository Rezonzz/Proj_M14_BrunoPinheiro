﻿using System;
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
            if (Application.OpenForms["frm_historia"] as frm_historia == null)
            {
                new frm_historia().Show();
            }
            else
            {
                MessageBox.Show("Já existe um aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            tmr_data.Tick += new EventHandler(tmr_data_Tick);
            tmr_data.Start();
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
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Sair da Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void lbl_modalidades_Click(object sender, EventArgs e)
        {            
            if (Application.OpenForms["frm_modalidades"] as frm_modalidades == null)
            {
                new frm_modalidades().Show();
            }
            else
            {
                MessageBox.Show("Já existe um aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tmr_data_Tick(object sender, EventArgs e)
        {
            lbl_horas.Text = DateTime.Now.ToString("HH:mm:ss");
            AtualizarLabel();
        }
    }
}
