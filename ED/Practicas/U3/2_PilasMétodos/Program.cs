using System;
using System.Collections.Generic;

namespace PilasMétodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Manejo de pilas estáticas usando métodos";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            string [] Ciudades = new string [50];
            string ciudad, t = " ";
            int top = 0, o = 1, oo;

            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("[1] Inserción");
                Console.WriteLine("[2] Eliminación");
                Console.WriteLine("[3] Imprimir");
                Console.WriteLine("[4] Imprimir el nombre mayor");
                Console.WriteLine("[0] Finalizar programa");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                o = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(o)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese una ciudad [" + (top + 1) + "]: ");
                            ciudad = Console.ReadLine();

                            Console.WriteLine();

                            top = Insertar(Ciudades, top, ciudad);

                            Console.Write("¿Quiere ingresar otra ciudad? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();
                        }while(oo == 1);

                        Console.Clear();
                    break;

                    case 2:
                        do
                        {
                            Console.WriteLine("Tamaño de pila: [" + top + "]");

                            Console.WriteLine();

                            Console.Write("¿Eliminar ciudades? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            if(oo == 1)
                                top = Eliminar(Ciudades, top, t);

                                Console.WriteLine();

                        }while(oo == 1);

                        Console.Clear();
                    break;

                    case 3:
                        Console.WriteLine("Tamaño de la pila: [" + top + "]");

                        Console.WriteLine();

                        Console.WriteLine("Ciudades de mayor a menor son");
                        Imprimir(Ciudades, top);

                        Console.WriteLine();

                        Console.WriteLine("Presiones cualquier tecla para salir");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 4:
                        do
                        {
                            Console.Write("¿Desea obtener la ciudad mayor? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            if(oo == 1)
                            {
                                Program Me = new Program();
                                Me.Mayor(Ciudades, top, t);
                            }
                            
                            Console.WriteLine();

                            Console.WriteLine("Presiones cualquier tecla para salir");
                            Console.ReadKey();
                        }while(00 == 1);

                        Console.Clear();
                    break;

                    default:
                        o = 0;
                    break;
                }
            }
            while(o != 0);
        }
        public static bool full(int top)
        {
            if(top == 50)
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
        public static int Insertar(string[] Ciudades, int top, string ciudad)
        {
            if(full(top) == true)
            {
                Console.WriteLine("Pila llena");
                Console.WriteLine();
            }
            else
            {
                Ciudades[top] = ciudad;
                top = top + 1;
            }
            return top;
        }
        public static int Eliminar(string[] Ciudades, int top, string t)
        {
            if(empty(top) == true)
            {
                Console.WriteLine("Pila vacía");
                Console.WriteLine();
            }
            else
            {
                t = Ciudades[top - 1];
                Console.WriteLine("El valor eliminado fue: " + t);
                Ciudades[top -1] = " ";
                top--;
            }
            return top;
        }
        public static void Imprimir(string[] Ciudades, int top)
        {
            for(int i = top-1; i >= 0; i--)
            {
                Console.Write("[" + i + "] ");
                Console.WriteLine(Ciudades[i]);
            }
        }
        public void Mayor(string[] Ciudades, int top, string t)
        {
            string o = "si";
            int i = 1;
            do
            {
                i++; o = "si";
                for(int j = 0; j < (top-1); j++)
                {
                    if(string.Compare(Ciudades[j], Ciudades[j+1]) > 0)
                    {
                        o = "No";
                        t = Ciudades[j];
                        Ciudades[j] = Ciudades[j+1];
                        Ciudades[j+1] = t;
                    }
                } 
            }while(i < top && o != "si");

            for(int j = (top-1); j > -1; j--)
                Console.WriteLine(Ciudades[j]);
        }
    }
}