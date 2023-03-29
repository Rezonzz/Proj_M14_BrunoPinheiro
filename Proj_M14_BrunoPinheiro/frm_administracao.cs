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
    public partial class frm_administracao : Form
    {
        public frm_administracao()
        {
            InitializeComponent();
        }

        private void frm_administracao_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
