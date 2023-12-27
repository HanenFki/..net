using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_passager_Click(object sender, EventArgs e)
        {
            ajoutPassager pass = new ajoutPassager();
            pass.Show();
            this.Hide();
        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            tabVol vol = new tabVol();
            vol.Show();
            this.Hide();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            reservTicket tick = new reservTicket();
            tick.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
