using System;

namespace _12_RecDir3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa que suma números naturales recursivamente";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            int [] e = new int [20];
            int [] m = new int [20];

            Console.WriteLine();

            for(int v = 0; v < 20; v++)
            {
                Console.Write("Ingresa una edad: ");
                e[v] = Convert.ToInt32(Console.ReadLine());
            } 
            int c = 0, r = 0;
            Program Me = new Program();

            Console.Clear();

            Console.WriteLine("Las edades mayores de edad son:");
            Me.Edades(e, m, c, r);
        }
        void Edades(int[] e, int[] m, int c, int r)
        {
            if(c < 20)
            {
                if(e[c] >= 18)
                {
                    m[c] = e[c];
                    c++;
                    Edades(e, m, c, r);
                }
                else
                {
                    c++;
                    Edades(e, m, c, r);
                }
            }
            else
            {
                if(r < 20)
                {
                    if(m[r] != 0)
                    {
                        Console.WriteLine(m[r]);
                        r++;
                        Edades(e, m, c, r);
                    }
                    else
                    {
                        r++;
                        Edades(e, m, c, r);
                    }
                }
            }
        }
    }
}