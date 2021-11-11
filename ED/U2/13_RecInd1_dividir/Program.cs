using System;

namespace _13_RecInd1_dividir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa de operación de números por recursividad indirecta";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matriucla: 19211740");

            Console.WriteLine();

            double c = 1;
            double r = 0;

            Console.Write("Ingresa un número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Program Me = new Program();

            Console.Clear();
            Me.Imprimir(x, c, r);
        }
        void Imprimir(double x, double c, double r)
        {
            if(c <= 12)
            {
                r = c/x;
                Console.WriteLine(c + " / " + x + " = " + r);
                c++;
                Imprimir(x, c, r);
            }
        }
    }
}