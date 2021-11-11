using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Capa_Negocio;
using System.Windows.Forms;

namespace biblioteca_proyecto
{
    public partial class frmMostrarUsuariosAdmin : Form
    {
        private ConectarLectorDataContext conexion = new ConectarLectorDataContext();
        public frmMostrarUsuariosAdmin()
        {
            InitializeComponent();
            dgvLectores.DataSource = conexion.MostrarUsuario();
        }
    }
}
