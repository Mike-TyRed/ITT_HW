using System;
using System.Collections.Generic;

namespace _12_ListaEnlazadaSimple_LisT
{
    class Program
    {
        static int Busca;
        static int edad;
        public static List<int> ListaS= new List<int>(50);
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Presione una tecla para comenzar el programa.");
            Console.ReadKey();
            Console.Clear();

            int opc;

            do
            {
                Console.Clear();

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Ingresar ");
                Console.WriteLine("[2] Imprimir  ");
                Console.WriteLine("[3] Eliminar  ");
                Console.WriteLine("[4] Buscar    ");
                Console.WriteLine("[5] Ordenar + ");
                Console.WriteLine("[6] Ordenar - ");
                Console.WriteLine("[7] Conteolist");
                Console.WriteLine("[0] Salir     ");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opc)
                {
                    case 1:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Capacidad de la lista: [" + ListaS.Capacity + "]");
                        Console.WriteLine();

                        Console.Write("Ingresa una edad: ");
                        edad = int.Parse(Console.ReadLine());

                        Ingresar();
                        Console.WriteLine();
                        Imprimir();

                        Console.WriteLine();
                        Console.Write("¿Ingresar otra edad? [1] Sí, [2] No: ");
                        opc = int.Parse(Console.ReadLine());

                    }while(opc == 1);
                    break;

                    case 2:
                        Console.WriteLine("Espacios usados en la lista: [" + ListaS.Count + "]");
                        Console.WriteLine();

                        Imprimir();
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 3:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Espacios usados en la lista: [" + ListaS.Count + "]");
                        Console.WriteLine();

                        //Imprimir();

                        Console.WriteLine();
                        Console.Write("Ingrese la edad a eliminar: ");
                        Busca = int.Parse(Console.ReadLine());

                        Eliminar();

                        Console.WriteLine();
                        Console.Write("Eliminar otra edad? [1] Sí, [2] No: ");
                        opc = int.Parse(Console.ReadLine());
                        
                    }while(opc == 1);
                    break;

                    case 4:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Espacios usados en la lista: [" + ListaS.Count + "]");
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.Write("Ingrese la edad a buscar: ");
                        Busca = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Buscar();

                        Console.WriteLine();
                        Console.Write("Buscar otra edad? [1] Sí, [2] No: ");
                        opc = int.Parse(Console.ReadLine());
                    }while(opc == 1);
                    break;

                    case 5:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Espacios usados en la lista: [" + ListaS.Count + "]");
                        Console.WriteLine("Edades guardados en orden descendente");
                        Console.WriteLine();

                        Mayor();
                        Console.ReadKey();
                        Console.Clear();
                    }while(opc == 1);
                    break;

                    case 6:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Espacios usados en la lista: [" + ListaS.Count + "]");
                        Console.WriteLine("Edades guardados en orden ascendente");
                        Console.WriteLine();

                        Menor();
                        Console.ReadKey();
                        Console.Clear();
                    }while(opc == 1);
                    break;

                    case 7:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Edades actuales en la lista: [" + ListaS.Count + "]");
                        Console.WriteLine();
                        Console.WriteLine("Espacios disponibles: [" + (ListaS.Capacity - ListaS.Count) + "]");
                        Console.ReadKey();
                        Console.Clear();

                    }while(opc == 1);
                    break;

                    default:
                    opc = 0;
                    break;
                }

            }while(opc != 0);
        }
        public static void Ingresar()
        {
            if(ListaS.Count == ListaS.Capacity)
            {
                Console.Write("Lista llena.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                ListaS.Add(edad);
                //ListaS.Sort();
            }
        }
        public static void Imprimir()
        {
            foreach(int x in ListaS)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(ListaS.Count);
        }
        public static void Eliminar()
        {
            if(ListaS.Contains(Busca) == true)
            {
                ListaS.Remove(Busca);
                Console.WriteLine("Edad eliminada de la lista: " + Busca);
            }
            else
                Console.WriteLine("No se encontró la edad buscada: " + Busca);

        }
        public static void Buscar()
        {
            if(ListaS.Contains(Busca) == true)
            {
                Console.WriteLine("Sí se encuentra en la lista: " + Busca);
            }
            else
                Console.WriteLine("No se encontró la edad buscada: " + Busca);
        }
        public static void Mayor()
        {
            ListaS.Sort();
            ListaS.Reverse();
            foreach(int x in ListaS)
            {
                Console.WriteLine(x);
            }
        }
        public static void Menor()
        {
            ListaS.Sort();
            foreach(int x in ListaS)
            {
                Console.WriteLine(x);
            }
        }
        public static void Contador()
        {

        }
    }
}
