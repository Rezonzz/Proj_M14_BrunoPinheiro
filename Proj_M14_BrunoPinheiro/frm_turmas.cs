using MySql.Data.MySqlClient;
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
    public partial class frm_turmas : Form
    {
        public frm_turmas()
        {
            InitializeComponent();
        }

        private void frm_turmas_Load(object sender, EventArgs e)
        {

        }

        public void ListarTurmas()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarTurmas = new MySqlCommand("select * from turmas", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarTurmas);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_turmas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarTurmas();
        }
    }
}
