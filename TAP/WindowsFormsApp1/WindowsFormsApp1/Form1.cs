using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-597BORI;Initial Catalog=B;Integrated Security=True");

        void Limpiar()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDataSet.Libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.bDataSet.Libro);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet3.Libro' Puede moverla o quitarla según sea necesario.
            //this.libroTableAdapter1.Fill(this.bibliotecaDataSet3.Libro);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Libro' Puede moverla o quitarla según sea necesario.
            // this.libroTableAdapter.Fill(this.bibliotecaDataSet.Libro);


        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand Registrar = new SqlCommand
                ("Insert into Libro (IDlibro, Titulo, Autor, Edicion, Genero) values (@IDlibro, @Titulo, @Autor, @Edicion, @Genero)", conexion);

            Registrar.Parameters.AddWithValue("IDlibro",txt1.Text);
            Registrar.Parameters.AddWithValue("Titulo", txt2.Text);
            Registrar.Parameters.AddWithValue("Autor", txt3.Text);
            Registrar.Parameters.AddWithValue("Edicion", txt4.Text);
            Registrar.Parameters.AddWithValue("Genero", txt5.Text);
            
            Registrar.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("Libro agregado");

            llenar_grid();
            conexion.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlCommand Consulta = new SqlCommand("Select * from Libro where IDlibro = @IDlibro", conexion);

            conexion.Open();

            Consulta.Parameters.AddWithValue("IDlibro", txt1.Text);

            SqlDataReader reader = Consulta.ExecuteReader();

            while(reader.Read())
            {
                txt1.Text = reader[0].ToString();
                txt2.Text = reader[1].ToString();
                txt3.Text = reader[2].ToString();
                txt4.Text = reader[3].ToString();
                txt5.Text = reader[4].ToString();
            }
            MessageBox.Show("Consula completa");
            conexion.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand
                ("Update Libro set  IDlibro = @IDlibro, Titulo = @Titulo, Autor = @Autor, Edicion = @Edicion, Genero = @Genero where IDlibro = @IDlibro", conexion);

            comando.Parameters.AddWithValue("IDlibro", txt1.Text);
            comando.Parameters.AddWithValue("Titulo", txt2.Text);
            comando.Parameters.AddWithValue("Autor", txt3.Text);
            comando.Parameters.AddWithValue("Edicion", txt4.Text);
            comando.Parameters.AddWithValue("Genero", txt5.Text);

            comando.ExecuteNonQuery();

            MessageBox.Show("Modificación exitosa");

            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
            llenar_grid();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string Eliminar = "Delete from libro where IDlibro = @IDlibro";

            SqlCommand cmdbj = new SqlCommand(Eliminar, conexion);

            cmdbj.Parameters.AddWithValue("IDlibro", txt1.Text);
            cmdbj.ExecuteNonQuery();

            cmdbj.Dispose();
            cmdbj = null;

            Limpiar();
            conexion.Close();

            MessageBox.Show("libro eliminado");
            llenar_grid();

            conexion.Close();
        }

        public void llenar_grid()
        {
            try
            {
                SqlDataAdapter dg = new SqlDataAdapter("Select * from Libro", conexion);
                DataTable dt = new DataTable();
                dg.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar el la tabla" + ex.ToString());
            }
        }
    }
}
