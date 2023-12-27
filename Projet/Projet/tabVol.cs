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
    public partial class tabVol : Form
    {
        public tabVol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_airline;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (Vcode.Text == "" || Vsrc.Text == "" || Vdest.Text == "" || Vnbrplac.Text == "" || Vdate.Text == "" )
            {
                MessageBox.Show("informations manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Vol values('" + Vcode.Text + "','" + Vsrc.SelectedItem.ToString() + "','" + Vdest.SelectedItem.ToString() + "','" + Vnbrplac.Text + "','" + Vdate.Value.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vol ajouté");
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabVol_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vcode.Text = "";
            Vnbrplac.Text = "";
        }

        private void btn_voirvol_Click(object sender, EventArgs e)
        {
            voirVols vv = new voirVols();
            vv.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu men = new menu();
            men.Show();
            this.Hide();
        }
    }
}
