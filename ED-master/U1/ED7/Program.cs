using System;

namespace ED7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title="Uso de módulos";
            Console.WriteLine("Modularidad y estructuras simples");
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Program Me = new Program();
            Console.Write("Ingresa una frase: ");
            string F = Console.ReadLine();

            Me.Impresion(F);
        }

        void Impresion(String F)
        {
            Console.Clear();
            Console.WriteLine("La frase es: {0}", F);
            Console.WriteLine();
            
            int L = F.Length;
            Console.WriteLine("Tamaño de la frase es de: {0}", L);
            Console.WriteLine();
            
            int x=0;
            Console.WriteLine("Separada por espacios: ");
            
            char d = ' ';
            string[] v = F.Split(d);
            foreach(string p in v)
            {
                Console.Write("[{0}]", x=x+1);
                Console.WriteLine(p);
            }
        }
    }
}
