using MySql.Data.MySqlClient;
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
    public partial class frm_modalidades : Form
    {
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
        public frm_modalidades()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
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

        private void pic_futebol_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_futebol());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void frm_modalidades_Load(object sender, EventArgs e)
        {
            var modalidades = new[] { "Futebol", "Voleibol", "Basquetebol", "Tênis", "Badminton" };

            using (var con = conn.GetConnection())
            {
                con.Open();

                foreach (var modalidade in modalidades)
                {
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM modalidades WHERE nomeModalidade = @nomeModalidade", con))
                    {
                        cmd.Parameters.AddWithValue("@nomeModalidade", modalidade);

                        var resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            var count = Convert.ToInt32(resultado);

                            if (count > 0)
                            {
                                switch (modalidade)
                                {
                                    case "Futebol":
                                        pnl_futebol.Visible = true;
                                        pnl_futebol.Enabled = true;
                                        break;
                                    case "Voleibol":
                                        pnl_volei.Visible = true;
                                        pnl_volei.Enabled = true;
                                        break;
                                    case "Basquetebol":
                                        pnl_basquetebol.Visible = true;
                                        pnl_basquetebol.Enabled = true;
                                        break;
                                    case "Tênis":
                                        pnl_tenis.Visible = true;
                                        pnl_tenis.Enabled = true;
                                        break;
                                    case "Badminton":
                                        pnl_badminton.Visible = true;
                                        pnl_badminton.Enabled = true;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void pic_basket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_basquetebol());
        }
    }
}
