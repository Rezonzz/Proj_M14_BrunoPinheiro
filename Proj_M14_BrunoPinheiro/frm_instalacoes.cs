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

                MySqlCommand listarInstalacao = new MySqlCommand("SELECT instalacao.idInstalacao, instalacao.nomeInstalacao, instalacao.Estado FROM instalacao", con);
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

        public void ListarDetalheInstalacao()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarDetalheInstalacao = new MySqlCommand("SELECT detalheinstalacao.idInstalacao, instalacao.nomeInstalacao, detalheinstalacao.idModalidade, modalidades.nomeModalidade FROM detalheinstalacao, instalacao, modalidades WHERE detalheinstalacao.idInstalacao = instalacao.idInstalacao AND detalheinstalacao.idModalidade = modalidades.idModalidade AND instalacao.Estado = 'Ativo'", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarDetalheInstalacao);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_detalheinstalacao.DataSource = dt;
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
            ListarDetalheInstalacao();
            carregaComboboxInstalacao();
            carregaComboboxModalidades();
        }

        public void carregaComboboxModalidades()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarModalidades = new MySqlCommand("select * from modalidades " + "where Estado = 'Ativo'" + "order by nomeModalidade", con);
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

        public void carregaComboboxInstalacao()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarInstalacao = new MySqlCommand("select * from instalacao " + "where Estado = 'Ativo'" + "order by nomeInstalacao", con);
                MySqlDataReader dr = carregarInstalacao.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_instalacao.DisplayMember = "nomeInstalacao";
                cbo_instalacao.ValueMember = "idInstalacao";
                cbo_instalacao.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Instalações!", "Lista Instalações");
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
                if (txt_nome.Text != "")
                {
                    if (cbo_estado.SelectedItem.ToString() == "Ativo" || cbo_estado.SelectedItem.ToString() == "Inativo")
                    {
                        con.Open();

                        MySqlCommand inserirInstalacao = new MySqlCommand("INSERT INTO instalacao(nomeInstalacao, Estado) VALUES (@nomeInstalacao,@estado)", con);
                        inserirInstalacao.Parameters.AddWithValue("@nomeInstalacao", txt_nome.Text);
                        inserirInstalacao.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                        inserirInstalacao.ExecuteNonQuery();
                        MessageBox.Show("Instalação adicionada!!!", "Adicionar Instalação");
                        ListarInstalacao();
                        ListarDetalheInstalacao();
                        carregaComboboxInstalacao();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um estado válido (Ativo ou Inativo)!", "Adicionar Instalação");
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
                        txt_nome.Text + "'" + ", Estado='" + cbo_estado.SelectedItem.ToString() + "' where idInstalacao=" + Convert.ToInt32(txt_idinstalacao.Text), con);
                    atualizarinstalacao.Parameters.AddWithValue("@nomeInstalacao", txt_nome.Text);
                    atualizarinstalacao.Parameters.AddWithValue("@estado", cbo_estado.SelectedItem.ToString());
                    atualizarinstalacao.ExecuteNonQuery();
                    MessageBox.Show("Instalação atualizada!", "Atualizar Instalação");
                    ListarInstalacao();
                    ListarDetalheInstalacao();
                    carregaComboboxInstalacao();

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
            if (dgv_instalacao.SelectedRows[0].Cells[2].Value.ToString() == "Ativo")
            {
                cbo_estado.SelectedIndex = 0;
            }
            else if (dgv_instalacao.SelectedRows[0].Cells[2].Value.ToString() == "Inativo")
            {
                cbo_estado.SelectedIndex = 1;
            }
        }

        private void btn_associar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand associarInstalacao = new MySqlCommand("INSERT INTO detalheinstalacao (idInstalacao, idModalidade) SELECT @idInstalacao, @idModalidade WHERE NOT EXISTS (SELECT * FROM detalheinstalacao WHERE idInstalacao = @idInstalacao AND idModalidade = @idModalidade)", con);

                associarInstalacao.Parameters.AddWithValue("@idInstalacao", cbo_instalacao.SelectedValue);
                associarInstalacao.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);

                int rowsAffected = associarInstalacao.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("A Instalação " + cbo_instalacao.Text + " foi associada com a modalidade " + cbo_modalidade.Text + "!", "Associar Instalação/Modalidade");
                    ListarDetalheInstalacao();
                }
                else
                {
                    MessageBox.Show("Já existe um registro com a mesma instalacao e modalidade!", "Associar Instalação/Modalidade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_desassociar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand desassociarInstalacao = new MySqlCommand("DELETE FROM detalheinstalacao WHERE idInstalacao = @idInstalacao AND idModalidade = @idModalidade", con);

                desassociarInstalacao.Parameters.AddWithValue("@idInstalacao", cbo_instalacao.SelectedValue);
                desassociarInstalacao.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);

                int rowsAffected = desassociarInstalacao.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("A Instalação " + cbo_instalacao.Text + " foi desassociada da modalidade " + cbo_modalidade.Text + "!", "Desassociar Instalação/Modalidade");
                    ListarDetalheInstalacao();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum registro com a instalação e modalidade selecionadas!", "Desassociar Instalação/Modalidade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dgv_detalheinstalacao_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_instalacao.SelectedValue = dgv_detalheinstalacao.SelectedRows[0].Cells[0].Value.ToString();
            cbo_modalidade.SelectedValue = dgv_detalheinstalacao.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
