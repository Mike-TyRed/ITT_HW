using System;

namespace Ejemplo
{
    class Multi
    {
        public static void Mult(ref int x)
        {
            x++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            Multi.Mult(ref y);
            Console.WriteLine(y);
        }
    }
}
