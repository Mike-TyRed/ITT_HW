using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_Negocio;
using System.Text.RegularExpressions;

namespace biblioteca_proyecto
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        private ConectarLectorDataContext conexion = new ConectarLectorDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (txtEmail.Text != ""&& Regex.IsMatch(txtEmail.Text, @"[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"))
                {
                    if (txtTelefono.Text != "" && Regex.IsMatch(txtTelefono.Text, @"^\d{3}-\d{3}-\d{4}$"))
                    {
                        if (txtContraseña.Text != "")
                        {
                            if (txtContraseña.Text == txtCcontraseña.Text)
                            {
                                conexion.InsertarUsuario(txtNombre.Text, txtEmail.Text, txtTelefono.Text, txtContraseña.Text, "usuario");
                                txtNombre.Text = "";
                                txtEmail.Text = "";
                                txtTelefono.Text = "";
                                txtContraseña.Text ="" ;
                                txtCcontraseña.Text = "";
                                MessageBox.Show("se agrego en la DB correctamente");
                            }
                            else if (txtCcontraseña.Text == "")
                            {
                                MessageBox.Show("Confirma la contraseña");
                            }
                            else
                            {
                                MessageBox.Show("Las constraseñas no coinciden");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduce una contraseña");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa un numero de telefono debe tener la siguiente estructura 123-456-7890");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa un correo valido");
                }
            }
            else
            {
                MessageBox.Show("ingresa un nombre");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
