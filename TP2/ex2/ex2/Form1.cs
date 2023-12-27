using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        Queue<int> QVolailles = new Queue<int>();
        Queue<int> QViandes = new Queue<int>();
        int Tick_Vol = 1;
        int Tick_Viand = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Afficher_Volailles()
        {
            Lst_Volailles.Items.Clear();
            foreach (int ticket in QVolailles)
            {
                Lst_Volailles.Items.Add(ticket);
            }
        }

        private void Afficher_Viandes()
        {
            Lst_Viandes.Items.Clear();
            foreach (int ticket in QViandes)
            {
                Lst_Viandes.Items.Add(ticket);
            }
        }

        private void Btn_Tirer_Click(object sender, EventArgs e)
        {
            if (Rdb_Volailles.Checked)
            {
                QVolailles.Enqueue(Tick_Vol);
                Tick_Vol++;
                Afficher_Volailles();
            }
            else if (Rdb_Viandes.Checked)
            {
                QViandes.Enqueue(Tick_Viand);
                Tick_Viand++;
                Afficher_Viandes();
            }
        }

        private void Btn_Serv_Volail_Click(object sender, EventArgs e)
        {
            if (QVolailles.Count > 0)
            {
                QVolailles.Dequeue();
                Afficher_Volailles();
            }

        }

        private void Btn_Serv_Viande_Click(object sender, EventArgs e)
        {
            if (QViandes.Count > 0)
            {
                QViandes.Dequeue();
                Afficher_Viandes();
            }
        }

        private void Lst_Viandes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
