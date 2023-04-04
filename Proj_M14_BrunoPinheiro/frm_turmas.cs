using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_M14_BrunoPinheiro
{
    public partial class frm_turmas : Form
    {
        public frm_turmas()
        {
            InitializeComponent();
        }

        private void frm_turmas_Load(object sender, EventArgs e)
        {
            carregaComboboxTreinador();
            carregaComboboxModalidades();
            cbo_diasemana.SelectedIndex = 0;
            ListarTurmas();
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

        public void carregaComboboxTreinador()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarTreinadores = new MySqlCommand("select * from treinadores " + "order by nomeTreinador", con);
                MySqlDataReader dr = carregarTreinadores.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_treinadores.DisplayMember = "nomeTreinador";
                cbo_treinadores.ValueMember = "idTreinador";
                cbo_treinadores.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Treinadores!", "Lista Treinadores");
            }
        }

        public void ListarTurmas()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarTurmas = new MySqlCommand("SELECT turmas.idTurma, turmas.idModalidade, modalidades.nomeModalidade, turmas.idTreinador, treinadores.nomeTreinador, turmas.diaSemana, turmas.hora, turmas.totalAlunos FROM turmas, treinadores, modalidades WHERE turmas.idTreinador = treinadores.idTreinador AND turmas.idModalidade = modalidades.idModalidade;", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarTurmas);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_turmas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dgv_turmas_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_modalidade.Focus();
            txt_idturma.Text = dgv_turmas.SelectedRows[0].Cells[0].Value.ToString();
            cbo_modalidade.SelectedValue = dgv_turmas.SelectedRows[0].Cells[1].Value.ToString();
            cbo_treinadores.SelectedValue = dgv_turmas.SelectedRows[0].Cells[3].Value.ToString();
            cbo_diasemana.SelectedItem = dgv_turmas.SelectedRows[0].Cells[5].Value.ToString();
            string dataString = dgv_turmas.SelectedRows[0].Cells[6].Value.ToString();
            DateTime data;
            if (DateTime.TryParse(dataString, out data))
            {
                dtp_hora.Value = data;
            }
            else
            {
                MessageBox.Show("Data inválida");
            }


        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idturma.Text != "")
                {
                    string idTurma = txt_idturma.Text;
                    DialogResult result = MessageBox.Show("Tem a certeza que quer apagar a turma " + idTurma + "?", "Apagar Turma", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        con.Open();

                        MySqlCommand apagarturma = new MySqlCommand("delete from turmas where idTurma=@idTurma", con);

                        apagarturma.Parameters.AddWithValue("@idTurma", Convert.ToInt32(txt_idturma.Text));

                        apagarturma.ExecuteNonQuery();
                        MessageBox.Show("Turma apagada!", "Apagar Turma");
                        ListarTurmas();

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Deve clicar numa Turma!!!", "Apagar Turma");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idturma.Text.Length > 0)
                {
                    con.Open();

                    MySqlCommand atualizarturma = new MySqlCommand("update turmas set idModalidade=@idModalidade, idTreinador=@idTreinador, diaSemana=@diaSemana, hora=@hora where idTurma=@idTurma", con);

                    atualizarturma.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                    atualizarturma.Parameters.AddWithValue("@idTreinador", cbo_treinadores.SelectedValue);
                    atualizarturma.Parameters.AddWithValue("@diaSemana", cbo_diasemana.SelectedItem.ToString());
                    atualizarturma.Parameters.AddWithValue("@hora", dtp_hora.Value.TimeOfDay);
                    atualizarturma.Parameters.AddWithValue("@idTurma", Convert.ToInt32(txt_idturma.Text));

                    atualizarturma.ExecuteNonQuery();
                    MessageBox.Show("Turma atualizada!", "Atualizar Turma");
                    ListarTurmas();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar numa Turma!!!", "Atualizar Turma");
                    cbo_modalidade.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (cbo_modalidade.SelectedIndex >= 0 && cbo_treinadores.SelectedIndex >= 0 && cbo_diasemana.SelectedIndex >= 0)
                {
                    con.Open();

                    MySqlCommand inserirTurma = new MySqlCommand("insert into turmas (idModalidade, idTreinador, diaSemana, hora) values (@idModalidade, @idTreinador, @diaSemana, @hora)", con);
                    inserirTurma.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                    inserirTurma.Parameters.AddWithValue("@idTreinador", cbo_treinadores.SelectedValue);
                    inserirTurma.Parameters.AddWithValue("@diaSemana", cbo_diasemana.SelectedItem.ToString());
                    inserirTurma.Parameters.AddWithValue("@hora", dtp_hora.Value);

                    inserirTurma.ExecuteNonQuery();
                    MessageBox.Show("Turma inserida!", "Inserir Turma");
                    ListarTurmas();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Inserir Turma");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
