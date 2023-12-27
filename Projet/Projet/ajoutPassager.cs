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
    public partial class ajoutPassager : Form
    {
        public ajoutPassager()
        {
            InitializeComponent();
        }
        SqlConnection con =new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_airline;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddPass_Click(object sender, EventArgs e)
        {
            if(passId.Text=="" || passName.Text== "" || passeportPass.Text=="" || telPass.Text=="" || genrePass.Text=="" || nationalitePass.Text == "")
            {
                MessageBox.Show("informations manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Passager values(" + passId.Text + ",'" + passName.Text + "','" + genrePass.SelectedItem.ToString() + "','" + nationalitePass.SelectedItem.ToString() + "','" + passeportPass.Text + "','" + telPass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passager ajouté");
                    con.Close();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ajoutPassager_Load(object sender, EventArgs e)
        {

        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            passId.Text = "";
            passName.Text = "";
            genrePass.SelectedItem = "";
            nationalitePass.SelectedItem= "";
            passeportPass.Text = "";
            telPass.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_voirpass_Click(object sender, EventArgs e)
        {
            voirPassager voir = new voirPassager();
            voir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            men.Show();
            this.Hide();

        }
    }
}
