using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string n, a, c, i, s, su, g;
            int ed;
            

            n = txt1.Text;
            a = txt2.Text;
            ed = Convert.ToInt32(txt3.Text);

            if(rbF.Checked == true) { g = "Femenino"; }
            else { g = "Masculino"; }

            c = Convert.ToString(cbcity.Text);
            
            if(cbSimple.Checked == true) { su = "Simple"; }
            else { su = "Urgencia"; }
      
            s = Convert.ToString(clSintomas.Text);

            MessageBox.Show(("Nombre: " + n + "\nApellido:" + a + "\nEdad:" + ed + "\nGénero: " + g + "\nCiudad: " + c + "\nTipo de consulta:" + su + "\nSintomas: "+ s));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
