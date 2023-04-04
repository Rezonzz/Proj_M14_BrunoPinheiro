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
            pnl_selected1.Visible = true;
            pnl_selected1.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
            pnl_selected4.Visible = false;
            pnl_selected4.Enabled = false;
            pnl_selected5.Visible = false;
            pnl_selected5.Enabled = false;
            pnl_selected6.Visible = false;
            pnl_selected6.Enabled = false;
            pnl_selected7.Visible = false;
            pnl_selected7.Enabled = false;
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
            var modalidades = new[] { "Futebol", "Voleibol", "Basquetebol", "Tênis", "Badminton", "Natação", "Ginástica" };

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
                                using (var cmdEstado = new MySqlCommand("SELECT Estado FROM modalidades WHERE nomeModalidade = @nomeModalidade", con))
                                {
                                    cmdEstado.Parameters.AddWithValue("@nomeModalidade", modalidade);
                                    var estado = cmdEstado.ExecuteScalar();

                                    if (estado != null)
                                    {
                                        switch (modalidade)
                                        {
                                            case "Futebol":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_futebol.Visible = true;
                                                    pnl_futebol.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_futebol.Visible = false;
                                                    pnl_futebol.Enabled = false;
                                                }
                                                break;
                                            case "Voleibol":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_volei.Visible = true;
                                                    pnl_volei.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_volei.Visible = false;
                                                    pnl_volei.Enabled = false;
                                                }
                                                break;
                                            case "Basquetebol":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_basquetebol.Visible = true;
                                                    pnl_basquetebol.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_basquetebol.Visible = false;
                                                    pnl_basquetebol.Enabled = false;
                                                }
                                                break;
                                            case "Tênis":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_tenis.Visible = true;
                                                    pnl_tenis.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_tenis.Visible = false;
                                                    pnl_tenis.Enabled = false;
                                                }
                                                break;
                                            case "Badminton":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_badminton.Visible = true;
                                                    pnl_badminton.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_badminton.Visible = false;
                                                    pnl_badminton.Enabled = false;
                                                }
                                                break;
                                            case "Natação":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_natacao.Visible = true;
                                                    pnl_natacao.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_natacao.Visible = false;
                                                    pnl_natacao.Enabled = false;
                                                }
                                                break;
                                            case "Ginástica":
                                                if (estado.ToString() == "Ativo")
                                                {
                                                    pnl_ginastica.Visible = true;
                                                    pnl_ginastica.Enabled = true;
                                                }
                                                else
                                                {
                                                    pnl_ginastica.Visible = false;
                                                    pnl_ginastica.Enabled = false;
                                                }
                                                break;
                                        }
                                    }
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
            pnl_selected2.Visible = true;
            pnl_selected2.Enabled = true;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
            pnl_selected4.Visible = false;
            pnl_selected4.Enabled = false;
            pnl_selected5.Visible = false;
            pnl_selected5.Enabled = false;
            pnl_selected6.Visible = false;
            pnl_selected6.Enabled = false;
            pnl_selected7.Visible = false;
            pnl_selected7.Enabled = false;
        }

        private void pic_volei_Click(object sender, EventArgs e)
        { 
            OpenChildForm(new frm_voleibol());
            pnl_selected3.Visible = true;
            pnl_selected3.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
            pnl_selected4.Visible = false;
            pnl_selected4.Enabled = false;
            pnl_selected5.Visible = false;
            pnl_selected5.Enabled = false;
            pnl_selected6.Visible = false;
            pnl_selected6.Enabled = false;
            pnl_selected7.Visible = false;
            pnl_selected7.Enabled = false;
        }

        private void pic_badminton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_badminton());
            pnl_selected4.Visible = true;
            pnl_selected4.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
            pnl_selected5.Visible = false;
            pnl_selected5.Enabled = false;
            pnl_selected6.Visible = false;
            pnl_selected6.Enabled = false;
            pnl_selected7.Visible = false;
            pnl_selected7.Enabled = false;
        }

        private void pic_tenis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_tenis());
            pnl_selected5.Visible = true;
            pnl_selected5.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
            pnl_selected4.Visible = false;
            pnl_selected4.Enabled = false;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
            pnl_selected6.Visible = false;
            pnl_selected6.Enabled = false;
            pnl_selected7.Visible = false;
            pnl_selected7.Enabled = false;
        }

        private void pic_natacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_natacao());
            pnl_selected6.Visible = true;
            pnl_selected6.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
            pnl_selected4.Visible = false;
            pnl_selected4.Enabled = false;
            pnl_selected5.Visible = false;
            pnl_selected5.Enabled = false;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
            pnl_selected7.Visible = false;
            pnl_selected7.Enabled = false;
        }

        private void pic_ginastica_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ginastica());
            pnl_selected7.Visible = true;
            pnl_selected7.Enabled = true;
            pnl_selected2.Visible = false;
            pnl_selected2.Enabled = false;
            pnl_selected3.Visible = false;
            pnl_selected3.Enabled = false;
            pnl_selected4.Visible = false;
            pnl_selected4.Enabled = false;
            pnl_selected5.Visible = false;
            pnl_selected5.Enabled = false;
            pnl_selected6.Visible = false;
            pnl_selected6.Enabled = false;
            pnl_selected1.Visible = false;
            pnl_selected1.Enabled = false;
        }

        private void pic_futebol_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_futebol.BackColor = Color.FromArgb(2, 6, 60);
            pic_futebol.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_basket_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_basquetebol.BackColor = Color.FromArgb(2, 6, 60);
            pic_basket.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_volei_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_volei.BackColor = Color.FromArgb(2, 6, 60);
            pic_volei.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_badminton_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_badminton.BackColor = Color.FromArgb(2, 6, 60);
            pic_badminton.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_tenis_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_tenis.BackColor = Color.FromArgb(2, 6, 60);
            pic_tenis.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_natacao_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_natacao.BackColor = Color.FromArgb(2, 6, 60);
            pic_natacao.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_ginastica_MouseMove(object sender, MouseEventArgs e)
        {
            pnl_ginastica.BackColor = Color.FromArgb(2, 6, 60);
            pic_ginastica.BackColor = Color.FromArgb(2, 6, 60);
        }

        private void pic_futebol_MouseLeave(object sender, EventArgs e)
        {
            pnl_futebol.BackColor = Color.FromArgb(1, 3, 29);
            pic_futebol.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pic_basket_MouseLeave(object sender, EventArgs e)
        {
            pnl_basquetebol.BackColor = Color.FromArgb(1, 3, 29);
            pic_basket.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pic_volei_MouseLeave(object sender, EventArgs e)
        {
            pnl_volei.BackColor = Color.FromArgb(1, 3, 29);
            pic_volei.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pic_badminton_MouseLeave(object sender, EventArgs e)
        {
            pnl_badminton.BackColor = Color.FromArgb(1, 3, 29);
            pic_badminton.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pic_tenis_MouseLeave(object sender, EventArgs e)
        {
            pnl_tenis.BackColor = Color.FromArgb(1, 3, 29);
            pic_tenis.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pic_natacao_MouseLeave(object sender, EventArgs e)
        {
            pnl_natacao.BackColor = Color.FromArgb(1, 3, 29);
            pic_natacao.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pic_ginastica_MouseLeave(object sender, EventArgs e)
        {
            pnl_ginastica.BackColor = Color.FromArgb(1, 3, 29);
            pic_ginastica.BackColor = Color.FromArgb(1, 3, 29);
        }

        private void pnl_futebol_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
