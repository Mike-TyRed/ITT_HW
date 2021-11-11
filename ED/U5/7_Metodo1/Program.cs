using System;

namespace _7_Metodo1
{
    class Program
    {
        static int [] Calfs = new int [30];
        static Random r = new Random();
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

            for(int x = 0; x < Calfs.Length; x++)
            {
                Console.Write("Ingresa una calificación: ");
                Calfs[x] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Calificaciones por orden de ingreso.");
            foreach (int x in Calfs)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            Ordenar();
        }
        private static void Ordenar()
        {
            int n = 30;
            int i, j, Izq, Der, Mid, ax;

            for(i = 1; i < n; i++)
            {
                ax = Calfs[i];
                Izq = 0;
                Der = i - 1;
                while(Izq <= Der)
                {
                    Mid = (Izq + Der) / 2;
                    if(ax <= Calfs[Mid])
                        Der = Mid - 1;
                    else
                        Izq = Mid + 1;
                }
                j = i - 1;
                while(j >= Izq)
                {
                    Calfs[j+1] = Calfs[j];
                    j--;
                }
                Calfs[Izq] = ax;
            }
            Console.Clear();

            Console.WriteLine("Calificaciones ordenadas por intercalación simple método 1.");
            foreach (int x in Calfs)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
