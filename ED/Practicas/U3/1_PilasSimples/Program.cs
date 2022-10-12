using System;

namespace PilasSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa de pilas estáticas";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine("");

            int [] edades = new int [50];
            int top = 0, ward = 0;

            Console.WriteLine("Ingreso de edades");
            Console.Write("¿Deseas agregar una edad? [1] Sí, [2] No ");
            int o = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Clear();
            
            while(o == 1)
            {
                Console.Write("Ingresa una edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(top < 50)
                {
                    edades[top] = edad;
                    top++;
                }
                else
                {
                    Console.WriteLine("Pila llena");
                    break;
                }

                Console.Write("¿Ingresará otra edad? [1] Sí, [2] No ");
                o = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();

            Console.Write("¿Imprimir todas las edades? [1] Sí, [2] No ");
            o = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();

            if(o == 1)
            {
                Console.WriteLine("Todas las edades registradas");
                for(int x = top -1; x >= 0; x--)
                {
                    Console.WriteLine(edades[x]);
                }
            }
            else
            {
                Console.WriteLine("Presione una tecla para continuar: ");
                Console.ReadKey();
            }

            Console.WriteLine("Presione una tecla para continuar: ");
            Console.ReadKey();

            Console.Clear();

            Console.Write("¿Eliminar edades registradas? [1] Sí, [2] No ");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (o == 1)
            {
                if(top > 0)
                {
                    top--;
                    ward = edades[top];
                    edades[top] = 0;
                    Console.WriteLine("La edad eliminada fue: " + ward);
                }
                else
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }

                Console.Write("¿Quiere eliminar otra edad? 1] Sí, [2] No ");
                o = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}