using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapecio
{
    class Program
    {
        public static double FunX(double x)
        {
            return Math.Exp(-3.5 * x) * Math.Sin(5 * x) + 10;
        }
        public static double IncFun(double inf, double sup, int subdiv)
        {
            return (sup - inf) / subdiv;
        }

        public static double Iteración(double inf, int ind, double inc)
        {
            return inf + ind * inc;
        }
        public static double AreaMedio(double inf, double subdiv, double inc)
        {
            double A = 0;
            for (int i = 1; i <= subdiv - 1; i++)
                A = A + FunX(Iteración(inf, i, inc));
            A = 2 * A;
            return A;
        }
        public static double ArInt(double inf, double sup, double subdiv, double inc)
        {
            const float m = 0.5f;
            return m * inc * (FunX(inf) + AreaMedio(inf, subdiv, inc) + FunX(sup));
        }

        static void Main(string[] args)
        {
            double a = 2.31;
            double b = 7.7;
            int n = 9;
            int c = 3;

            double dv = IncFun(a,b,n);
            double valint = ArInt(a,b,n,dv);

            Console.Title = "Integral método del trapecio";
            Console.WriteLine("Integral:");
            Console.WriteLine("Integral de f(x): {0}", valint);
            Console.WriteLine("Redondeado es: {0}", Math.Round(valint, c));
            Console.WriteLine();
            Console.Write("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
