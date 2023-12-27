using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ex3
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Dict_Def = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            dg_mot.Rows.Clear();
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            if (Dict_Def.ContainsKey(txt_mot.Text))
            {
                txt_def.Text = Dict_Def[txt_mot.Text];
            }
            else
            {
                txt_def.Text = "Mot intouvable";
            }
        }
        
        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Dict_Def.Add(txt_mot.Text, txt_def.Text);
            dg_mot.Rows.Add(txt_mot.Text, txt_def.Text);
        }
        private void afficher()
        { dg_mot.Rows.Clear();
        foreach(var elt in Dict_Def) {  
            dg_mot.Rows.Add(elt.Key, elt.Value);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Dict_Def.ContainsKey(txt_mot.Text))
            {
                Dict_Def.Remove(txt_mot.Text);
                txt_mot.Clear();
                txt_def.Clear();
                afficher();
                
            }
            else
            {
                MessageBox.Show( "Mot introuvable");
            }
        }

        private void btn_noveau_Click(object sender, EventArgs e)
        {
            txt_mot.Clear();
            txt_def.Clear();
        }
    }
}
