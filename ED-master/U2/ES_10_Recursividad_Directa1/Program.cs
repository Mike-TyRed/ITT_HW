using System;

namespace ES_10_Recursividad_Directa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa de Recursividad Directa";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: #19211740");

            Console.Clear();

            Console.WriteLine("Ingresa la cantidad de registros que quieras usar: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int [] a = new int [x];
            int [] b = new int [x];

            for(int c = 0; c < x; c++)
            {
                Console.Write("Registra un número: ");
                a[c] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Registra otro número: ");
                b[c] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            int y = 0;
            
            Console.WriteLine("Lista de números registrados");
            Console.WriteLine("Grupo a | Grupo b");
            Imprimir(a, b, x, y);
        }

        static void Imprimir(int[] a, int[] b, int x, int y)
        {
            if(y < x)
            {
                Console.WriteLine("     " + a[y] + "      " + b[y]);
                y++;

            Imprimir(a, b, x, y);         
            }
            else
                Console.WriteLine("Método recursivo finalizado");
        }
    }
}