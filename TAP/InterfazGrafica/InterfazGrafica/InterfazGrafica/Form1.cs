using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace InterfazGrafica
{
    public partial class Form1 : Form
    {
        int puntos = 0;
        string ruta;
        Random r = new Random();
        int c = 0;
        int[] lista = new int[5];

        Pen myPen = new Pen(Color.Black);
        Graphics g = null;
        static int center_x, center_y;
        static int start_x, start_y;
        static int end_x, end_y;

        static int my_length = 0;
        static int my_angle = 0;
        static int my_amount = 0;
        static int my_numberlines = 0;

        public Form1()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            my_length = r.Next(5, 20);
            my_angle = r.Next(0, 360);
            my_amount = r.Next(0, 10);
        }

        private void btntras_Click(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            x = r.Next(166, 701);
            y = r.Next(9, 391);

            Point punto = new Point(x, y);
            pictureBox1.Location = punto;
        }

        private void btnrota_Click(object sender, EventArgs e)
        {
            int a = r.Next(1, 2);
            Image img = pictureBox1.Image;
            switch (a)
            {
                case 1:
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Image = img;
                    break;
                case 2:
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox1.Image = img;
                    break;
            }
        }

        private void btnesca_Click(object sender, EventArgs e)
        {
            int x = r.Next(0, 521);
            int y = r.Next(0, 383);

            pictureBox1.Height = x;
            pictureBox1.Width = y;
        }

        private void btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abririmagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ruta = abririmagen.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtAncho_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Height = Int32.Parse(txtAncho.Text);
        }

        private void txtAlto_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = Int32.Parse(txtAlto.Text);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 1;
            my_length = r.Next(5,20);
            g = canvas.CreateGraphics();
            for (int i = 0; i < Int32.Parse(textBox1.Text); i++)

                drawline();
        }
        private void drawline()
        {
             my_angle = my_angle + r.Next(0, 360);
             my_length = my_length + r.Next(5, 20);

             end_x = (int)(start_x + Math.Cos(my_angle * .017453292519) * my_length);
             end_y = (int)(start_y + Math.Sin(my_angle * .017453292519) * my_length);

             Point[] points =
             {
                 new Point(start_x, start_y),
                 new Point(end_x, end_y)

             };

             start_x = end_x;
             start_y = end_y;


             g.DrawLines(myPen, points);

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            canvas.Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
