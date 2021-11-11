using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Base : Form
    {

        public Base()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbDivi_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
        }

        private void rbResta_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbMulti_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbSuma_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btOper_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txt1.Text);
            double y = Convert.ToDouble(txt2.Text);
            double z;

            if (rbSuma.Checked == true)
            {
                z = x + y;
                res.Text = z.ToString();
            }
            if (rbResta.Checked == true)
            {
                z = x - y;
                res.Text = z.ToString();
            }
            if (rbMulti.Checked == true)
            {
                z = x * y;
                res.Text = z.ToString();
            }
            if (rbDivi.Checked == true)
            {
                z = x / y;
                res.Text = z.ToString();
            }
        }
    }
}
