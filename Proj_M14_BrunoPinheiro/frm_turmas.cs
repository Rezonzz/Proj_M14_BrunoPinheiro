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
            dtp_hora.MinDate = DateTime.Today.AddHours(16);
            dtp_hora.MaxDate = DateTime.Today.AddHours(22);
            carregaComboboxTreinador();
            carregaComboboxModalidades();
            carregaComboboxSocios();
            carregaComboboxTurmas();
            cbo_diasemana.SelectedIndex = 0;
            ListarTurmas();
            ListarDetalheTurmas();
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

        public void carregaComboboxTurmas()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarTurmas = new MySqlCommand("select * from turmas " + "order by idTurma", con);
                MySqlDataReader dr = carregarTurmas.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_turma.DisplayMember = "idTurma";
                cbo_turma.ValueMember = "idTurma";
                cbo_turma.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Turmas!", "Lista Turmas");
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

        public void ListarDetalheTurmas()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarDetalheTurmas = new MySqlCommand("SELECT turmas.idTurma, detalheturma.idCliente, socios.nomeCliente FROM turmas, detalheturma, socios WHERE turmas.idTurma = detalheturma.idTurma AND detalheturma.idCliente = socios.idCliente AND socios.Estado = 'Ativo'", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarDetalheTurmas);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_detalheturmas.DataSource = dt;
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
                        carregaComboboxTurmas();
                        ListarTurmas();
                        ListarDetalheTurmas();

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Deve clicar numa Turma!!!", "Apagar Turma");
                }
            }
            catch
            {
                MessageBox.Show("Deve eliminar os alunos dessa turma antes de apagar!", "Apagar Turma");
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
                    carregaComboboxTurmas();
                    ListarTurmas();
                    ListarDetalheTurmas();

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

                    MySqlCommand verificaTreinadorModalidade = new MySqlCommand("SELECT * FROM detalhetreinador WHERE idModalidade = @idModalidade AND idTreinador = @idTreinador", con);
                    verificaTreinadorModalidade.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                    verificaTreinadorModalidade.Parameters.AddWithValue("@idTreinador", cbo_treinadores.SelectedValue);

                    MySqlDataReader reader = verificaTreinadorModalidade.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("O treinador selecionado não está associado com a modalidade escolhida!", "Inserir Turma");
                        con.Close();
                        return;
                    }

                    reader.Close();

                    MySqlCommand inserirTurma = new MySqlCommand("insert into turmas (idModalidade, idTreinador, diaSemana, hora) values (@idModalidade, @idTreinador, @diaSemana, @hora)", con);
                    inserirTurma.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);
                    inserirTurma.Parameters.AddWithValue("@idTreinador", cbo_treinadores.SelectedValue);
                    inserirTurma.Parameters.AddWithValue("@diaSemana", cbo_diasemana.SelectedItem.ToString());
                    inserirTurma.Parameters.AddWithValue("@hora", dtp_hora.Value);

                    inserirTurma.ExecuteNonQuery();
                    MessageBox.Show("Turma inserida!", "Inserir Turma");
                    carregaComboboxTurmas();
                    ListarTurmas();
                    ListarDetalheTurmas();

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

        private void btn_associar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                string sqlContarSociosTurma = "SELECT COUNT(idTurma) from detalheturma where idTurma=@idTurma";
                MySqlCommand commandTotalTurma = new MySqlCommand(sqlContarSociosTurma, con);
                commandTotalTurma.Parameters.AddWithValue("@idTurma", cbo_turma.SelectedValue);
                int TotalAlunos = Convert.ToInt32(commandTotalTurma.ExecuteScalar());

                if (TotalAlunos >= 20)
                {
                    MessageBox.Show("A turma já está cheia!", "Associar Sócio/Turma");
                }
                else
                {
                    // Obter o ID da modalidade correspondente à turma selecionada
                    MySqlCommand commandObterModalidade = new MySqlCommand("SELECT idModalidade FROM turmas WHERE idTurma=@idTurma", con);
                    commandObterModalidade.Parameters.AddWithValue("@idTurma", cbo_turma.SelectedValue);
                    int idModalidadeTurma = Convert.ToInt32(commandObterModalidade.ExecuteScalar());

                    // Verificar se o sócio selecionado está inscrito na modalidade da turma
                    MySqlCommand commandVerificarInscricao = new MySqlCommand("SELECT COUNT(idCliente) FROM detalhesocio WHERE idCliente=@idCliente AND idModalidade=@idModalidade", con);
                    commandVerificarInscricao.Parameters.AddWithValue("@idCliente", cbo_socios.SelectedValue);
                    commandVerificarInscricao.Parameters.AddWithValue("@idModalidade", idModalidadeTurma);
                    int inscrito = Convert.ToInt32(commandVerificarInscricao.ExecuteScalar());

                    if (inscrito == 0)
                    {
                        MessageBox.Show("O sócio selecionado não está inscrito na modalidade desta turma!", "Associar Sócio/Turma");
                    }
                    else
                    {
                        MySqlCommand associarTurma = new MySqlCommand("INSERT INTO detalheturma (idTurma, idCliente) SELECT @idTurma, @idCliente WHERE NOT EXISTS (SELECT * FROM detalheturma WHERE idTurma = @idTurma AND idCliente = @idCliente)", con);

                        associarTurma.Parameters.AddWithValue("@idTurma", cbo_turma.SelectedValue);
                        associarTurma.Parameters.AddWithValue("@idCliente", cbo_socios.SelectedValue);

                        int rowsAffected = associarTurma.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            txt_totalsocios.Text = (TotalAlunos + 1).ToString();

                            string sqlUpdateTurma = "update turmas set totalAlunos = @totalSocios where idTurma=" + cbo_turma.Text;

                            MySqlCommand commandUpdateTurma = new MySqlCommand(sqlUpdateTurma, con);

                            commandUpdateTurma.Parameters.AddWithValue("@totalSocios", txt_totalsocios.Text);

                            commandUpdateTurma.ExecuteNonQuery();

                            MessageBox.Show("Sócio " + cbo_socios.Text + " adicionado à turma " + cbo_turma.Text + "!", "Associar Sócio/Turma");
                            ListarDetalheTurmas();
                            ListarTurmas();
                        }
                        else
                        {
                            MessageBox.Show("Já existe um registro com o mesmo sócio e turma!", "Associar Sócio/Turma");
                        }
                    }
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

                MySqlCommand desassociarSocios = new MySqlCommand("DELETE FROM detalheturma WHERE idTurma = @idTurma AND idCliente = @idCliente", con);

                desassociarSocios.Parameters.AddWithValue("@idTurma", cbo_turma.SelectedValue);
                desassociarSocios.Parameters.AddWithValue("@idCliente", cbo_socios.SelectedValue);

                int rowsAffected = desassociarSocios.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    string sqlContarSociosTurma = "SELECT COUNT(idTurma) from detalheturma where idTurma=" + cbo_turma.Text;

                    MySqlCommand commandTotalTurma = new MySqlCommand(sqlContarSociosTurma, con);

                    int TotalAlunos = Convert.ToInt32(commandTotalTurma.ExecuteScalar());

                    txt_totalsocios.Text = TotalAlunos.ToString();

                    string sqlUpdateTurma = "update turmas set totalAlunos = @totalSocios where idTurma=" + cbo_turma.Text;

                    MySqlCommand commandUpdateTurma = new MySqlCommand(sqlUpdateTurma, con);

                    commandUpdateTurma.Parameters.AddWithValue("@totalSocios", txt_totalsocios.Text);

                    commandUpdateTurma.ExecuteNonQuery();
                    MessageBox.Show("Sócio " + cbo_socios.Text + " eliminado da turma " + cbo_turma.Text + "!", "Desassociar Sócio/Turma");
                    ListarDetalheTurmas();
                    ListarTurmas();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum registro com o Sócio e Turma selecionados!", "Desassociar Sócio/Turma");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dgv_detalheturmas_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_turma.SelectedValue = dgv_detalheturmas.SelectedRows[0].Cells[0].Value.ToString();
            cbo_socios.SelectedValue = dgv_detalheturmas.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
