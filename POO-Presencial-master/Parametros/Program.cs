using System;

namespace Parametros
{
    class Prueba
    {
        public static void SumaUno(ref int x)
        {
            x = x + 1;
            Console.WriteLine(x);
        }
        public static void Suma(in int a, in int b, out int c)
        {
            c = a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 10, c;
            Prueba.SumaUno(ref a);
            Console.WriteLine(a);
            Prueba.Suma(in a, in b, out c);
            Console.WriteLine(c);

        }
    }
}
