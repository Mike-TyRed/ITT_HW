using System;

namespace examen
{
    class N_mayor
    {
        static int o;
        static int mayor;
        static int [] Sueldos = new int [5];
        public int Smayor()
        {
            if(o<5)
            {
                Console.Write("ingrese un sueldo: ");
                Sueldos[o] = Int32.Parse(Console.ReadLine());

                if(mayor <= Sueldos[o])
                {
                    mayor = Sueldos[o];
                    o++;
                    return Smayor();
                }
                else
                {
                    o++;
                    return Smayor();
                }
            } 
            return mayor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            N_mayor obj = new N_mayor();
            Console.WriteLine(obj.Smayor());
        }
    }
}
