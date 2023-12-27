using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Fliste_prod : Form
    {
        public Fliste_prod()
        {
            InitializeComponent();
        }

        private void txt_desg_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajout_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txt_ref.Clear();
            txt_desg.Clear();
            txt_cmb_categ.Items.Clear();
        }
    }
}
