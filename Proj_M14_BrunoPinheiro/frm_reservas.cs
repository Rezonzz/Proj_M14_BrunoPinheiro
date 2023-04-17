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
    public partial class frm_reservas : Form
    {
        public frm_reservas()
        {
            InitializeComponent();
        }

        private void frm_reservas_Load(object sender, EventArgs e)
        {
            ListarOcupacao();
            carregaComboboxSocios();
            carregaComboboxInstalacao();
        }

        private void ListarOcupacao()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarInstalacao = new MySqlCommand("SELECT * FROM reservas", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarInstalacao);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_ocupacao.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
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

        public void carregaComboboxSocios()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand carregarSocios = new MySqlCommand("select * from socios " + "order by nomeCliente", con);
                MySqlDataReader dr = carregarSocios.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo_socio.DisplayMember = "nomeCliente";
                cbo_socio.ValueMember = "idCliente";
                cbo_socio.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro: Não Carregou Sócios!", "Lista Sócios");
            }
        }

        private void btn_efetuar_Click(object sender, EventArgs e)
        {
            if (cbo_socio.SelectedIndex < 0 || cbo_instalacao.SelectedIndex < 0 || dtp_reserva.Value <= DateTime.Today || dtp_inicio.Value == dtp_fim.Value)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios e verifique as datas e horários!", "Efetuar Reserva");
                return;
            }

            // Verificação de conflitos de reserva
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand verifReservas = new MySqlCommand("SELECT * FROM reservas WHERE idInstalacao = @idInstalacao AND dataReserva = @dataReserva AND ((horaInicio >= @horaInicio AND horaInicio < @horaFim) OR (horaFim > @horaInicio AND horaFim <= @horaFim) OR (horaInicio <= @horaInicio AND horaFim >= @horaFim))", con);
                verifReservas.Parameters.AddWithValue("@idInstalacao", cbo_instalacao.SelectedValue);
                verifReservas.Parameters.AddWithValue("@dataReserva", dtp_reserva.Value.Date);
                verifReservas.Parameters.AddWithValue("@horaInicio", dtp_inicio.Value.TimeOfDay);
                verifReservas.Parameters.AddWithValue("@horaFim", dtp_fim.Value.TimeOfDay);

                MySqlDataReader dr = verifReservas.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Já existe uma reserva para esta instalação com as mesmas horas e data!", "Efetuar Reserva");
                    dr.Close();
                    return;
                }
                else
                {
                    btn_efetuar.Enabled = false;
                    btn_efetuar.Visible = false;
                    btn_cancelar.Enabled = true;
                    btn_cancelar.Visible = true;
                    btn_concluir.Enabled = true;
                    cbo_instalacao.Enabled = false;
                    cbo_socio.Enabled = false;
                    dtp_reserva.Enabled = false;
                    dtp_inicio.Enabled = false;
                    dtp_fim.Enabled = false;
                }
                dr.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
            }

            // Cálculo do valor da reserva

            // Cálculo do valor da reserva

            TimeSpan totalHoras;
            if (dtp_inicio.Value <= dtp_fim.Value)
            {
                totalHoras = dtp_fim.Value.Subtract(dtp_inicio.Value);
            }
            else
            {
                totalHoras = dtp_fim.Value.AddDays(1).Subtract(dtp_inicio.Value);
            }
            con.Open();
            decimal valorHora = 0;
            MySqlCommand cmd = new MySqlCommand("SELECT precoHora FROM Instalacao WHERE idInstalacao = @id", con);
            cmd.Parameters.AddWithValue("@id", cbo_instalacao.SelectedValue);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                valorHora = Convert.ToDecimal(reader["precoHora"]);
            }
            reader.Close();
            con.Close();
            decimal valorPagar = (decimal)(totalHoras.TotalHours) * valorHora;

            // Adição dos dados na tabela dgv_detalhereserva
            dgv_detalhereserva.Rows.Add(cbo_instalacao.SelectedValue, cbo_socio.SelectedValue, dtp_reserva.Value.Date, dtp_inicio.Value.TimeOfDay, dtp_fim.Value.TimeOfDay, totalHoras.TotalHours, valorHora, valorPagar);
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            if (dgv_detalhereserva.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja concluir a reserva?", "Concluir Reserva", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlConnection con = conn.GetConnection();
                    try
                    {
                        con.Open();
                        MySqlCommand inserirReserva = new MySqlCommand("INSERT INTO reservas (idInstalacao, idCliente, dataReserva, horaInicio, horaFim, totalHoras, valorHora, valorPagar) VALUES (@idInstalacao, @idCliente, @dataReserva, @horaInicio, @horaFim, @totalHoras, @valorHora, @valorPagar)", con);
                        foreach (DataGridViewRow row in dgv_detalhereserva.Rows)
                        {
                            inserirReserva.Parameters.Clear();
                            inserirReserva.Parameters.AddWithValue("@idInstalacao", row.Cells["idInstalacao"].Value);
                            inserirReserva.Parameters.AddWithValue("@idCliente", row.Cells["idCliente"].Value);
                            inserirReserva.Parameters.AddWithValue("@dataReserva", row.Cells["dataReserva"].Value);
                            inserirReserva.Parameters.AddWithValue("@horaInicio", row.Cells["horaInicio"].Value);
                            inserirReserva.Parameters.AddWithValue("@horaFim", row.Cells["horaFim"].Value);
                            inserirReserva.Parameters.AddWithValue("@totalHoras", row.Cells["totalHoras"].Value);
                            inserirReserva.Parameters.AddWithValue("@valorHora", row.Cells["valorHora"].Value);
                            inserirReserva.Parameters.AddWithValue("@valorPagar", row.Cells["valorPagar"].Value);
                            inserirReserva.ExecuteNonQuery();
                        }
                        con.Close();

                        ListarOcupacao();
                        MessageBox.Show("Reserva concluída com sucesso!", "Concluir Reserva");
                        btn_efetuar.Enabled = true;
                        btn_efetuar.Visible = true;
                        btn_concluir.Enabled = false;
                        dgv_detalhereserva.Rows.Clear();
                        btn_cancelar.Enabled = false;
                        btn_cancelar.Visible = false;
                        cbo_instalacao.Enabled = true;
                        cbo_socio.Enabled = true;
                        dtp_reserva.Enabled = true;
                        dtp_inicio.Enabled = true;
                        dtp_fim.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    btn_efetuar.Enabled = true;
                    btn_efetuar.Visible = true;
                    btn_concluir.Enabled = false;
                    dgv_detalhereserva.Rows.Clear();
                    btn_cancelar.Enabled = false;
                    btn_cancelar.Visible = false;
                    cbo_instalacao.Enabled = true;
                    cbo_socio.Enabled = true;
                    dtp_reserva.Enabled = true;
                    dtp_inicio.Enabled = true;
                    dtp_fim.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Não há detalhes de reserva para concluir!", "Concluir Reserva");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_efetuar.Enabled = true;
            btn_efetuar.Visible = true;
            btn_concluir.Enabled = false;
            dgv_detalhereserva.Rows.Clear();
            btn_cancelar.Enabled = false;
            btn_cancelar.Visible = false;
            cbo_instalacao.Enabled = true;
            cbo_socio.Enabled = true;
            dtp_reserva.Enabled = true;
            dtp_inicio.Enabled = true;
            dtp_fim.Enabled = true;
        }
    }
}
