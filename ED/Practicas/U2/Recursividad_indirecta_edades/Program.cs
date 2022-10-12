using System;

namespace _13_RecInd_Edades
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

            Console.Write("¿Cuántas edades desea guardar?: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int [] x = new int [n];
            int i = 0, ii = 0;

            Program Me = new Program();
            Me.Ingresa(x, i, n, ii);
        }
        void Ingresa(int[] x, int i, int n, int ii)
        {
            if(i<n)
            {
                Console.Write("Ingresa una edad: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                i++;
                Ingresa(x, i, n, ii);
            }
            else{Console.Clear(); Imprime(x, i, n, ii);}
        }
        void Imprime(int[] x, int i, int n, int ii)
        {
            if(ii<n)
            {
                Console.WriteLine("Edad guardada: " + x[ii]);
                ii++;
                Imprime(x, i, n, ii);
            }
            else{}
        }
    }
}