using System;

namespace _1_BusquedaSencuencialDes
{
    class Program
    {
        static string [] n = new string[12];
        static bool ba = false, pr;
        static int i, ps;
        static string bu;
        static Random r = new Random();
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

            for (int x = 0; x < n.Length; x++)
            {
                Console.Write("Ingresa un nombre [" + (x+1) + "]: ");
                n[x] = Console.ReadLine();
                Console.WriteLine();
            }
            int opc;
            do
            {
                Buscar();
                Console.Write("¿Buscar otro nombre? [1] Sí, [?] No: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc == 1);
        }
        private static void Buscar()
        {
            Console.Write("¿Qué nombre desea buscar?: ");
            bu = Console.ReadLine();
            ba = false;
            int t = n.Length;
            for (int i = 0; i < t; i++)
            {
                if(string.Compare(n[i], bu) == 0)
                {
                    Console.Clear();
                    Console.Write("¡Nombre encontrado!: "  + bu);
                    Console.WriteLine(", Posición: [" + (i+1) + "]");
                    Console.ReadKey();
                    Console.Clear();
                    ba = true;
                }
            }
            if(ba == false)
            {
                Console.Clear();
                Console.Write("Nombre no encontrado: " + bu);
                Console.ReadKey();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Nombres guardados: ");
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("[" + (i+1) + "]: " + n[i]);
            }
            Ordenar();
        }
        private static void Ordenar()
        {
            Console.WriteLine("Nombres ordenados ascendentemente.");
            int bandera = 1; string aux = " ";
            int N = n.Length;
            for(int paso = 0; paso < (n.Length-1) && bandera == 1; paso++)
            {
                bandera = 0;
                for(int j = 0; j < (N-paso-1); j++)
                {
                    if(string.Compare(n[j], n[j+1]) > 0)
                    {
                        bandera = 1;
                        aux = n[j];
                        n[j] = n[j+1];
                        n[j+1] = aux; 
                    }
                }
            }
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("[" + (i+1) + "]: " + n[i]);
            }
            Console.WriteLine();
        }
    }
}
