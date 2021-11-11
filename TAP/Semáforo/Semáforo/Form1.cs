using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Form1 : Form
    {
        int caso = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ptbImagen.Image = Semáforo.Properties.Resources.Apagado;
            ptbImagen2.Image = Semáforo.Properties.Resources.Apagado;
            btnApagar.Enabled = false;
            btnDetener.Enabled = false;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnEncender.Enabled = false;
            btnDetener.Enabled = true;
            btnApagar.Enabled = true;

            label1.Text = "Semáforo encendido";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(caso)
            {
                case 0:
                    ptbImagen.Image = Semáforo.Properties.Resources.Verde;
                    ptbImagen2.Image = Semáforo.Properties.Resources.Rojo;
                    timer1.Interval = 5000;
                    caso = 1;
                    break;
                case 1:
                    ptbImagen.Image = Semáforo.Properties.Resources.Amarillo;
                    timer1.Interval = 5000;
                    caso = 2;
                    break;
                case 2:
                    ptbImagen2.Image = Semáforo.Properties.Resources.Verde;
                    ptbImagen.Image = Semáforo.Properties.Resources.Rojo;
                    timer1.Interval = 5000;
                    caso = 3;
                    break;
                case 3:
                    ptbImagen2.Image = Semáforo.Properties.Resources.Amarillo;
                    timer1.Interval = 5000;
                    caso = 0;
                    break;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if(btnDetener.Text == "Detener")
            {
                timer1.Enabled = false;
                btnDetener.Text = "Reanudar";
                label1.Text = "Semáforo detenido";
            }
            else
                if(btnDetener.Text == "Reanudar")
            {
                timer1.Enabled = true;
                btnDetener.Text = "Detener";
                label1.Text = "Semáforo encendido";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnDetener.Enabled = false;
            btnApagar.Enabled = false;
            btnEncender.Enabled = true;

            ptbImagen.Image = Semáforo.Properties.Resources.Apagado;
            ptbImagen2.Image = Semáforo.Properties.Resources.Apagado;

            label1.Text = "Semáforo apagado";
        }
    }
}
