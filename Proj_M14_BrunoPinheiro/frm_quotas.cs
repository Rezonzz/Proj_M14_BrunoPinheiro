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
    public partial class frm_quotas : Form
    {
        public frm_quotas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (dgv_meses.Rows.Count > 0)
            {
                dgv_meses.Rows.RemoveAt(0);
            }
            int idSocio = Convert.ToInt32(cbo_socio.SelectedValue);
            lbl_socio.Text = cbo_socio.Text;
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                DateTime dataInscricao = DateTime.MinValue;
                string querySocio = "SELECT dataInscricao, nomeCliente FROM socios WHERE idCliente = @idCliente";
                MySqlCommand cmd = new MySqlCommand(querySocio, con);
                cmd.Parameters.AddWithValue("@idCliente", idSocio);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dataInscricao = reader.GetDateTime("dataInscricao");
                    string nomeSocio = reader.GetString("nomeCliente");

                    lbl_inscricao.Text = dataInscricao.ToString("dd/MM/yyyy");

                    reader.Close();

                    string queryQuota = "SELECT idQuota, idCliente, dataQuota, valorQuota, dataPagamento FROM quota WHERE idCliente = @idCliente";
                    cmd = new MySqlCommand(queryQuota, con);
                    cmd.Parameters.AddWithValue("@idCliente", idSocio);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    DateTime dataAtual = DateTime.Now;
                    int mesAtual = dataAtual.Month;
                    int anoAtual = dataAtual.Year;
                    int anoInscricao = dataInscricao.Year;
                    int mesInscricao = dataInscricao.Month;
                    dgv_meses.Rows.Add();

                    for (int i = 0; i < dgv_meses.Columns.Count; i++)
                    {
                        string nomeMes = dgv_meses.Columns[i].HeaderText;
                        int mesReferencia = DateTime.ParseExact(nomeMes, "MMMM", CultureInfo.CurrentCulture).Month;

                        if (mesReferencia >= mesInscricao && mesReferencia <= mesAtual && anoAtual == anoInscricao)
                        {
                            bool quotaPaga = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                DateTime dataQuota = Convert.ToDateTime(row["dataQuota"]);
                                int mesQuota = dataQuota.Month;
                                int anoQuota = dataQuota.Year;

                                if (mesQuota == mesReferencia && anoQuota == anoAtual && anoQuota >= anoInscricao)
                                {
                                    quotaPaga = true;
                                    break;
                                }
                            }

                            if (!quotaPaga)
                            {
                                dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Red;
                            }
                            else if (quotaPaga)
                            {
                                quotaPaga = true;
                                dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Green;
                            }
                        }

                        else if (anoAtual == anoInscricao && mesReferencia > mesAtual)
                        {
                            dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Gray;
                        }
                        else if (anoAtual == anoInscricao && mesReferencia < mesInscricao)
                        {
                            dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Gray;
                        }
                        else if (anoAtual == anoInscricao && mesReferencia > mesInscricao + 2)
                        {
                            dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Gray;
                        }
                    }

                    dgv_quotas.DataSource = dt;
                    dgv_quotas.Columns["idQuota"].HeaderText = "IdQuota";
                    dgv_quotas.Columns["idCliente"].HeaderText = "IdCliente";
                    dgv_quotas.Columns["dataQuota"].HeaderText = "Data da Quota";
                    dgv_quotas.Columns["valorQuota"].HeaderText = "Valor da Quota";
                    dgv_quotas.Columns["dataPagamento"].HeaderText = "Data do Pagamento";
                    lbl_idsocio.Text = cbo_socio.SelectedValue.ToString();
                    lbl_socio.Text = cbo_socio.Text;

                    lbl_soc.Visible = true;
                    lbl_socio.Visible = true;
                    lbl_vq.Visible = true;
                    lbl_quota.Visible = true;
                    lbl_datapag.Visible = true;
                    lbl_datapagamento.Visible = true;
                    btn_pagarquota.Visible = true;
                    btn_pagarquota.Enabled = true;
                    lbl_dataquota.Visible = true;
                    dtp_quota.Enabled = true;
                    dtp_quota.Visible = true;
                    DateTime dataAtual2 = DateTime.Now;
                    int mesAtual2 = dataAtual.Month;
                    DateTime novaData = new DateTime(dataInscricao.Year, mesAtual2, dataInscricao.Day);
                    dtp_quota.Value = novaData;

                }
                else
                {
                    MessageBox.Show("Sócio não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void frm_quotas_Load(object sender, EventArgs e)
        {
            carregaComboboxSocios();
            lbl_datapagamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dgv_meses.TabStop = false;
            dgv_quotas.TabStop = false;
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

        private void btn_pagarquota_Click(object sender, EventArgs e)
        {
            // Cria a conexão com o banco de dados
            MySqlConnection con = conn.GetConnection();

            try
            {
                // Abre a conexão
                con.Open();

                DateTime dataSelecionada = dtp_quota.Value;
                DateTime dataAtual = DateTime.Now;
                DateTime dataInscricao = DateTime.Parse(lbl_inscricao.Text);

                if (dataSelecionada > DateTime.Now || dataSelecionada < dataInscricao)
                {
                    MessageBox.Show("A data selecionada não é válida. Selecione uma data igual ou anterior à data de inscrição e atual ou anterior à data de hoje.");
                    return;
                }

                // Cria a query para inserir a quota na tabela "quota"
                string query = @"INSERT INTO quota (idCliente, dataQuota, valorQuota, dataPagamento) 
                 VALUES (@idCliente, @dataQuota, @valorQuota, @dataPagamento)";

                // Cria o comando para executar a query
                MySqlCommand cmd = new MySqlCommand(query, con);

                // Adiciona os parâmetros à query
                cmd.Parameters.AddWithValue("@idCliente", lbl_idsocio.Text);
                cmd.Parameters.AddWithValue("@dataQuota", dtp_quota.Value.Date);
                cmd.Parameters.AddWithValue("@valorQuota", Convert.ToDecimal(lbl_quota.Text));
                cmd.Parameters.AddWithValue("@dataPagamento", DateTime.Now.Date);

                // Executa o comando
                cmd.ExecuteNonQuery();

                // Identifica o mês correspondente à quota paga
                int mesPago = dtp_quota.Value.Month;

                // Percorre as colunas da dgvMeses para encontrar a coluna correspondente ao mês pago
                foreach (DataGridViewColumn col in dgv_meses.Columns)
                {
                    string nomeMes = col.HeaderText;
                    int mes = DateTime.ParseExact(nomeMes, "MMMM", CultureInfo.CurrentCulture).Month;

                    if (mes == mesPago)
                    {
                        // Altera a cor da célula correspondente ao mês pago para verde
                        dgv_meses.Rows[0].Cells[col.Index].Style.BackColor = Color.Green;
                        break;
                    }
                }

                // Cria a query para verificar se já existe uma quota paga para o mês e ano selecionados
                string checkQuery = @"SELECT COUNT(*) FROM quota 
                      WHERE idCliente = @idCliente 
                      AND YEAR(dataQuota) = @ano 
                      AND MONTH(dataQuota) = @mes";

                // Cria o comando para executar a consulta
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@idCliente", lbl_idsocio.Text);
                checkCmd.Parameters.AddWithValue("@ano", dtp_quota.Value.Year);
                checkCmd.Parameters.AddWithValue("@mes", dtp_quota.Value.Month);

                // Executa a consulta e obtém o resultado
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                // Verifica se já existe uma quota paga para o mês e ano selecionados
                if (count > 0)
                {
                    MessageBox.Show("Já existe uma quota paga para o mês selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Atualiza a DataGridView com os dados da quota paga
                string queryDgv = @"SELECT idQuota, idCliente, dataQuota, valorQuota, dataPagamento 
                    FROM quota 
                    WHERE idCliente = @idCliente
                    ORDER BY dataQuota DESC";

                MySqlCommand cmdDgv = new MySqlCommand(queryDgv, con);
                cmdDgv.Parameters.AddWithValue("@idCliente", lbl_idsocio.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdDgv);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_quotas.DataSource = table;

                // Exibe mensagem de sucesso
                MessageBox.Show("Quota paga com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Fecha a conexão
                con.Close();
            }
        }

        private void dgv_meses_SelectionChanged(object sender, EventArgs e)
        {
            dgv_meses.CurrentCell = null;
        }

        private void dgv_quotas_SelectionChanged(object sender, EventArgs e)
        {
            dgv_quotas.CurrentCell = null;
        }
    }
}
