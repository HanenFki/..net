using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        List<float> lnote = new List<float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (list_int.SelectedIndex != -1)
            {
                int Index = list_int.SelectedIndex;
                if (Index >= 0 && Index < lnote.Count)
                    lnote.RemoveAt(Index);
                list_int.Items.RemoveAt(Index);
            }
            else { 
                MessageBox.Show("Sélectionner un élement"); 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float element =float.Parse (txt_rech.Text);
            if (lnote.Contains(element))
                {
                MessageBox.Show("L'element existe dans la liste");
            }
            else
            {
                MessageBox.Show("L'element n'existe dans la liste");
            }
        }

        private void rdb_inf10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_convertir_Click(object sender, EventArgs e)
        {
            string result = string.Join(" ", lnote);
            txt_ch.Text = result;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             lnote.Sort();
            Affiche();
        }
        private void Affiche()
        {
            list_int.Items.Clear();
            foreach (float n in lnote)
            {
                list_int.Items.Add(n);
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_note.Text))
                MessageBox.Show("note vide");
            else
            {
                try
                {
                    float note = float.Parse(txt_note.Text);
                    if (note < 0 || note > 20)
                        MessageBox.Show("note non valide");
                    else
                    {
                        lnote.Add(note);
                        Affiche();
                        txt_note.Clear();
                        txt_note.Focus();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            lnote.Clear();
            Affiche();
        }

        private void btn_inverser_Click(object sender, EventArgs e)
        {
            lnote.Reverse();
            Affiche();
        }

        private void btn_supp_tous_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_supp_tous_Click_1(object sender, EventArgs e)
        {
            if (rdb_sup10.Checked)
            {
                lnote.RemoveAll(x => x > 10);
                Affiche();
            }
            else if (rdb_inf10.Checked)
            {
                lnote.RemoveAll(x => x < 10);
                Affiche();
            }
            else if (rdb_egal10.Checked)
            {
                lnote.RemoveAll(x => x == 10);
                Affiche();
            }
            else
            {
                MessageBox.Show("Veuillez choisir une option de suppression.");
            }

            Affiche();
        }

        private void txt_ch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
