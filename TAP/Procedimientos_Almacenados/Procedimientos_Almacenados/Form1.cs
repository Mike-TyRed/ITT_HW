using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos_Almacenados
{
    public partial class Form1 : Form
    {
        private DataClasses1DataContext conexion = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.LeerUser();
        }

        private void Limpiar()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); ;
                txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); ;
                txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); ;
                txt5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); ;
            }
            else
            {
                Limpiar();
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            conexion.InsertarUsuario(Convert.ToString(txt2.Text),txt3.Text,txt4.Text,txt5.Text);
            MessageBox.Show("Nuevo usuario registrado!");

            dataGridView1.DataSource = conexion.LeerUser();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Esta sección no es necesaria llenar para registrar, solo para modificar y eliminar");

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            conexion.UpUser(txt2.Text, txt3.Text, txt4.Text, txt5.Text, id);

            MessageBox.Show("!Usuario modificado con éxito!");

            dataGridView1.DataSource = conexion.LeerUser();
            Limpiar();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            conexion.DeletUser(id);

            MessageBox.Show("!Usuario eliminado con éxito!");

            dataGridView1.DataSource = conexion.LeerUser();
        }
    }
}
