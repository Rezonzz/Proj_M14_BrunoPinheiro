﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proj_M14_BrunoPinheiro
{
    public partial class frm_consultas : Form
    {
        public frm_consultas()
        {
            InitializeComponent();
        }

        private void txt_socio_TextChanged(object sender, EventArgs e)
        {
            txt_socio.MaxLength = 50;
            if (txt_socio.Text != "" && txt_socio.Text != "Nome Sócio")
            {
                if (txt_socio.Text.Any(char.IsDigit))
                {
                    txt_socio.Text = new string(txt_socio.Text.Where(c => !char.IsDigit(c)).ToArray());

                    txt_socio.SelectionStart = txt_socio.Text.Length;
                }
                lbl_socio.Visible = true;
            }
        }

        private void txt_modalidade_TextChanged(object sender, EventArgs e)
        {
            txt_modalidade.MaxLength = 50;
            if (txt_modalidade.Text != "" && txt_modalidade.Text != "Nome Modalidade")
            {
                if (txt_modalidade.Text.Any(char.IsDigit))
                {
                    txt_modalidade.Text = new string(txt_modalidade.Text.Where(c => !char.IsDigit(c)).ToArray());

                    txt_modalidade.SelectionStart = txt_modalidade.Text.Length;
                }
                lbl_modalidade.Visible = true;
            }
        }

        private void txt_treinador_TextChanged(object sender, EventArgs e)
        {
            txt_treinador.MaxLength = 50;
            if (txt_treinador.Text != "" && txt_treinador.Text != "Nome Treinador")
            {
                if (txt_treinador.Text.Any(char.IsDigit))
                {
                    txt_treinador.Text = new string(txt_treinador.Text.Where(c => !char.IsDigit(c)).ToArray());

                    txt_treinador.SelectionStart = txt_treinador.Text.Length;
                }
                lbl_treinador.Visible = true;
            }
        }

        private void txt_nif_TextChanged(object sender, EventArgs e)
        {
            txt_nif.MaxLength = 9;
            if (txt_nif.Text != "" && txt_nif.Text != "NIF")
            {
                if (txt_nif.Text.Any(char.IsLetter))
                {
                    txt_nif.Text = new string(txt_nif.Text.Where(c => !char.IsLetter(c)).ToArray());
                }
                if (txt_nif.Text.Any(char.IsWhiteSpace))
                {
                    txt_nif.Text = new string(txt_nif.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_nif.SelectionStart = txt_nif.Text.Length;
                lbl_nif.Visible = true;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            txt_telefone.MaxLength = 9;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
                if (txt_telefone.Text.Any(char.IsLetter))
                {
                    txt_telefone.Text = new string(txt_telefone.Text.Where(c => !char.IsLetter(c)).ToArray());
                }
                if (txt_telefone.Text.Any(char.IsWhiteSpace))
                {
                    txt_telefone.Text = new string(txt_telefone.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_telefone.SelectionStart = txt_telefone.Text.Length;
                lbl_telefone.Visible = true;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 50;
            if (txt_email.Text != "" && txt_email.Text != "Email")
            {
                if (txt_email.Text.Any(char.IsWhiteSpace))
                {
                    txt_email.Text = new string(txt_email.Text.Where(c => !char.IsWhiteSpace(c)).ToArray());
                }

                txt_email.SelectionStart = txt_email.Text.Length;
                lbl_email.Visible = true;
            }
        }

        private void txt_socio_Click(object sender, EventArgs e)
        {
            if (txt_socio.Text == "Nome Sócio")
            {
                txt_socio.ResetText();
                txt_socio.Focus();
                lbl_socio.Visible = true;
            }

            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }

            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
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

        private void txt_modalidade_Click(object sender, EventArgs e)
        {
            if (txt_modalidade.Text == "Nome Modalidade")
            {
                txt_modalidade.ResetText();
                txt_modalidade.Focus();
                lbl_modalidade.Visible = true;
            }

            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
            }

            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
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

        private void txt_treinador_Click(object sender, EventArgs e)
        {
            if (txt_treinador.Text == "Nome Treinador")
            {
                txt_treinador.ResetText();
                txt_treinador.Focus();
                lbl_treinador.Visible = true;
            }

            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }

            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
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

            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
            }

            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }

            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
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
        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            if (txt_telefone.Text == "Telefone")
            {
                txt_telefone.ResetText();
                txt_telefone.Focus();
                lbl_telefone.Visible = true;
            }

            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }

            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
            }

            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }

            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
            }

            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }
        }

        private void txt_socio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_modalidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_treinador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_nif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
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

            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
            }

            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }

            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
            }
            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }
            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
            }
            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }
            MySqlConnection con = conn.GetConnection();
            try
            {
                con.Open();

                MySqlCommand pesquisar = new MySqlCommand("SELECT nomeCliente AS Nome, NIF, Telefone, Email, Estado FROM socios WHERE nomeCliente LIKE '%" + txt_socio.Text + "%' OR NIF LIKE '%" + txt_nif.Text + "%' OR Telefone LIKE '%" + txt_telefone.Text + "%' OR Email LIKE '%" + txt_email.Text + "%' UNION SELECT nomeModalidade AS Nome, NULL AS NIF, NULL AS Telefone, NULL AS Email, Estado FROM modalidades WHERE nomeModalidade LIKE '%" + txt_modalidade.Text + "%' UNION SELECT nomeTreinador AS Nome, NIF, Telefone, Email, NULL AS Estado FROM treinadores WHERE nomeTreinador LIKE '%" + txt_treinador.Text + "%' OR NIF LIKE '%" + txt_nif.Text + "%' OR Telefone LIKE '%" + txt_telefone.Text + "%' OR Email LIKE '%" + txt_email.Text + "%'", con);
                MySqlDataAdapter grelha = new MySqlDataAdapter(pesquisar);
                DataTable dt = new DataTable();
                grelha.Fill(dt);
                dgv_consulta.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void frm_consultas_Load(object sender, EventArgs e)
        {

        }

        private void frm_consultas_Click(object sender, EventArgs e)
        {
            if (txt_socio.Text == "")
            {
                txt_socio.Text = "Nome Sócio";
                lbl_socio.Visible = false;
            }
            if (txt_modalidade.Text == "")
            {
                txt_modalidade.Text = "Nome Modalidade";
                lbl_modalidade.Visible = false;
            }
            if (txt_treinador.Text == "")
            {
                txt_treinador.Text = "Nome Treinador";
                lbl_treinador.Visible = false;
            }
            if (txt_nif.Text == "")
            {
                txt_nif.Text = "NIF";
                lbl_nif.Visible = false;
            }
            if (txt_telefone.Text == "")
            {
                txt_telefone.Text = "Telefone";
                lbl_telefone.Visible = false;
            }
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_email.Visible = false;
            }
        }
    }
}
