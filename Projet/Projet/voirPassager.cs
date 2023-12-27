using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class voirPassager : Form
    {
        public voirPassager()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_airline;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String query = "select * from Passager";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dg_passager.DataSource = ds.Tables[0];
            con.Close();
        }
        private void voirPassager_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DgvPassager_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ajoutPassager ajout = new ajoutPassager();
            ajout.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idpass_voir.Text == "")
            {
                MessageBox.Show("Entrer le passager à supprimer");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "delete from Passager where passId =" + idpass_voir.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passager supprimé");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dg_passager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idpass_voir.Text = dg_passager.SelectedRows[0].Cells[0].Value.ToString();
            nompass_voir.Text = dg_passager.SelectedRows[0].Cells[1].Value.ToString();
           
            genrepass_voir.Text = dg_passager.SelectedRows[0].Cells[2].Value.ToString();
            nationalit_voir.Text = dg_passager.SelectedRows[0].Cells[3].Value.ToString();
            numpass_voir.Text = dg_passager.SelectedRows[0].Cells[4].Value.ToString();
            telpass_voir.Text = dg_passager.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idpass_voir.Text = "";
            nompass_voir.Text = "";
            numpass_voir.Text = "";
            genrepass_voir.SelectedItem = "";
            nationalit_voir.SelectedItem = "";
            numpass_voir.Text = "";
            telpass_voir.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idpass_voir.Text == "" || nompass_voir.Text == "" || numpass_voir.Text == "")
            {
                MessageBox.Show(" Informations manquantes ");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "update Passager set passName='" + nompass_voir.Text + "',genrePass='" + genrepass_voir.SelectedItem.ToString() + "',nationalitePass='" + nationalit_voir.SelectedItem.ToString() + "',passeportPass='" + numpass_voir.Text + "',telPass='" + telpass_voir.Text + "' where passId =" + idpass_voir.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passager Modifié");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(" Informations manquantes ");
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
