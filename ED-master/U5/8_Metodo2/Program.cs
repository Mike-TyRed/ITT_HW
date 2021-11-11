using System;

namespace _8_Metodo2
{
    class Program
    {
        static int [] A1 = new int [12];
        static int [] A2 = new int [10];
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Manejo del método uno de intercalación simple.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para iniciar.");
            Console.ReadKey();

            Console.Clear();

            for(int x = 0; x < A1.Length; x++)
            {
                Console.Write("Ingresa un sueldo " + "["+ (x+1) + "]: ");
                A1[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int x = 0; x < A2.Length; x++)
            {
                Console.Write("Ingresa otro sueldo " + "["+ (x+1) + "]: ");
                A2[x] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Primeros 12 sueldos");
            foreach (int x in A1)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("10 sueldos siguientes");
            foreach (int x in A2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

            Console.Clear();

            Ordenar();
        }
        private static void Ordenar()
        {
            int t;
            for(int a = 1; a < A1.Length; a++)
            {
                for(int b = (A1.Length-1); b >= a; b--)
                {
                    if(A1[b - 1] > A1[b])
                    {
                        t = A1[b-1];
                        A1[b - 1] = A1[b];
                        A1[b] = t;
                    }
                }
            }
            Ordenar2();
        }
        private static void Ordenar2()
        {
            int i, j, Izq, Der, Mid, ax;

            for(i = 1; i < A2.Length; i++)
            {
                ax = A2[i];
                Izq = 0;
                Der = i - 1;
                while(Izq <= Der)
                {
                    Mid = (Izq + Der) / 2;
                    if(ax <= A2[Mid])
                        Der = Mid - 1;
                    else
                        Izq = Mid + 1;
                }
                j = i - 1;
                while(j >= Izq)
                {
                    A2[j+1] = A2[j];
                    j--;
                }
                A2[Izq] = ax;
            }
            Metodo2();
        }
        private static void Metodo2()
        {
            int a = A1.Length;
            int b = A2.Length;
            int [] A3 = new int [a+b];

            int i = 0, j = 0, k = 0;

            while (i < a && j < b)
            {
                if(A1[i] <= A2[j])
                {
                    A3[k] = A1[i];
                    i = i + 1;
                }
                else
                {
                    A3[k] = A2[j];
                    j = j + 1;
                }
                k = k + 1; 
            }
            if(i == a)
            {
                for(int p = 0; p == j; p++)
                {
                    A3[k] = A2[p];
                    k = k + 1;
                }
            }
            else
            {
                for (int p = 0; p == i; p++)
                {
                    A3[k] = A1[p];
                    k = k + 1;
                }
            }
            Imprimir(A3);
        }
        private static void Imprimir(int [] A3)
        {
            Console.WriteLine("Primer arreglo ordenado ascendentemente.");
            foreach (int x in A1)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Segundo arreglo ordenado ascendentemente.");
            foreach (int x in A2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Tercer arreglo ordenado ascendentemente.");
            foreach (int x in A3)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
