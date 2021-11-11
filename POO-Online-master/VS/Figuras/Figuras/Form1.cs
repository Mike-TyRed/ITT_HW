using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    
    public partial class Form1 : Form
    {

        List<Rectangulo> figuras;


        private Button boton;
        private Button boton1;
        private Button boton2;
        private Button boton3;
        private Button boton4;

        public Form1()
        {
            InitializeComponent();

            figuras = new List<Rectangulo>();

            //Creación de botones Dibujar, Guardar, Abrir, Importar, Guardar selección.//
            this.boton = new System.    Windows.Forms.Button();
            this.boton.Name = "botonD";
            this.boton.Location = new System.Drawing.Point(0, 0);
            this.boton.Size = new System.Drawing.Size(60, 30);
            this.boton.TabIndex = 1;
            this.boton.Text = "Dibujar";
            this.boton.UseVisualStyleBackColor = true;
            this.Controls.Add(this.boton);

            this.boton1 = new System.Windows.Forms.Button();
            this.boton1.Name = "botonA";
            this.boton1.Location = new System.Drawing.Point(60, 0);
            this.boton1.Size = new System.Drawing.Size(60, 30);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Abrir";
            this.boton1.UseVisualStyleBackColor = true;
            this.Controls.Add(this.boton1);

            this.boton2 = new System.Windows.Forms.Button();
            this.boton2.Name = "botonI";
            this.boton2.Location = new System.Drawing.Point(120, 0);
            this.boton2.Size = new System.Drawing.Size(60, 30);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "Importar";
            this.boton2.UseVisualStyleBackColor = true;
            this.Controls.Add(this.boton2);

            this.boton3 = new System.Windows.Forms.Button();
            this.boton3.Name = "botonG";
            this.boton3.Location = new System.Drawing.Point(180, 0);
            this.boton3.Size = new System.Drawing.Size(60, 30);
            this.boton3.TabIndex = 1;
            this.boton3.Text = "Guardar";
            this.boton3.UseVisualStyleBackColor = true;
            this.Controls.Add(this.boton3);

            this.boton4 = new System.Windows.Forms.Button();
            this.boton4.Name = "botonGS";
            this.boton4.Location = new System.Drawing.Point(240, 0);
            this.boton4.Size = new System.Drawing.Size(70, 50);
            this.boton4.TabIndex = 1;
            this.boton4.Text = "Guardar Selección";
            this.boton4.UseVisualStyleBackColor = true;
            this.Controls.Add(this.boton4);
        }
        private void Form1_MouseClick(Object sender, MouseEventArgs e)
        {
            this.label1.Text = String.Format("{0},{1}", e.X, e.Y);

            Rectangulo r = new Rectangulo(e.X, e.Y, 10, 10);
            Elipse e = new Elipse(e.X, e.Y, 10, 10);
            elipse.Dibuja(this);
            r.Dibuja(this);
            figuras.Add(r);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Pedir que se pinten las figuras
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangulo r in figuras)
                r.Dibuja(this);
            
        }
    }
}
