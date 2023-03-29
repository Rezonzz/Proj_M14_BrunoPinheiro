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
    public partial class frm_treinadores : Form
    {
        public frm_treinadores()
        {
            InitializeComponent();
        }

        public void ListarTreinadores()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarTreinadores = new MySqlCommand("select * from treinadores", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarTreinadores);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_treinadores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarTreinadores();
        }
    }
}
