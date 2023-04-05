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
                lbl_socio.Visible = true;
            }
        }

        private void txt_modalidade_TextChanged(object sender, EventArgs e)
        {
            txt_modalidade.MaxLength = 50;
            if (txt_modalidade.Text != "" && txt_modalidade.Text != "Nome Modalidade")
            {
                lbl_modalidade.Visible = true;
            }
        }

        private void txt_treinador_TextChanged(object sender, EventArgs e)
        {
            txt_treinador.MaxLength = 50;
            if (txt_treinador.Text != "" && txt_treinador.Text != "Nome Treinador")
            {
                lbl_treinador.Visible = true;
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

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            txt_telefone.MaxLength = 9;
            if (txt_telefone.Text != "" && txt_telefone.Text != "Telefone")
            {
                lbl_telefone.Visible = true;
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
    }
}
