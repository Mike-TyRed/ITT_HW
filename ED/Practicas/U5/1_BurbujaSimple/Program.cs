using System;

namespace _1_BurbujaSimple
{
    class Program
    {
        static int opc;
        static float [] calfs = new float [30];
        static float c;
        static int x = 0;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Burbuja simple.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            Ingresar();
            Ordenar();
            Imprimir();
        }
        public static void Ingresar()
        {
            Console.Clear();
            for(x = 0; x < calfs.Length; x++)
            {
                Console.Write("Ingrese una calificación: [" + (x+1) + "]");
                calfs[x] = float.Parse(Console.ReadLine());
            }
        }
        public static void Ordenar()
        {
            float t;
            for(int a = 1; a < calfs.Length; a++)
            {
                for(int b = (calfs.Length-1); b >= a; b--)
                {
                    if(calfs[b - 1] < calfs[b])
                    {
                        t = calfs[b-1];
                        calfs[b - 1] = calfs[b];
                        calfs[b] = t;
                    }
                }
            }
        }
        public static void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("Ordenado descendente.");
            for(int f = 0; f < calfs.Length; f++)
            {
                Console.Write("[" + calfs[f] + "] ");
                if (f == 9 || f == 19)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
