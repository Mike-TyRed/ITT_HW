using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace biblioteca_proyecto
{
    public partial class frmPrestamo : Form
    {
        public int idl, idu;//---------------------------------------------------------------------------id libro, id usuario
        public string FechaP,FechaD;
        private ConectarLectorDataContext conexion = new ConectarLectorDataContext();

        public frmPrestamo()
        {
            InitializeComponent();
            VerLibros();
        }
        public void GetID(string u)//---------------------------------------------------------Obtenemos el nombre del usuario
        {
           idu = conexion.getIDuser(u);//-------------------------------------------------Comparamos el nombre con toda la BD
        }
        private void VerLibros()
        {
            dataGridView1.DataSource = conexion.MostrarLibros();//---------------------------Mostramos los libros disponibles
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cbxG_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.MostrarGeneros(cbxG.Text);//------------------------Muestra todos los géneros
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.MostrarTítulos(txt1.Text);//------------------------Muestra todos los títulos
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tablaprueba1DataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.tablaprueba1DataSet.Libros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbxG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            string estado = "Prestado";//-----------------------------Establece el estado que se reemplazará en los prestamos
            idl = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);//--------------Obtiene el id del libro en el grid
            FechaP = dtpP.Text;//---------------------------------------------------------------Fechas de prestamo y devuelta
            FechaD = dtpD.Text;
            conexion.NuevoPedido(idu, idl, FechaP, FechaD, estado);//-------------------------Inserta el nuevo pedido a la BD
            int cantidad = conexion.VerDisponiblesEsp(idl);//--------------------------Obtiene la cantidad del libro prestado
            cantidad = cantidad - 1;
            conexion.ModificarDisponible(cantidad, idl);//------------------------------Actualiza la disponibilidad del libro 
            VerLibros();//----------------------------------------------------------------Se muestran los libros actualizados
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres cerrar la sesión?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void btnR_Click(object sender, EventArgs e)
        {
        }
    }
}
