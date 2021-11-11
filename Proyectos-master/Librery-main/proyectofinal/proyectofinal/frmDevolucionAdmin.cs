using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_Negocio;

namespace biblioteca_proyecto
{
    public partial class frmDevolucionAdmin : Form
    {
        private ConectarLectorDataContext conexion = new ConectarLectorDataContext();

        public frmDevolucionAdmin()
        {
            InitializeComponent();
            mostrar();
        }
        private void mostrar()
        {
            VerLibros.DataSource = conexion.MostrarPedidos();//-----------------------Se muestran todos los pedidos de la BD
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VerLibros.CurrentRow.Cells[0].Value);//---------Se obtiene el id del pedido seleccionado
            string estado = "Devuelto";//---------------------------------------Estado del pedido por el que será reemplazado
            conexion.Estados(estado,id);//-----------------------------------------------Cambio el estado del pedido de la BD

            int idl = Convert.ToInt32(VerLibros.CurrentRow.Cells[2].Value);//-------------------------Obtiene el id del libro
            int disponbiles = conexion.VerDisponiblesEsp(idl);//---------Consulta la cantidad disponible del libro consultado
            disponbiles = disponbiles + 1;//---------------------------------------------Cambia el valor de la disponibilidad
            conexion.ModificarDisponible(disponbiles, idl);//-----------------Modifica la disponibilidad del respectivo libro
        }
    }
}
