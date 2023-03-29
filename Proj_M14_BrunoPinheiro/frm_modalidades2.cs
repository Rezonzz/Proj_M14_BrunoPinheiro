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
    public partial class frm_modalidades2 : Form
    {
        public frm_modalidades2()
        {
            InitializeComponent();
        }

        public void ListarModalidades()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarSocios = new MySqlCommand("select * from modalidades", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarSocios);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_modalidades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarModalidades();
        }
    }
}
