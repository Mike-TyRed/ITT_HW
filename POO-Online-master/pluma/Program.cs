using System;

namespace pluma
{
    interface IPluma
    {
        string Color{get; set;}
        bool Abrir();                //pregunta si esta abierta la pluma
        bool Cerrar();               //pregunta si está cerrada la pluma
        void Escribir(string text);
    }
            //se implementa la propiedad para verificar si lo está o no
    class Cello:IPluma
    {
        //todos los métodos dentro de una interfaz deben ser public
        private bool puedeEscribir = false;

        public Cello(string color)
        {
            Color = color;
        }
        public string Color{get; set;}  

        public bool Abrir()
        {
            puedeEscribir = true;
            return puedeEscribir;
        }

         bool IPluma.Cerrar()       //explicito, no va con "public"
        {
            puedeEscribir = false;
            return puedeEscribir;
        }

        void IPluma.Escribir(string texto) //le digo lo que quiero que escriba
        {
            if (puedeEscribir)
            {
                Console.WriteLine("Escribir el texto: {0} en color {1} ", texto, Color);

            }
            else{Console.WriteLine("No escribe nada");}
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Cello pluma = new Cello("Rojo");
            Cello pluma1 = new Cello("Azul");
            IPluma pluma2 = new Cello("Negro");

            //exijo que se tome como pluma o interfaz
            ((IPluma) pluma).Escribir("Hola");
            pluma.Abrir();
            pluma1.Abrir();
            pluma2.Abrir();

            (pluma as IPluma).Escribir("Holaaaaa!");
        //    pluma1.Abrir();
            (pluma1 as IPluma).Escribir("Hello there");
            (pluma2 as IPluma).Escribir("nigga nigga nigga");

            // Bic pluma2 =
            // for (var o in objetos)
            // (o as IPluma).Escribir();
        }
    }
}
