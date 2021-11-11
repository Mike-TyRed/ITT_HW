using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca_proyecto;
using Capa_Negocio;

namespace proyectofinal
{
    public partial class frmModificarLibro : Form
    {
        private ConectarLectorDataContext conexion = new ConectarLectorDataContext();
        public frmModificarLibro()
        {
            InitializeComponent();
            mostrar();
        }
        private void Clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void mostrar()
        {
            VerLibros.DataSource = conexion.MostrarLibros();//------------------------------Muestra los libros de el DataGrid
            Existencia.DataSource = conexion.MostrarDisponibles();//---------------------Muestra su respectiva disponibilidad
        }
        private void frmModificarLibro_Load(object sender, EventArgs e)
        {
        }
        private void btnG_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VerLibros.CurrentRow.Cells[0].Value);//---------------Obtiene el id del libro en el grid
            conexion.ActualizarLibro(txt1.Text, txt2.Text, txt3.Text, txt4.Text, id);//Modifica valores d los libros en la bd
            Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void VerLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Existencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
