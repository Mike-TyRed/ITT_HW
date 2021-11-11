using System;

namespace _6_ColaDoble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manejo de cola doble";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();

            string [] Nombres = new string [100];
            Program Me = new Program();

            string name = " ";
            string Lado = null;

            int izq = 0;
            int der = 0;

            string opc;
            int o, inicio = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("----MENU----");
                Console.WriteLine("[1] Insertar");
                Console.WriteLine("[2] Eliminar");
                Console.WriteLine("[3] Imprimir");
                Console.WriteLine("[0] Salir");

                Console.WriteLine();

                Console.Write("Ingrese la opción que desea: ");
                o = Convert.ToInt32(Console.ReadLine());

                switch(o)
                {
                    case 1:
                        do
                        {
                            Console.Clear();

                        Console.Write("Ingrese un nombre: ");
                        name = Console.ReadLine();

                        Console.Write("Ingresar por [1] Izquierda [2] Derecha: ");
                        Lado = Console.ReadLine();

                        if(inicio == 0)
                        {
                            inicio = 100/2;
                            izq = inicio - 1;
                            der = inicio + 1;

                            Nombres[inicio] = name;
                        }
                        else if(Lado.Equals("1"))
                        {
                            izq = InsertarI(izq, Nombres, name);
                        }
                        else
                        {
                            der = InsertarD(der, Nombres, name);
                        }

                        Console.Write("Ingresar otro nombre? [2] Si, [2] No ");
                        opc = Console.ReadLine();

                        Console.Clear();

                        }while(opc.Equals("1"));
                    break;

                    case 2:
                        do
                        {
                            Console.Clear();

                            Console.Write("Lado por eliminar [1] Izquierda o [2] Derecha ");
                            Lado = Console.ReadLine();

                            if(Lado.Equals("1"))
                            {
                                if(izq == (50 - 1))
                                {
                                    Console.WriteLine("Cola vacia");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    izq = EliminarI(izq, Nombres, name, der);
                                }
                            }
                            else
                            {
                                if(der == 0)
                                {
                                    Console.WriteLine("Cola vacia");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    der = EliminarD(der, Nombres, name, izq);
                                }
                            }
                            Imprimir(Nombres);
                            Console.Write("Eliminar otro nombre? [2] Si, [2] No");
                            opc = Console.ReadLine();
                            

                        }while(opc.Equals("1"));
                    break;

                    case 3:
                        Console.Clear();

                        Imprimir(Nombres);

                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                    break; 

                    default:
                    Console.Clear();
                    o = 0;
                    break;
                }
            }while(o != 0);
        }
        public static int InsertarI(int izq, string[] Nombres, string name)
        {
            if(izq < 0)
            {
                Console.WriteLine("Cola izquierda llena");
                Console.WriteLine();
            }
            else
            {
                Nombres[izq] = name;
                izq = izq + 1;
            }
            return izq;
        }
        public static int InsertarD(int der, string[] Nombres, string name)
        {
            if(der < 0)
            {
                Console.WriteLine("Cola derecha llena");
                Console.WriteLine();
            }
            else
            {
                Nombres[der] = name;
                der = der + 1;
            }
            return der;
        }
        public static void Imprimir(string[] Nombres)
        {
            Console.WriteLine("Estado actual");
            Console.WriteLine();

            for(int a = 0; a < 100; a++)
            {
                Console.WriteLine("|" + Nombres[a] + "|");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static int EliminarI(int izq,string[] Nombres,string name,int der)
        {
            Nombres[izq + 1] = null;
            izq = izq + 1;

            if(izq == der)
            {
                izq = 50;
            }

            return izq;
        }
        public static int EliminarD(int der,string[] Nombres,string name,int izq)
        {
            Nombres[der - 1] = " ";
            der = der -1;

            if(izq == der)
            {
                der = 0;
            }
            return der;
        }
    }
}
