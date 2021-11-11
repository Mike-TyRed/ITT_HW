using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace biblioteca_proyecto
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            btnInicio_Click(null,null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHijo(object FormHijo) 
        {
            if (this.PanelContenedor.Controls.Count > 0) 
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmInicioAdmin());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmDevolucionAdmin());
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAgregarLibroAdmin());
        }

        private void btnLectores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmMostrarUsuariosAdmin());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres cerrar la sesión?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
