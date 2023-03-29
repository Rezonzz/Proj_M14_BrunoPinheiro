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
    public partial class frm_socios : Form
    {
        public frm_socios()
        {
            InitializeComponent();
        }

        public void ListarSocios()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarSocios = new MySqlCommand("select idCliente, nomeCliente, email, morada, telefone, NIF, dataNascimento, estado, observacoes from socios", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarSocios);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_socios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarSocios();
        }
    }
}
