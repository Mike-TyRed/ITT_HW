using System;

namespace _2_BusquedaBinaria
{
    class Program
    {
        static int [] n = new int [20];
        static int [] n2 = new int [n.Length];
        static int Bu;
        static bool Ba;
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

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("Ingrese un número de empleado [" + (i+1) + "]: ");
                n[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n2.Length; j++)
            {
                n2[j] = n[j];
            }

            Ordenar();

            int opc;
            do
            {

                Console.Write("¿Buscar otro número? [1] Sí, [2] No: ");
                opc = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (opc == 1);
        }
        private static void Ordenar()
        {
            int t;
            for(int a = 1; a < n.Length; a++)
            {
                for(int b = (n.Length-1); b >= a; b--)
                {
                    if(n[b - 1] > n[b])
                    {
                        t = n[b-1];
                        n[b - 1] = n[b];
                        n[b] = t;
                    }
                }
            }
        }
        private static void Buscar()
        {
            int M, L = 0, Li = 0, Ls = n.Length;
            bool E = false;

            Console.Write("Ingrese el número que desea buscar: ");
            Bu = int.Parse(Console.ReadLine());

            if (Bu >= 100 && Bu <= 300)
            {
                while (L <= Ls && E != true)
                {
                    M = (Li + Ls) / 2;
                    if(n[M] == Bu)
                    {
                        L = M;
                        E = true;
                    }
                    else
                    {
                        if(Bu > n[M])
                            Li = M + 1;
                        else
                            Ls = M -1;
                    }
                }
                if(E == true)
                {
                    Console.WriteLine("El número " + Bu + " sí corresponde a un empleado, estando en la posición: " + L);
                    Console.WriteLine();
                    Imprimir();
                }
                else
                {
                    Console.WriteLine("El número ingresado no se encuentra:" + Bu);
                    Console.WriteLine();
                    Imprimir();
                }
            }
            else
                Console.WriteLine("El número no se encuentra entre el rango, intente de nuevo.");
                Console.WriteLine();
                Imprimir();
        }
        private static void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("Lista de números en orden de entrada.");
            foreach (int x in n2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Lista ordenada ascendentemente.");
            foreach (int y in n)
            {
                Console.WriteLine(y);
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}