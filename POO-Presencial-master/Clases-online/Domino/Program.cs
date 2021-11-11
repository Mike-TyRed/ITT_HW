using System;

namespace Domino
{

    class Domino
    {
        public int numerador;
        public int denominador;

        public Domino(int num, int den)
        {
            numerador = num;
            denominador = den;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", numerador, denominador); 
        }

            public static Domino operator +(Domino x, Domino y)
            {
                return new Domino(x.numerador + y.denominador, x.numerador + y.denominador);
            }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Domino x = new Domino(1,3);
            Domino y = new Domino(2,3);

            Domino z = x + y;

            Console.WriteLine(z);
            //Console.WriteLine(y);
        }
    }
}
