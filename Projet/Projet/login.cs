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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emailAd.Text == "" || mdpAd.Text == "")
            {
                MessageBox.Show("Entrer le mot de passe et l'email");
            }
            else if (emailAd.Text == "admin@" || mdpAd.Text == "admin")
            {
                menu men = new menu();
                men.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou Mot de passe incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emailAd.Text = "";
            mdpAd.Text = "";
        }
    }
}
