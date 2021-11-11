using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Líneas1
{
    public partial class Form1 : Form
    {
        Graphics area;
        public Form1()
        {
            InitializeComponent();
            area = Area.CreateGraphics();
        }

        private void BtnDibujar_Click(object sender, EventArgs e)
        {
            Pen lapiz = new Pen(Color.Black);

            switch(cmbColor.SelectedIndex)
            {
                case 0: lapiz = new Pen(Color.Red); break;
                case 1: lapiz = new Pen(Color.Blue); break;
                case 2: lapiz = new Pen(Color.Yellow); break;
                case 3: lapiz = new Pen(Color.Green); break;
            }
            int iter = int.Parse(txtCantidad.Text);
            int espacio = int.Parse(txtEspacio.Text);

            area.Clear(Color.White);

            int inicial = 50;
            for(int i = 0; i < iter; i++)
            {
                area.DrawLine(lapiz, 20, inicial + (espacio * i), 300, inicial + (espacio * i));
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtEspacio.Clear();
            Area.Image = null;
            cmbColor.ResetText();
        }
    }
}
