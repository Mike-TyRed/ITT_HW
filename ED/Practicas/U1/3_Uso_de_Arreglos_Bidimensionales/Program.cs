using System;

namespace _3_Uso_de_Arreglos_Bidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "USO DE ARREGLOS BIDIMENSIONALES";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: #19211740");
            
            Console.WriteLine();

            int[,] a;
            a = new int [3, 2];

            for(int c = 0; c < 3; c++)
            {
                for(int f = 0; f < 2; f++)
                {
                    Console.Write("Ingresa un número: ");
                    a[c,f] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Matríz original");
            for(int c = 0; c < 3; c++)
            {
                for(int f = 0; f < 2; f++)
                {
                    
                    Console.Write(" " + a[c, f]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Matríz traspuesta");
            for(int c = 0; c < 2; c++)
            {
                for(int f = 0; f < 3; f++)
                {
                    
                    Console.Write(" " + a[f, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
