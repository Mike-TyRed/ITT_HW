using System;

namespace _4_ShellSort
{
    class Program
    {
        static int opc;
        static int [] nc = new int [40];
        static int x;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Shell Sort Ascendente.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para iniciar.");
            Console.ReadKey();

            Console.Clear();

            Ingresar();
            Imprimir();
            Ordenar();
        }
    static void Ingresar()
    {
        Console.Clear();
        for(x = 0; x < nc.Length; x++)
        {
            Console.Write("Ingrese una matricula: ");
            nc[x] = int.Parse(Console.ReadLine());
        }
    }
    static void Imprimir()
    {
        Console.Clear();
        Console.WriteLine("Orden ingresado.");
        for(int f = 0; f < nc.Length; f++)
        {
            Console.WriteLine("[" + nc[f] + "] ");
        }
        Console.ReadKey();
    }
    static void Ordenar()
    {
        int salto = 0, bandera = 0, auxi = 0, c = 0;
        salto = nc.Length/2;
        while(salto > 0)
        {
            bandera = 1;
            while(bandera != 0)
            {
                bandera = 0;
                c = 1;
                while(c <= (nc.Length - salto))
                {
                    if(nc[c -1] > nc[(c - 1) + salto])
                    {
                        auxi = nc[(c - 1) + salto];
                        nc[(c - 1) + salto] = nc[c -1];
                        nc[(c -1)] = auxi;
                        bandera = 1;
                    }
                    c++;
                }
            }
            salto = salto / 2;
        }
        Console.Clear();
        Console.WriteLine("Ordenado ascendente.");
        for(int f = 0; f < nc.Length; f++)
        {
            Console.WriteLine("[" + nc[f] + "] ");
        }
        Console.ReadKey();
    }
    }
}
