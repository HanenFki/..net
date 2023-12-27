using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Projet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Myprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start = start +1;
            Myprogress.Value=start;
            if(Myprogress.Value==100)
            {
            Myprogress.Value=0;
            timer2.Stop();
            login log =new login();
                log.Show();
            this.Hide();
            }
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Myprogress_ValueChanged(object sender, EventArgs e)
        {

        }
    }
            }
