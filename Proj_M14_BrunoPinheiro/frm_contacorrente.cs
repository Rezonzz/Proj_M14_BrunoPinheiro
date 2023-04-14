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
    public partial class frm_contacorrente : Form
    {
        public frm_contacorrente()
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

        private void frm_contacorrente_Load(object sender, EventArgs e)
        {
            carregaComboboxSocios();
        }

        private void cbo_socios_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();
                int idSocio = Convert.ToInt32(cbo_socios.SelectedValue);
                MySqlCommand pesquisarModalidades = new MySqlCommand("SELECT q.idCliente, COUNT(q.idQuota) as 'Quotas Pagas', SUM(q.valorQuota) as 'Total Pago' FROM quota q WHERE q.idCliente=" + idSocio + " GROUP BY q.idCliente", con);
                MySqlDataAdapter tabela = new MySqlDataAdapter(pesquisarModalidades);
                DataTable dt = new DataTable();
                tabela.Fill(dt);
                dgv_consulta.DataSource = dt;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con.Close();
        }

        private void dgv_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
