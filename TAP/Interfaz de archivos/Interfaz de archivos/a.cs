using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_de_archivos
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text.ToString();

            Form1 Regresa = new Form1();
            Regresa.GetNombre(Nombre);
            this.Hide();
        }

        private void a_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
