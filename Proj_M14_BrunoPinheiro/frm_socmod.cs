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
    public partial class frm_socmod : Form
    {
        public frm_socmod()
        {
            InitializeComponent();
        }

        public void carregaComboboxSocios()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarSocios = new MySqlCommand("select * from socios " + "where estado='Ativo' " + "order by nomeCliente", con);
                MySqlDataReader dr = carregarSocios.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_socios.DisplayMember = "nomeCliente";
                cbo_socios.ValueMember = "idCliente";
                cbo_socios.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Sócios!", "Lista Sócios");
            }
        }

        private void frm_socmod_Load(object sender, EventArgs e)
        {
            carregaComboboxSocios();
        }

        public void ListarDetalheSocio(int idCliente)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarDetalheSocio = new MySqlCommand("SELECT socios.idCliente, socios.nomeCliente, detalhesocio.idModalidade, modalidades.nomeModalidade FROM socios, detalhesocio, modalidades WHERE socios.idCliente = detalhesocio.idCliente AND detalhesocio.idModalidade = modalidades.idModalidade AND socios.idCliente = @idCliente", con);
                listarDetalheSocio.Parameters.AddWithValue("@idCliente", idCliente);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarDetalheSocio);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_socmod.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cbo_socios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(cbo_socios.SelectedValue);
            ListarDetalheSocio(idCliente);
        }
    }
}
