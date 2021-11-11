using System;

namespace _3_Hashing
{
    class Program
    {
        static Random r = new Random();
        static int [] Cl = new int [6];
        static int [] Ll = new int [6];
        static int t = 0, i = 0, c = 0;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Metodo Hash aritmética modular.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar.");
            Console.ReadKey();
            
            Console.Clear();

            int opc = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("-----------MENU-----------");
                Console.WriteLine("Generar claves         [1]");
                Console.WriteLine("Mostrar claves         [2]");
                Console.WriteLine("Asignar índices        [3]");
                Console.WriteLine("Mostrar nuevos índices [4]");
                Console.WriteLine("Finalizar programa     [5]");
                Console.WriteLine();
                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opc)
                {
                    case 1:
                    for (int j = 0; j < Cl.Length; j++)
                    {
                        Cl[j] = r.Next(100, 1500);
                    }
                    Console.Write("Claves generadas, presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                    case 2:
                    Console.WriteLine("Claves generadas.");
                    for (int k = 0; k < Cl.Length; k++)
                    {
                        Console.WriteLine("[" + (k+1) + "] " + Cl[k]);
                    }
                    Console.Write("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                    case 3:
                    Asignar();
                    Console.Write("Índices asignados, presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                    case 4:
                    Buscar();
                    break;

                    case 5:
                    opc = 5;
                    break;

                    default:
                    Console.Write("Error, ingrese una de las opciones dadas.");
                    Console.ReadKey();
                    break;
                }
            } while (opc != 5);
        }
        private static void Asignar()
        {
            t = Cl.Length - 1;
            for (int l = 0; l <= t; l++)
            {
                i = (Cl[l] % t) + 1;
                while (Ll[i] != 0)
                {
                    c = i + 1;
                    if(c > t)
                        i = 0;
                    else
                        i = c;
                }
                Ll[i] = Cl[l];
            }
        }
        private static void Buscar()
        {
            t = Ll.Length - 1;
            Console.WriteLine("Claves con índices asignados.");
            for (int m = 0; m < Ll.Length; m++)
            {
                Console.WriteLine("[" + (m+1) + "]" + Ll[m]);
            }
            Console.WriteLine();
            Console.Write("Ingrese la clave que desee buscar: ");
            int b = int.Parse(Console.ReadLine());

            i = (b % t) + 1;

            if(Ll[i] == b)
            {
                Console.WriteLine("El elemento está en la posición: " + (i + 1));
                Console.ReadKey();
            }
            else
            {
                c = i + 1;
                while (c <= t && Ll[c] != b && Ll[c] != 0 && c != i)
                {
                    c = c + 1;
                    if(c > t)
                        c = 0;
                }
                if(Ll[c] == b)
                    Console.WriteLine("El elemento " + b + "está en la posición " + b, (c +1));
                else
                    Console.WriteLine("El elemento" + b + "no se encuentra en el arreglo: ");

                Console.ReadKey();
            }
        }
    }
}