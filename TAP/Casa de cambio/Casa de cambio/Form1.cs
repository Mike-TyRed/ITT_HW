using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_de_cambio
{
    public partial class Form1 : Form
    {
        //              variables globales
        double d, r, u, eu, c, l, m;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //                                                                                      Creo las variables
            d = Convert.ToDouble(txt1.Text);
            r = 0;

            //                                                                                      Lectura de moneda ingresada
            switch(Convert.ToInt32(cmbx1.SelectedIndex))
            {
                case 1://   USD
                    u = 1;
                    eu = 1.19451;
                    c = 0.799706;
                    l = 1.38672;
                    m = 0.0487626;
                    Opcion2();
                    break;
                case 2://   EUR
                    u = 0.837164;
                    eu = 1;
                    c = 0.669327;
                    l = 1.16093;
                    m = 0.0408211;
                    Opcion2();
                    break;
                case 3://   GBP Libras esterlinas
                    u = 0.721098;
                    eu = 0.861378;
                    c = 0.576544;
                    l = 1;
                    m = 0.0351624;
                    Opcion2();
                    break;
                case 4://   CAD Dólares canadienses
                    u = 1.25072;
                    eu = 1.49404;
                    c = 1;
                    l = 1.73447;
                    m = 0.0609882;
                    Opcion2();
                    break;
                default://  MX
                    u = 20.50;
                    eu = 24.49;
                    c = 16.39;
                    l = 28.44;
                    m = 1;
                    Opcion2();
                    break;
            }
        }
        public void Opcion2()
        {
            switch (Convert.ToInt32(cmbx2.SelectedIndex))
            {
                case 1://   USD
                    r = d / u;
                    Mensaje();
                    break;
                case 2://   EUR
                    r = d / eu;
                    Mensaje();
                    break;
                case 3://   GBP Libras esterlinas
                    r = d / l;
                    Mensaje();
                    break;
                case 4://   CAD Dólares canadienses
                    r = d / c;
                    Mensaje();
                    break;
                default://  MX
                    r = d / m;
                    Mensaje();
                    break;
            }
        }
        public void Mensaje()
        {
            MessageBox.Show("Usted recibe: " + r);
        }
    }
}