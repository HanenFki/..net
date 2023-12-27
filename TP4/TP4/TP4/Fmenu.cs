using TP4;
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
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Connexion.Ouvrir();
            MessageBox.Show(Connexion.cn.State.ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connexion.Fermer();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            // Instanciez le formulaire de liste des clients
            FListe_cl formListeClients = new FListe_cl();

            // Affichez le formulaire de liste des clients
            formListeClients.Show();

            // Vous pouvez également masquer le formulaire actuel si nécessaire
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
