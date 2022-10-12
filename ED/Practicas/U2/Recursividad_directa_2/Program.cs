using System;

namespace ES10_RecDi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Programa que suma números naturales recursivamente";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Ingrese la cantidad de números que desea registrar: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int [] n = new int [x];
            int c = 0, s = 0;
            Console.WriteLine();

            for(int v = 0; v < x; v++)
            {
                Console.Write("Ingrese un número: ");
                n[v] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Program Me = new Program();
            Me.Suma(n, x, c, s);
        }

        void Suma(int[] n, int x, int c, int s)
        {
            if(c < x)
            {
                s = s + n[c];
                c++;
                Suma(n, x, c, s);
            }
            else
            {
                Console.WriteLine("La suma de todos los números registrados es: " + s);
            }
        }
    }
}
