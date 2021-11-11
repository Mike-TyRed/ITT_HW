using System;

namespace _2_BurbujaMejorada
{
    class Program
    {
        static int opc;
        static string [] names = new string [15];
        static string n;
        static int x = 0;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Burbuja mejorada.";

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
            for(x = 0; x < names.Length; x++)
            {
                Console.Write("Ingrese un nombre: ");
                names[x] = Console.ReadLine();
            }
        }
        public static void Ordenar()
        {
            int bandera = 1; string aux = " ";
            int N = names.Length;
            for(int paso = 0; paso < (names.Length-1) && bandera == 1; paso++)
            {
                bandera = 0;
                for(int j = 0; j < (N-paso-1); j++)
                {
                    if(string.Compare(names[j], names[j+1]) > 0)
                    {
                        bandera = 1;
                        aux = names[j];
                        names[j] = names[j+1];
                        names[j+1] = aux; 
                    }
                }
            }
        }
        public static void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("Ordenado ascendente.");
            for(int f = 0; f < names.Length; f++)
            {
                Console.Write("[" + names[f] + "] ");
                if(f == 4 || f == 9)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}