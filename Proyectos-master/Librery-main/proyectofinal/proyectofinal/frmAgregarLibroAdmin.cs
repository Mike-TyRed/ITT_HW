using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Capa_Negocio;
using proyectofinal;

namespace biblioteca_proyecto
{
    public partial class frmAgregarLibroAdmin : Form
    {
        public int Disponible;//------------------------------------Variable donde se guardará la disponiblidad de los libros
        private ConectarLectorDataContext conexion = new ConectarLectorDataContext();
        public frmAgregarLibroAdmin()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }
        private void frmAgregarLibroAdmin_Load(object sender, EventArgs e)
        {
        }
        private void btnM_Click_1(object sender, EventArgs e)
        {
            frmModificarLibro m = new frmModificarLibro();//--------------Abre el form para modificar los datos de los libros
            m.Show();
        }
        private void btnG_Click_1(object sender, EventArgs e)
        {
            conexion.InsertarLibro(txt1.Text, txt2.Text, txt3.Text, txt4.Text);//----------------------Inserta libros a la BD
            Disponible = Convert.ToInt32(txt5.Text);//--------------Guarda el valor de la disponibilidad del respectivo libro
            conexion.Stock(int.Parse(txt5.Text), Disponible, 0);//----------------Inserta los valores de existencia del libro
            Clear();
        }
    }
}
