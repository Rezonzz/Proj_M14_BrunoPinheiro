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
            int idSocio = Convert.ToInt32(cbo_socio.SelectedValue);
            lbl_socio.Text = cbo_socio.Text; // adiciona o id do sócio à label lblIdSocio
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                // Busca a data de inscrição do sócio na tabela "socio"
                DateTime dataInscricao = DateTime.MinValue;
                string querySocio = "SELECT dataInscricao, nomeCliente FROM socios WHERE idCliente = @idCliente";
                MySqlCommand cmd = new MySqlCommand(querySocio, con);
                cmd.Parameters.AddWithValue("@idCliente", idSocio);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dataInscricao = reader.GetDateTime("dataInscricao");
                    string nomeSocio = reader.GetString("nomeCliente");

                    // Exibe a data de inscrição na label
                    lbl_inscricao.Text = dataInscricao.ToString("dd/MM/yyyy");

                    reader.Close(); // Fechar o DataReader antes de executar a próxima consulta

                    // Preenche a primeira datagridview com os dados da tabela "quota"
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

                    for (int i = 0; i < dgv_meses.Columns.Count; i++)
                    {
                        // Obtém o mês referente à coluna atual
                        string nomeMes = dgv_meses.Columns[i].HeaderText;
                        int mesReferencia = DateTime.ParseExact(nomeMes, "MMMM", CultureInfo.CurrentCulture).Month;

                        // Verifica se o mês de referência está dentro do intervalo de inscrição até o mês atual
                        if (mesReferencia >= mesInscricao && mesReferencia <= mesAtual && anoAtual == anoInscricao)
                        {
                            // Verifica se a quota do mês de referência já foi paga
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

                            // Caso a quota não tenha sido paga, marca a célula em vermelho
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

                        // Marca as células de meses posteriores em cinza
                        else if (anoAtual == anoInscricao && mesReferencia > mesAtual)
                        {
                            dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Gray;
                        }
                        // Verifica se o mês atual é anterior à data de inscrição
                        else if (anoAtual == anoInscricao && mesReferencia < mesInscricao)
                        {
                            // Marca a célula em cinza
                            dgv_meses.Rows[0].Cells[i].Style.BackColor = Color.Gray;
                        }
                        // Verifica se o mês atual é posterior à data de inscrição + 2 meses
                        else if (anoAtual == anoInscricao && mesReferencia > mesInscricao + 2)
                        {
                            // Marca a célula em cinza
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
                    cbo_quota.Items.Clear();

                    // Preenche a combobox com as datas da coluna "dataQuota" da dgv_quota
                    foreach (DataGridViewRow row in dgv_quotas.Rows)
                    {
                        if (row.Cells["dataQuota"].Value != null)
                        {
                            DateTime dataQuota = Convert.ToDateTime(row.Cells["dataQuota"].Value);
                            cbo_quota.Items.Add(dataQuota.ToString("dd/MM/yyyy"));
                        }
                    }

                    lbl_soc.Visible = true;
                    lbl_socio.Visible = true;
                    lbl_vq.Visible = true;
                    lbl_quota.Visible = true;
                    lbl_datapag.Visible = true;
                    lbl_datapagamento.Visible = true;
                    btn_pagarquota.Visible = true;
                    btn_pagarquota.Enabled = true;
                    lbl_dataquota.Visible = true;
                    cbo_quota.Enabled = true;
                    cbo_quota.Visible = true;
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

                // Cria a query para inserir a quota na tabela "quota"
                string query = @"INSERT INTO quota (idCliente, dataQuota, valorQuota, dataPagamento) 
                 VALUES (@idCliente, @dataQuota, @valorQuota, @dataPagamento)";

                // Cria o comando para executar a query
                MySqlCommand cmd = new MySqlCommand(query, con);

                // Adiciona os parâmetros à query
                cmd.Parameters.AddWithValue("@idCliente", lbl_idsocio.Text);
                cmd.Parameters.AddWithValue("@dataQuota", Convert.ToDateTime(cbo_quota.SelectedValue));
                cmd.Parameters.AddWithValue("@valorQuota", Convert.ToDecimal(lbl_quota.Text));
                cmd.Parameters.AddWithValue("@dataPagamento", DateTime.Now.Date);

                // Executa o comando
                cmd.ExecuteNonQuery();

                // Identifica o mês correspondente à quota paga
                int mesPago = Convert.ToDateTime(cbo_quota.SelectedValue).Month;

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
                lbl_soc.Visible = false;
                lbl_socio.Visible = false;
                lbl_vq.Visible = false;
                lbl_quota.Visible = false;
                lbl_datapag.Visible = false;
                lbl_datapagamento.Visible = false;
                btn_pagarquota.Visible = false;
                btn_pagarquota.Enabled = false;
                lbl_dataquota.Visible = false;
                cbo_quota.Enabled = false;
                cbo_quota.Visible = false;
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
    }
}
