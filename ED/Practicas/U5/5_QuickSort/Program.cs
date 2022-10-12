using System;
namespace _5_QuickSort
{
    class Program
    {
        static int [] edades = new int [10];
        static int pivote;
        static int i;
        static int j;
        static int temp;
        static int c;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Quick Sort Ascendente.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para iniciar.");
            Console.ReadKey();

            Console.Clear();

            Ingresar();
            Imprimir();
            Ordenar(edades, 0, edades.Length - 1);
        }
        static void Ingresar()
        {
            Console.Clear();
            for(int x = 0; x < edades.Length; x++)
            {
                Console.Write("Ingrese una edad: ");
                edades[x] = int.Parse(Console.ReadLine());
            }
        }
        static void Imprimir()
    {
        Console.Clear();
        Console.WriteLine("Orden ingresado.");
        for(int f = 0; f < edades.Length; f++)
        {
            Console.Write("[" + edades[f] + "] ");
        }
        Console.ReadKey();
    }
        static void Ordenar(int [] edades, int first, int last)
        {
            c = (first + last)/2;
            pivote = edades[c];
            i = first;
            j = last;
            do
            {
                while(edades[i] < pivote) i = i + 1;
                while(edades[j] > pivote) j = j - 1;
                if(i <= j)
                {
                    temp = edades[i];
                    edades[i] = edades[j];
                    edades[j] = temp;
                    i = j + 1;
                    j = i - 1;
                }
            }while(i <= j);

            if(first < j)
                {Ordenar(edades, first, j);}

            if(i < last)
                {Ordenar(edades, i, last);}

            Console.Clear();
            Console.WriteLine("Quick Sort orden ascendente.");
            for(int f = 0; f < edades.Length; f++)
            {
                Console.Write("[" + edades[f] + "] ");
            }
            Console.ReadKey();
        }
    }
}
