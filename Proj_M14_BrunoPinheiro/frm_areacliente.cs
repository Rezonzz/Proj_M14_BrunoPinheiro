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
    public partial class frm_areacliente : Form
    {
        public frm_areacliente()
        {
            InitializeComponent();
        }

        private void frm_areacliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_menu frm_menu = new frm_menu();
            frm_menu.Show();
        }
    }
}
