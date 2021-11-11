using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n;
            float s, h, t, sm;

            sm = 5900;

            n = txtn.Text;
            s = Convert.ToInt32(txts.Text);
            h = Convert.ToInt32(txth.Text);

            t = s * h;

            if(t <= sm)
            {
                MessageBox.Show("Nombre registrado: " + n);
            }
            else
            {
                MessageBox.Show("Nombre registrado: " + n + "\nNómina: " + t);
            }
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txth.Clear();
            txtn.Clear();
            txts.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbld.Text = DateTime.Now.ToShortDateString();
            lblh.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
