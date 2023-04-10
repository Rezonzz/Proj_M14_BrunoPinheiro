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

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_nome.Text != "")
                {
                    if (cbo_estado.Text != "")
                    {
                        con.Open();

                        MySqlCommand inserirModalidades = new MySqlCommand("INSERT INTO modalidades(nomeModalidade, Estado) VALUES (@nomeModalidade,@estado)", con);
                        inserirModalidades.Parameters.AddWithValue("@nomeModalidade", txt_nome.Text);
                        if (cbo_estado.SelectedItem.ToString() == "Ativo" || cbo_estado.SelectedItem.ToString() == "Inativo")
                        {
                            inserirModalidades.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Selecione um estado válido (Ativo ou Inativo)!", "Adicionar Modalidades");
                            return;
                        }
                        inserirModalidades.ExecuteNonQuery();
                        MessageBox.Show("Modalidade Adicionada!!!", "Adicionar Modalidades");
                        ListarModalidades();
                    }
                    else
                    {
                        MessageBox.Show("Selecione o estado!", "Adicionar Modalidades");
                    }
                }
                else
                {
                    MessageBox.Show("Digite o nome da modalidade!", "Adicionar Modalidades");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void frm_modalidades2_Load(object sender, EventArgs e)
        {
            cbo_estado.SelectedIndex = 0;
            ListarModalidades();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_nome.MaxLength = 50;
            if (txt_nome.Text != "" && txt_nome.Text != "Nome")
            {
                lbl_nome.Visible = true;
            }
        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbo_estado.Focus();
                if (txt_nome.Text == "")
                {
                    txt_nome.Text = "Nome";
                    lbl_nome.Visible = false;
                }
                e.SuppressKeyPress = true;
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

        private void dgv_modalidades_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.Focus();
            txt_idmodalidade.Text = dgv_modalidades.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dgv_modalidades.SelectedRows[0].Cells[1].Value.ToString();
            if(dgv_modalidades.SelectedRows[0].Cells[2].Value.ToString() == "Ativo")
            {
                cbo_estado.SelectedIndex = 0;
            } 
            else if (dgv_modalidades.SelectedRows[0].Cells[2].Value.ToString() == "Inativo")
            {
                cbo_estado.SelectedIndex = 1;
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idmodalidade.Text != "")
                {
                    con.Open();

                    MySqlCommand atualizarmodalidade = new MySqlCommand("update modalidades set nomeModalidade='" +
                        txt_nome.Text + "' ,Estado='" + cbo_estado.SelectedItem.ToString() + "' where idModalidade=" + Convert.ToInt32(txt_idmodalidade.Text), con);
                    atualizarmodalidade.Parameters.AddWithValue("@nomeModalidade", txt_nome.Text);
                    atualizarmodalidade.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                    atualizarmodalidade.ExecuteNonQuery();
                    MessageBox.Show("Modalidade atualizada!", "Atualizar Modalidade");
                    ListarModalidades();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar numa Modalidade!!!", "Atualizar Modalidade");
                    txt_nome.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Erro: Não Estabeleceu Ligação!!!", "Ligar Base Dados MySQL");
            }
        }
    }
}
