using System;
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
    public partial class reservTicket : Form
    {
        public reservTicket()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_airline;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String query = "select * from Ticket";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dg_ticket.DataSource = ds.Tables[0];
            con.Close();
        }
        String pname, pnat, ppass;

        private void fetchPassager()
        {
            con.Open();
            String query = "select *from passager where passId=" + passId_reserv.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["passName"].ToString();
                ppass = dr["passeportPass"].ToString();
                pnat = dr["nationalitePass"].ToString();
                nompass_reserv.Text = pname;
                numpass_reserv.Text = ppass;
                national_reserv.Text = pnat;
            }
            con.Close();
        }
        private void fillPassager()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select passId from passager", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("passId", typeof(int));
            dt.Load(dr);
            passId_reserv.ValueMember = "passId";
            passId_reserv.DataSource = dt;
            con.Close();
        }
        private void fillvolCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select idVol from Vol", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idVol", typeof(String));
            dt.Load(dr);
            codvol_reserv.ValueMember = "idVol";
            codvol_reserv.DataSource = dt;
            con.Close();
        }
        private void btn_reserv_Click(object sender, EventArgs e)
        {
            if (idTick_reserv.Text == "" || nompass_reserv.Text == "")
            {
                MessageBox.Show("informations manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Ticket values(" + idTick_reserv.Text + ",'" + Convert.ToInt32(passId_reserv.SelectedValue) + "','" + codvol_reserv.SelectedValue.ToString() + "','" + numpass_reserv.Text + "','" + nompass_reserv.Text + "','" + montant_reserv.Text + "','" + national_reserv.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket réservée");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dg_ticket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_resin_Click(object sender, EventArgs e)
        {
            idTick_reserv.Text = "";
            numpass_reserv.Text = "";
            nompass_reserv.Text = "";
            montant_reserv.Text = "";
            national_reserv.Text = "";
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            if (idTick_reserv.Text == "")
            {
                MessageBox.Show("Entrer le ticket à supprimer");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "delete from Ticket where IdTick =" + idTick_reserv.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket supprimée");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dg_ticket_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idTick_reserv.Text = dg_ticket.SelectedRows[0].Cells[0].Value.ToString();
            passId_reserv.Text = dg_ticket.SelectedRows[0].Cells[1].Value.ToString();

            codvol_reserv.Text = dg_ticket.SelectedRows[0].Cells[2].Value.ToString();
            numpass_reserv.Text = dg_ticket.SelectedRows[0].Cells[3].Value.ToString();
            nompass_reserv.Text = dg_ticket.SelectedRows[0].Cells[4].Value.ToString();
            montant_reserv.Text = dg_ticket.SelectedRows[0].Cells[5].Value.ToString();

            national_reserv.Text = dg_ticket.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            men.Show();
            this.Hide();
        }

        private void reservTicket_Load(object sender, EventArgs e)
        {
            fillPassager();
            fillvolCode();
            populate();
        }

        private void passId_reserv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPassager();

        }
    }
}
