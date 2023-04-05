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
    public partial class frm_treinadores : Form
    {
        public frm_treinadores()
        {
            InitializeComponent();
        }

        public void ListarTreinadores()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarTreinadores = new MySqlCommand("select * from treinadores", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarTreinadores);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_treinadores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void ListarDetalheTreinador()
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand listarDetalheTreinadores = new MySqlCommand("SELECT detalhetreinador.idModalidade, modalidades.nomeModalidade, detalhetreinador.idTreinador, treinadores.nomeTreinador FROM detalhetreinador, treinadores, modalidades WHERE detalhetreinador.idTreinador = treinadores.idTreinador AND detalhetreinador.idModalidade = modalidades.idModalidade", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(listarDetalheTreinadores);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_detalhetreinador.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
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
        private void frm_treinadores_Load(object sender, EventArgs e)
        {
            carregaComboboxTreinador();
            carregaComboboxModalidades();
            ListarTreinadores();
            ListarDetalheTreinador();
        }

        private void dgv_treinadores_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nome.Focus();
            txt_idtreinador.Text = dgv_treinadores.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dgv_treinadores.SelectedRows[0].Cells[1].Value.ToString();
            txt_morada.Text = dgv_treinadores.SelectedRows[0].Cells[2].Value.ToString();
            txt_nif.Text = dgv_treinadores.SelectedRows[0].Cells[3].Value.ToString();
            txt_email.Text = dgv_treinadores.SelectedRows[0].Cells[4].Value.ToString();
            txt_telefone.Text = dgv_treinadores.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idtreinador.Text != "")
                {
                    con.Open();

                    MySqlCommand atualizartreinador = new MySqlCommand("update treinadores set nomeTreinador=@nomeTreinador, morada=@morada, NIF=@NIF, email=@email, telefone=@telefone where idTreinador=@idTreinador", con);

                    atualizartreinador.Parameters.AddWithValue("@nomeTreinador", txt_nome.Text);
                    atualizartreinador.Parameters.AddWithValue("@morada", txt_morada.Text);
                    atualizartreinador.Parameters.AddWithValue("@NIF", txt_nif.Text);
                    atualizartreinador.Parameters.AddWithValue("@email", txt_email.Text);
                    atualizartreinador.Parameters.AddWithValue("@telefone", txt_telefone.Text);
                    atualizartreinador.Parameters.AddWithValue("@idTreinador", Convert.ToInt32(txt_idtreinador.Text));

                    atualizartreinador.ExecuteNonQuery();
                    MessageBox.Show("Treinador atualizado!", "Atualizar Treinador");
                    ListarDetalheTreinador();
                    carregaComboboxTreinador();
                    ListarTreinadores();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Deve clicar num Treinador!!!", "Atualizar Treinador");
                    txt_nome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txt_morada_TextChanged(object sender, EventArgs e)
        {
            txt_morada.MaxLength = 100;
            if (txt_morada.Text != "" && txt_morada.Text != "Morada")
            {
                lbl_morada.Visible = true;
            }
        }

        private void txt_nif_TextChanged(object sender, EventArgs e)
        {
            txt_nif.MaxLength = 9;
            if (txt_nif.Text != "" && txt_nif.Text != "NIF")
            {
                lbl_nif.Visible = true;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
            if (txt_email.Text != "" && txt_email.Text != "Email")
            {
                lbl_email.Visible = true;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            txt_telefone.MaxLength = 9;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
                lbl_telefone.Visible = true;
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

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_morada_Click(object sender, EventArgs e)
        {
            if (txt_morada.Text == "Morada")
            {
                txt_morada.ResetText();
                txt_morada.Focus();
                lbl_morada.Visible = true;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_nif_Click(object sender, EventArgs e)
        {
            if (txt_nif.Text == "NIF")
            {
                txt_nif.ResetText();
                txt_nif.Focus();
                lbl_nif.Visible = true;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.ResetText();
                txt_email.Focus();
                lbl_email.Visible = true;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            if (txt_telefone.Text == "Telefone")
            {
                txt_telefone.ResetText();
                txt_telefone.Focus();
                lbl_telefone.Visible = true;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }

            if (txt_morada.Text == "")
            {
                txt_morada.Text = "Morada";
                lbl_morada.Visible = false;
            }

            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                lbl_nome.Visible = false;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_morada.Text == "Morada")
                {
                    txt_morada.ResetText();
                    txt_morada.Focus();
                    lbl_morada.Visible = true;
                    if (txt_nome.Text == "")
                    {
                        txt_nome.Text = "Nome";
                        lbl_nome.Visible = false;
                    }
                }
                else
                {
                    txt_morada.Focus();
                    lbl_morada.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_morada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_nif.Text == "NIF")
                {
                    txt_nif.ResetText();
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                    if (txt_morada.Text == "")
                    {
                        txt_morada.Text = "Morada";
                        lbl_morada.Visible = false;
                    }
                }
                else
                {
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_nif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_email.Text == "Email")
                {
                    txt_email.ResetText();
                    txt_email.Focus();
                    lbl_email.Visible = true;
                    if (txt_nif.Text == "")
                    {
                        txt_nif.Text = "NIF";
                        lbl_nif.Visible = false;
                    }
                }
                else
                {
                    txt_email.Focus();
                    lbl_email.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_telefone.Text == "Telefone")
                {
                    txt_telefone.ResetText();
                    txt_telefone.Focus();
                    lbl_telefone.Visible = true;
                    if (txt_email.Text == "")
                    {
                        txt_email.Text = "Email";
                        lbl_email.Visible = false;
                    }
                }
                else
                {
                    txt_telefone.Focus();
                    lbl_telefone.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_nome.Text != "")
                {
                    if (txt_morada.Text != "")
                    {
                        if (txt_nif.Text != "")
                        {
                            if (txt_email.Text != "")
                            {
                                if (txt_telefone.Text != "")
                                {
                                    con.Open();

                                    MySqlCommand inserirTreinador = new MySqlCommand("INSERT INTO treinadores(nomeTreinador, morada, NIF, email, telefone) SELECT @nomeTreinador, @morada, @NIF, @email, @telefone FROM dual WHERE NOT EXISTS (SELECT 1 FROM treinadores WHERE (nomeTreinador = @nomeTreinador AND telefone = @telefone) OR NIF = @NIF)", con);

                                    inserirTreinador.Parameters.AddWithValue("@nomeTreinador", txt_nome.Text);
                                    inserirTreinador.Parameters.AddWithValue("@morada", txt_morada.Text);
                                    inserirTreinador.Parameters.AddWithValue("@NIF", txt_nif.Text);
                                    inserirTreinador.Parameters.AddWithValue("@email", txt_email.Text);
                                    inserirTreinador.Parameters.AddWithValue("@telefone", txt_telefone.Text);

                                    int rowsAffected = inserirTreinador.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Treinador adicionado!", "Adicionar Treinador");
                                        ListarTreinadores();
                                        ListarDetalheTreinador();
                                        carregaComboboxTreinador();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Já existe um treinador com o mesmo nome e número de telefone ou com o mesmo NIF!", "Erro");
                                    }
                                    con.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Digite o telefone do treinador!", "Adicionar Treinador");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite o email do treinador!", "Adicionar Treinador");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite o nif do treinador!", "Adicionar Treinador");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite a morada do treinador!", "Adicionar Treinador");
                    }
                }
                else
                {
                    MessageBox.Show("Digite o nome do treinador!", "Adicionar Treinador");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                if (txt_idtreinador.Text != "")
                {
                    string nomeTreinador = txt_nome.Text;
                    DialogResult result = MessageBox.Show("Tem a certeza que quer apagar o treinador " + nomeTreinador + "?", "Apagar Treinador", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        con.Open();

                        MySqlCommand apagartreinador = new MySqlCommand("delete from treinadores where idTreinador=@idTreinador", con);

                        apagartreinador.Parameters.AddWithValue("@idTreinador", Convert.ToInt32(txt_idtreinador.Text));

                        apagartreinador.ExecuteNonQuery();
                        MessageBox.Show("Treinador apagado!", "Apagar Treinador");
                        carregaComboboxTreinador();
                        ListarDetalheTreinador();
                        ListarTreinadores();

                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Deve clicar num Treinador!!!", "Apagar Treinador");
                }
            }
            catch
            {
               MessageBox.Show("Deve desassociar o treinador das suas modalidades ou da turma antes de apagar!", "Apagar Treinador");
            }
        }

        private void btn_associar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand associarTreinador = new MySqlCommand("INSERT INTO detalhetreinador (idTreinador, idModalidade) SELECT @idTreinador, @idModalidade WHERE NOT EXISTS (SELECT * FROM detalhetreinador WHERE idTreinador = @idTreinador AND idModalidade = @idModalidade)", con);

                associarTreinador.Parameters.AddWithValue("@idTreinador", cbo_treinadores.SelectedValue);
                associarTreinador.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);

                int rowsAffected = associarTreinador.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Treinador " + cbo_treinadores.Text + " associado com a modalidade " + cbo_modalidade.Text + "!", "Associar Treinador/Modalidade");
                    ListarDetalheTreinador();
                }
                else
                {
                    MessageBox.Show("Já existe um registro com o mesmo treinador e modalidade!", "Associar Treinador/Modalidade");
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

                MySqlCommand desassociarTreinador = new MySqlCommand("DELETE FROM detalhetreinador WHERE idTreinador = @idTreinador AND idModalidade = @idModalidade", con);

                desassociarTreinador.Parameters.AddWithValue("@idTreinador", cbo_treinadores.SelectedValue);
                desassociarTreinador.Parameters.AddWithValue("@idModalidade", cbo_modalidade.SelectedValue);

                int rowsAffected = desassociarTreinador.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Treinador " + cbo_treinadores.Text + " desassociado da modalidade " + cbo_modalidade.Text + "!", "Desassociar Treinador/Modalidade");
                    ListarDetalheTreinador();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum registro com o treinador e modalidade selecionados!", "Desassociar Treinador/Modalidade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dgv_detalhetreinador_MouseClick(object sender, MouseEventArgs e)
        {
            cbo_modalidade.SelectedValue = dgv_detalhetreinador.SelectedRows[0].Cells[0].Value.ToString();
            cbo_treinadores.SelectedValue = dgv_detalhetreinador.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void txt_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_nif.Text == "NIF")
                {
                    txt_nif.ResetText();
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                    if (txt_telefone.Text == "")
                    {
                        txt_telefone.Text = "Telefone";
                        lbl_telefone.Visible = false;
                    }
                }
                else
                {
                    txt_nif.Focus();
                    lbl_nif.Visible = true;
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
