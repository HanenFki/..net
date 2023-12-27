using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projet
{
    public partial class voirVols : Form
    {
        public voirVols()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_airline;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String query = "select * from Vol";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dg_Vols.DataSource = ds.Tables[0];
            con.Close();
        }
        private void dg_passager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codeV_voir.Text = dg_Vols.SelectedRows[0].Cells[0].Value.ToString();
            srcV_voir.SelectedItem = dg_Vols.SelectedRows[0].Cells[1].Value.ToString();
            destv_Voir.SelectedItem = dg_Vols.SelectedRows[0].Cells[2].Value.ToString();
            nbrV_voir.Text = dg_Vols.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabVol v = new tabVol();
            v.Show();
            this.Hide();
        }

        private void voirVols_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codeV_voir.Text = "";
            nbrV_voir.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codeV_voir.Text == "")
            {
                MessageBox.Show("Entrer le vol à supprimer");
            }
            else
            {
                try
                {
                    con.Open();

                    // Utilisation de paramètres pour éviter l'injection SQL
                    String query = "DELETE FROM Vol WHERE idVol = @idVol;";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Ajout du paramètre
                    cmd.Parameters.AddWithValue("@idVol", codeV_voir.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vol supprimé");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codeV_voir.Text == "" || nbrV_voir.Text == "")
            {
                MessageBox.Show(" Informations manquantes ");
            }
            else
            {
                try
                {
                    con.Open();

                    // Correction de la requête SQL en ajoutant une guillemet simple manquante
                    String query = "update Vol set idVol='" + codeV_voir.Text + "',srcVol='" + srcV_voir.SelectedItem.ToString() + "',destVol='" + destv_Voir.SelectedItem.ToString() + "',nombPlac='" + nbrV_voir.Text + "',dateVol='" + dateV_voir.Value.Date.ToString() + "' where idVol='" + codeV_voir.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vol Modifié");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erreur : " + Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
