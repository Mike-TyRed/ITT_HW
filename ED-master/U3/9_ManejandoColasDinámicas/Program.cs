using System;
using System.Collections;

namespace _9_ManejandoColasDinámicas
{
    class Program
    {
        static int i;
        static int f;
        static Queue Calfs = new Queue();
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Manejo de Colas Circulares de manera estática";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            int c = 0, otro = 0;
            int opc;

            Console.Clear();

            do
            {
                Console.Clear();

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Insertar  ");
                Console.WriteLine("[2] Eliminar  ");
                Console.WriteLine("[3] Recorrer  ");
                Console.WriteLine("[4] Buscar "   );
                Console.WriteLine("[?] Salir     ");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opc)
                {
                    case 1:
                    Console.Clear();
                        do
                        {
                            Console.Write("Ingrese calificación: ");
                            c = Convert.ToInt32(Console.ReadLine());

                            f = Insertar(c);

                            Console.Write("Ingresar otra calificación? [1] Sí, [2] No: ");
                            opc = Convert.ToInt32(Console.ReadLine());

                        }while(opc == 1);
                    break;

                    case 2:
                    Console.Clear();
                        {
                            do
                            {
                                i = Eliminar();

                                Console.Write("¿Eliminar calificación? [1] Sí, [2] No: ");
                                opc = Convert.ToInt32(Console.ReadLine());
                            }while(opc == 1);   
                        }
                    break;
                    case 3:
                    Console.Clear();

                            Imprimir();

                            Console.WriteLine();
                            Console.Write("Presione una tecla para salir");
                            Console.ReadKey();
                    break;

                    case 4:
                    Console.Clear();
                        do
                        {
                            Console.Write("Ingrese la calificación que desea encontrar: ");
                            otro = Convert.ToInt32(Console.ReadLine());

                            otro = Buscar(otro);
                            Console.WriteLine(otro);

                            Console.WriteLine();
                            Console.Write("¿Buscar otra calificación? [1] Sí, [2] No: ");
                            opc = Convert.ToInt32(Console.ReadLine());

                        }while(opc == 1);
                    break;

                    default:
                    opc = 0;
                    break;
                }
            }while(opc != 0);
        }
        public static int Insertar(int c)
        {
            if(f >= 100)
            {
                Console.WriteLine("Cola llena");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                f = f + 1;
                Calfs.Enqueue(c);
            }
            if(i == 0)
                i = 0;
            
            return f;
        }
        public static int Eliminar()
        {
            if(i == -1)
            {
                Console.Write("Único elemento eliminado: {0}", Calfs.Peek());
                Calfs.Dequeue();
                i = 0;
                f = -1;

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                    Console.WriteLine("Elemento eliminado {0}", Calfs.Dequeue());
                    i = 0;
                    f = -1;

                    Console.ReadKey();
            }
            return i;
        }
        public static int Buscar(int otro)
        {
            if(Calfs.Contains(otro) == true)
            {
                Console.Write("Sí se encontró: ");
            }
            else
            {
                Console.Write("No se encontró: ");
            }
            return otro;
        }
        public static void Imprimir()
        {
            foreach(int valor in Calfs)
                Console.WriteLine(valor);
        }
    }
}
