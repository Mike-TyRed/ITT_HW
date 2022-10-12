using System;

namespace _4_E_Unidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Estructuras Unidimensionales";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: #19211740");
            Console.WriteLine();
            
            string[] n;
            int[] c;

            n = new string[6];
            c = new int[6];

            for(int v=0; v<6; v++)
            {  
                Console.Write("Escribe un nombre: ");
                n[v] = Console.ReadLine();
                Console.Write("Escribe su calificación: ");
                c[v] = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine();
            }
            int mn = 6, mx = 8;

            for(int i = 0; i < 6; i++)
            {
                if(c[i] < mn)
                {
                    mn = c[i];
                    Console.Write("El promedio mas bajo es de: " + n[i] + " : " + c[i]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for(int i = 0; i <= 9; i++)
            {
                if(c[i] > mx)
                {
                    mn = c[i];
                    Console.Write("El promedio mas alto es: " + n[i] + " : " + c[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}