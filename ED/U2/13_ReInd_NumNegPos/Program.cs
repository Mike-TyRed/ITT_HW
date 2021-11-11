using System;

namespace _13_ReInd_NumNegPos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa que verifica si un numero es negativo o positivo";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Ingresa un numero:");
            int n = Convert.ToInt32(Console.ReadLine());

            Program Me = new Program();
            Me.Verificador(n);
        }
        void Verificador(int n)
        {
            if(n == 0)
            {
                Cero(n);
            }
            else if(n >= 1)
            {
                Positivo(n);
            }
            else if(n <= -1)
            {
                Negativo(n);
            }
        }
        void Cero(int n)
        {
            Console.WriteLine("Ingresaste cero");
        }
        void Positivo(int n)
        {
            Console.WriteLine("El numero es positivo: " + n);
        }
        void Negativo(int n)
        {
            Console.WriteLine("El numero es negativo: " + n);
        }
    }
}