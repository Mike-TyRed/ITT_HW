using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interfaz_de_archivos
{
    public partial class Form1 : Form
    {
        a Nuevo;

        public Form1()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            rtxt.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Nuevo = new a();
            Nuevo.Show();

            Limpiar();
        }
        public void GetNombre(string Nombre)
        {
            TextWriter Escribe = new StreamWriter(Nombre+".txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Limpiar();
            string Path = @"C:\Users\PRIDE RACOON\source\repos\Interfaz de archivos\Interfaz de archivos\bin\Debug\";
            openFileDialog1.InitialDirectory = Path;
            

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;

                StreamReader txtIn = new StreamReader(new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read));


                string line = txtIn.ReadLine();
                rtxt.Text = line;

                rutaArchivo = rutaArchivo.Substring(87);
                lblAr.Text = "Nombre del archivo abierto: " + rutaArchivo;
                MessageBox.Show("¡Archivo abrido con éxito!");
                txtIn.Close();
            }

        }
        private void btnG_Click(object sender, EventArgs e)
        {

            string Path = @"C:\Users\PRIDE RACOON\source\repos\Interfaz de archivos\Interfaz de archivos\bin\Debug\";
            openFileDialog1.InitialDirectory = Path;
            string rutaArchivo = openFileDialog1.FileName;

            StreamWriter txtOut = new StreamWriter(
            new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write));
            
            txtOut.WriteLine(rtxt.Text.ToString());
            MessageBox.Show("¡Archivo guardadito con éxito!");

            Limpiar();
            txtOut.Close();
        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }
    }
}
