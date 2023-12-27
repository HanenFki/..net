using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Rectangle> list = new List<Rectangle>();

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Rectangle R = new Rectangle(double.Parse(larg_txt.Text), double.Parse(long_txt.Text));
            list.Add(R);
            MessageBox.Show("Rectangle ajouter");

        }

        private void btn_affich_Click(object sender, EventArgs e)
        {
            dg.Rows.Clear();
           int i = 0;
            foreach(var elt in list)
            {
                dg.Rows.Add(i+1,elt.GetLargeur(),elt.GetLongeur(),elt.GetSurface());
                i++;
            }
        }
    }
}
