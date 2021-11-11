using System;
using System.Collections;

namespace _3_PilasDinamicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa de pilas dinámicas";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            int [] Numeros = new int [100];
            int top = 0, num = 0, t = 0, o = 0, oo = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Tamaño de pila: [" + top + "]");

                Console.WriteLine("----MENU----");
                Console.WriteLine("[1] Insertar");
                Console.WriteLine("[2] Eliminar");
                Console.WriteLine("[3] Imprimir");
                Console.WriteLine("[0] Salir");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                o = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(o)
                {
                    case 1:
                        top = Insertar(Numeros, num, top, oo, t);  
                    break;

                    case 2:
                        top = Eliminar(Numeros, num, top, oo, t);
                    break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("Tamaño de pila: [" + top + "]");
                        Console.WriteLine();

                        for(int i = top-1; i >= 0; i--)
                        {
                            Console.Write("[" + i + "]");
                            Console.WriteLine(Numeros[i]);
                        }

                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                    break;
                }

            }while(o != 0);
        }
        public static bool full(int top)
        {
            if(top == 100)
                return true;
            else
                return false;
        }
        public static bool empty(int top)
        {
            if(top == -1)
                return true;
            else
                return false;
        }
        public static int Insertar(int[] Numeros, int num, int top, int oo, int t)
        {
            Console.WriteLine("Tamaño de pila: [" + (top + 1) + "]");
            Console.Write("¿Desea ingresar un número? [1] Sí, [2] No: ");
            oo = Convert.ToInt32(Console.ReadLine());

            if(oo == 1)
            {
                if(full(top) == true)
                {
                    Console.WriteLine("Pila llena");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();

                    Console.Write("Ingrese un número: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    Numeros[top] = num;
                    top = top + 1;

                    Insertar(Numeros, num, top, oo, t);
                }
            }
            return top;
        }
        public static int Eliminar(int[] Numeros, int num, int top, int oo, int t)
        {
            Console.WriteLine("Tamaño de pila: [" + top + "]");
            Console.Write("¿Desea eliminar un número? [1] Sí, [2] No: ");
            oo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if(oo == 1)
            {
                if(empty(top) == true)
                {
                    Console.WriteLine("Pila vacía");
                    Console.WriteLine();
                }
                else
                {
                    t = Numeros[top-1];
                    Console.WriteLine("El valor eliminado fue: " + t);
                    Numeros[top-1] = 0;
                    top--;

                    Eliminar(Numeros, num, top, oo, t);
                }
            }
            return top;
        }
    }
}
