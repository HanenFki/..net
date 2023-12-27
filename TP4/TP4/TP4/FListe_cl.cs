using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.ADO;


namespace TP4
{
    public partial class FListe_cl : Form
    {
        public FListe_cl()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            dg.DataSource = ClientADO.Liste_Client();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ClientADO.Existe_Client(Int64.Parse(txt_cin.Text)))
                MessageBox.Show(this, "\n\nClient déjà existant", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                Client C = new Client
                {
                    Cin_Cl = Int64.Parse(txt_cin.Text),
                    Nom_Cl = txt_nom.Text,
                    Prenom_Cl = txt_prenom.Text,
                    Ville_Cl = txt_vil.Text,
                    Tel_Cl = Int64.Parse(txt_tel.Text)
                };
                ClientADO CA = new ClientADO();
                CA.Inserer(C);
                dg.DataSource = ClientADO.Liste_Client();
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Client C = new Client
            {
                Cin_Cl = Int64.Parse(txt_cin.Text),
                Nom_Cl = txt_nom.Text,
                Prenom_Cl = txt_prenom.Text,
                Ville_Cl = txt_vil.Text,
                Tel_Cl = Int64.Parse(txt_tel.Text)
            };
            ClientADO CA = new ClientADO();
            CA.Modifier(C);
            dg.DataSource = ClientADO.Liste_Client();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show(this, "\n\nVoulez-vous Confirmer la Suppression", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                ClientADO CA = new ClientADO();
                CA.Supprimer(Int64.Parse(txt_cin.Text));
                dg.DataSource = ClientADO.Liste_Client();
            }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {

            DataTable dtc = ClientADO.Liste_Client(Int64.Parse(txt_cin.Text));
            if (dtc.Rows.Count == 0)
                MessageBox.Show(this, "Client inexistant");
            else
            {
                txt_nom.Text = dtc.Rows[0][1].ToString();
                txt_prenom.Text = dtc.Rows[0][2].ToString();
                txt_vil.Text = dtc.Rows[0][3].ToString();
                txt_tel.Text = dtc.Rows[0][4].ToString();
            }
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            txt_cin.Clear();
            txt_nom.Clear();
            txt_prenom.Clear();
            txt_vil.Clear();
            txt_tel.Clear();
            txt_cin.Focus();
        }

        private void dg_DoubleClick(object sender, EventArgs e)
        {
            int ind = dg.CurrentRow.Index;

            txt_cin.Text = dg[0, ind].Value.ToString();
            txt_nom.Text = dg[1, ind].Value.ToString();
            txt_prenom.Text = dg[2, ind].Value.ToString();
            txt_vil.Text = dg[3, ind].Value.ToString();
            txt_tel.Text = dg[4, ind].Value.ToString();
        }
    }
}
