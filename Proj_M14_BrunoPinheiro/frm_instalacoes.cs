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

                MySqlCommand listarInstalacao = new MySqlCommand("SELECT instalacao.idInstalacao, instalacao.nomeInstalacao, instalacao.idModalidade, modalidades.nomeModalidade, instalacao.Estado FROM instalacao JOIN modalidades ON instalacao.idModalidade = modalidades.idModalidade\r\n", con);
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
            cbo_estado.SelectedIndex = 0;
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

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_nome.Text.Length > 0)
                {
                    if (cbo_modalidade.SelectedValue != null)
                    {
                        if (cbo_estado.SelectedItem.ToString() == "Ativo" || cbo_estado.SelectedItem.ToString() == "Inativo")
                        {
                            con.Open();

                            MySqlCommand inserirInstalacao = new MySqlCommand("INSERT INTO instalacao(nomeInstalacao, idModalidade, Estado) VALUES (@nomeInstalacao,@idModalidade,@estado)", con);
                            inserirInstalacao.Parameters.AddWithValue("@nomeInstalacao", txt_nome.Text);
                            inserirInstalacao.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                            inserirInstalacao.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                            inserirInstalacao.ExecuteNonQuery();
                            MessageBox.Show("Instalação adicionada!!!", "Adicionar Instalação");
                            ListarInstalacao();
                        }
                        else
                        {
                            MessageBox.Show("Selecione um estado válido (Ativo ou Inativo)!", "Adicionar Instalação");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma modalidade!", "Adicionar Instalação");
                    }
                }
                else
                {
                    MessageBox.Show("Digite o nome da instalação!", "Adicionar Instalação");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idinstalacao.Text.Length > 0)
                {
                    con.Open();

                    MySqlCommand atualizarinstalacao = new MySqlCommand("update instalacao set nomeInstalacao='" +
                        txt_nome.Text + "', idModalidade='" + cbo_modalidade.SelectedValue + "' , Estado='" + cbo_estado.SelectedItem.ToString() + "' where idInstalacao=" + Convert.ToInt32(txt_idinstalacao.Text), con);
                    atualizarinstalacao.Parameters.AddWithValue("@nomeInstalacao", txt_nome.Text);
                    atualizarinstalacao.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                    atualizarinstalacao.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                    atualizarinstalacao.ExecuteNonQuery();
                    MessageBox.Show("Instalação atualizada!", "Atualizar Instalação");
                    ListarInstalacao();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar numa Instalação!!!", "Atualizar Instalação");
                    txt_nome.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Erro: Não Estabeleceu Ligação!!!", "Ligar Base Dados MySQL");
            }
        }

        private void dgv_instalacao_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.Focus();
            txt_idinstalacao.Text = dgv_instalacao.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dgv_instalacao.SelectedRows[0].Cells[1].Value.ToString();
            cbo_modalidade.SelectedValue = dgv_instalacao.SelectedRows[0].Cells[2].Value.ToString();
            if (dgv_instalacao.SelectedRows[0].Cells[4].Value.ToString() == "Ativo")
            {
                cbo_estado.SelectedIndex = 0;
            }
            else if (dgv_instalacao.SelectedRows[0].Cells[4].Value.ToString() == "Inativo")
            {
                cbo_estado.SelectedIndex = 1;
            }
        }
    }
}
