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
    public partial class frm_instalacoes : Form
    {
        public frm_instalacoes()
        {
            InitializeComponent();
        }

        public void ListarInstalacao()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarInstalacao = new MySqlCommand("SELECT instalacao.*, modalidades.nomeModalidade FROM instalacao JOIN modalidades ON instalacao.idModalidade = modalidades.idModalidade", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarInstalacao);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_instalacao.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void frm_instalacoes_Load(object sender, EventArgs e)
        {
            ListarInstalacao();
            carregaComboboxModalidades();
        }

        public void carregaComboboxModalidades()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarModalidades = new MySqlCommand("select * from modalidades " + "order by nomeModalidade", con);
                MySqlDataReader dr = carregarModalidades.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_modalidade.DisplayMember = "nomeModalidade";
                cbo_modalidade.ValueMember = "idModalidade";
                cbo_modalidade.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Modalidades!", "Lista Modalidades");
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_nome.MaxLength = 50;
            if (txt_nome.Text != "" && txt_nome.Text != "Nome")
            {
                lbl_nome.Visible = true;
            }
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Nome")
            {
                txt_nome.ResetText();
                txt_nome.Focus();
                lbl_nome.Visible = true;
            }
        }
    }
}
