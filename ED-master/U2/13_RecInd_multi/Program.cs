using System;

namespace _13_RecInd_multi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa que hace tabla de multiplicar con recursividad";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Ingresa la tabla de multiplicar que desea ver: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0, c = 0;
            //int r = 0;

            int [] r = new int[13];

            Console.WriteLine();

            Program Me = new Program();
            Me.Multiplicacion(r, n, c, x);
        }
        void Multiplicacion(int[] r, int n, int c, int x)
        {
            if(c <= 12)
            {
                r[c] = n * c;
                c++;
                Multiplicacion(r, n, c, x);
            }
            else
                Imprimir(r, n, x);
        }
        void Imprimir(int[] r, int n, int x)
        {
            if(x <= 12)
            {
            Console.WriteLine( n + " * " + x + " = " + r[x]);
            x++;
            Imprimir(r, n, x);
            }
            else
                Console.WriteLine("Fin de la recursividad");
        }
    }
}
