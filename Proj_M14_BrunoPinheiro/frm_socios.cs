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

                MySqlCommand listarSocios = new MySqlCommand("select idCliente, nomeCliente, email, morada, telefone, NIF, dataNascimento, estado from socios", con);
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

        private void frm_socios_Load(object sender, EventArgs e)
        {
            cbo_estado.SelectedIndex = 0;
            ListarSocios();
        }

        private void dgv_socios_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.Focus();
            txt_idsocio.Text = dgv_socios.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dgv_socios.SelectedRows[0].Cells[1].Value.ToString();
            if (dgv_socios.SelectedRows[0].Cells[7].Value.ToString() == "Ativo")
            {
                cbo_estado.SelectedIndex = 0;
            }
            else if (dgv_socios.SelectedRows[0].Cells[7].Value.ToString() == "Inativo")
            {
                cbo_estado.SelectedIndex = 1;
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idsocio.Text != "")
                {
                    con.Open();

                    MySqlCommand atualizarsocio = new MySqlCommand("update socios set estado = @estado where idCliente = @idCliente", con);
        
                    atualizarsocio.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                    atualizarsocio.Parameters.AddWithValue("@idCliente", Convert.ToInt32(txt_idsocio.Text));

                    atualizarsocio.ExecuteNonQuery();
                    MessageBox.Show("Sócio atualizado!", "Atualizar Sócio");
                    ListarSocios();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar num Sócio!!!", "Atualizar Sócio");
                    txt_nome.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Erro: Não Estabeleceu Ligação!!!", "Ligar Base Dados MySQL");
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_nome.MaxLength = 50;
            if (txt_nome.Text != "" && txt_nome.Text != "Nome")
            {
                lbl_nome.Visible = true;
            }
            else
            {
                lbl_nome.Visible = false;
            }
        }
    }
}
