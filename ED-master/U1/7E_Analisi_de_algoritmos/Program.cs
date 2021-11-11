using System;
using System.Diagnostics;

namespace _7E_Analisi_de_algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts;
            Program Me = new Program();
            Stopwatch stp = new Stopwatch();
            stp.Start();
            
            Console.Clear();

            Console.Title = "Programa que muestra el mejor de los casos.";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Verificación del mejor de los casos");

            Console.WriteLine();

            Console.Write("Ingresa un número: ");
            int x = Ver();

            Console.WriteLine();

            Console.Write("Ingresa otro número: ");
            int y = Ver();

            Console.WriteLine("");

            Me.Mx(x,y);
            Me.Min(x,y);
            stp.Stop();

            ts = new TimeSpan(stp.ElapsedTicks);
            Console.Write("El programa tardó en ejecutarse: " + ts.TotalMilliseconds + "Milisegundos");
        }

        static int Ver()
        {
            int v;
            bool ok;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out v);
                Console.WriteLine("Ingrese un valor numérico entero");
            }while(!ok);
            return v;
        }
        void Mx(int x, int y)
        {
            if(x>y)
            {
                Console.Write("El mayor es: " + x);
            }
            else
            {
                if(x==y)
                    Console.Write("Son iguales: " + x);
                else
                    Console.Write("El menor es: " + x);
            }
        Console.WriteLine();
        }
        void Min(int x, int y)
        {
            if(y<x)
                Console.Write("El menor es: " + y);
            else
            {
                if(y==x)
                Console.Write("Son iguales: " + y);

                else
                Console.Write("El menor es: " + y);
            }
        Console.WriteLine();
        }
    }
}
