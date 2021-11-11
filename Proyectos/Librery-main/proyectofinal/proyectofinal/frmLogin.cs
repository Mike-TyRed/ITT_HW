using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using System.Runtime.InteropServices;
using Capa_Entidad.Cache;


namespace biblioteca_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {

                if (txtContraseña.Text != "Contraseña")
                {
                    ClassNegocio user = new ClassNegocio();
                    var validLogin = user.loginUser(txtUsuario.Text,txtContraseña.Text);
                    if (validLogin == true)
                    {
                        if (login_cache_usuario.Cargo == "admin")
                        {
                            frmAdmin administra = new frmAdmin();
                            administra.Show();
                            administra.FormClosed += CerrarSecion;
                            this.Hide();
                        }
                        else if (login_cache_usuario.Cargo == "usuario")
                        {
                            string u = txtUsuario.Text;//-------------------Guardo el nombre del usuario 
                            frmPrestamo prestar = new frmPrestamo();
                            prestar.GetID(u);//-----------------------------Mando el nombre guardado al form de prestamo
                            prestar.Show();
                            prestar.FormClosed += CerrarSecion;
                            this.Hide();
                        }
                        
                    }
                    else 
                    {
                        MessageError("Nombre de Usuario o Contraseña incorrectos\n Porfavor intente de nuevo");
                        txtUsuario.Text = "Usuario";
                        txtContraseña.Text="Contraseña";
                        txtContraseña.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
                else 
                {
                    MessageError("Porfavor introduzca una contraseña");
                }
            }
            else 
            {
                MessageError("Porfavor introduzca un nombre de usuario");
            }
        }
        private void MessageError(string msg) 
        {
            lblMessage.Text = "    " + msg;
            lblMessage.Visible = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CerrarSecion(object sender, FormClosedEventArgs e) 
        {
            txtUsuario.Text="Usuario";
            txtContraseña.Text="Contraseña";
            txtContraseña.UseSystemPasswordChar = false;
            lblMessage.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") 
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }

        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                                       /*sirve para mover el formulario*/
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();/*puedes mover el frormulario desde el panel*/
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();/*puedes mover el frormulario desde la imagen*/
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
