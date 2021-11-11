using System;
using System.Collections.Generic;

namespace _5_E_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa que muestra como usar HashSet<T> y sus procesos";
            Program Mo = new Program();

            HashSet<string> A = new HashSet<string>();
            HashSet<string> B = new HashSet<string>();

            HashSet<string> Union = new HashSet<string>(A);
            Union.UnionWith(B);

            HashSet<string> Interseccion = new HashSet<string>(A);
            Interseccion.IntersectWith(B);

            Console.WriteLine("Ingresa los valores a los conjuntos A y B");
            Console.WriteLine("¿Cuántos valores desea ingresar al conjunto A?");
            int a = Int32.Parse(Console.ReadLine());

            int x=0;
            for(int i=0; i<a; i++)
            {
                Console.Write("[{0}]", x=x+1);
                string var = Console.ReadLine();
                A.Add(var);
            }

            Console.WriteLine();

            Console.WriteLine("¿Cuántos valores desea ingresar al conjunto B?");
            int b = Int32.Parse(Console.ReadLine());

            int y=0;
            for(int i=0; i<a; i++)
            {
                Console.Write("[{0}]", y=y+1);
                string var1 = Console.ReadLine();
                B.Add(var1);
            }

            Console.WriteLine();

            Console.Write("Impresión ");

            Console.WriteLine();

            Console.Write("Conjunto A: ");
            foreach(string q in A)
            {
                Console.Write(" {0}", q);
            }
            Console.WriteLine();

            Console.Write("Conjunto B: ");
            foreach(string w in B)
            {
                Console.Write(" {0}", w);
            }

            Console.WriteLine();
            
            Console.Write("Unión de A y B: ");
            foreach(string v in Union)
            {
                Console.Write("{0} ", v);
            }
            
            Console.WriteLine();

            Console.Write("Intersección de A y B: ");
            foreach(string v in Interseccion)
            {
                Console.Write("{0} ", v);
            }
        }
    }
}
