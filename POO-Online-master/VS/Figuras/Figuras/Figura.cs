using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Figuras
{
    abstract class Figura
    {
        protected Pen pluma;
        protected Color color;
        protected SolidBrush brocha;
        protected int x, y;
        protected int ancho, alto;

        public Figura(int x, int y, int ancho, int alto)
        {
            this.x = x;
            this.y = y;
            this.ancho = ancho;
            this.alto = alto;
            brocha = new SolidBrush(Color.Red);
            pluma = new Pen(Color.Black);
        }

        abstract public void Dibuja(Form forma);

        class Rectangulo : Figura
        {
            public Rectangulo(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
            {

            }
            public override void Dibuja(Form forma)
            {
                //pen, brush, color
                Graphics graphics = forma.CreateGraphics();
                graphics.FillRectangle(brocha, x, y, ancho, alto);
                graphics.DrawRectangle(pluma, x, y, ancho, alto);
            }
        }

        abstract class Elipse : Figura
        {
            public Elipse(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
            {

            }
            public override void Dibuja(Form forma)
            {
                //pen, brush, color
                Graphics graphics = forma.CreateGraphics();
                graphics.FillEllipse(brocha, x, y, ancho, alto);
                graphics.DrawEllipse(pluma, x, y, ancho, alto);
            }
        }
    }
}
