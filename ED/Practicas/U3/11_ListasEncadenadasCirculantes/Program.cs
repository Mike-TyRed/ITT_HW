using System;

namespace _11_ListasEncadenadasCirculantes
{
    class Nodo
    {
        public  int dato;
        public  Nodo dir;
    }
    class Program
    {
        static Nodo i;
        static Nodo f;
        static Nodo t;
        static Nodo a;
        static Nodo s;
        public static int Edades;
        public int edad;
        public static int temp;
        public static int Tamaño; 
        static void Main(string[] args)
        {
            f = null;
            i = null;

            Console.Clear();

            Console.Title = "Listas encadenadas circulantes";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Presione una tecla para iniciar el programa");
            Console.ReadKey();
            Console.Clear();

            int opc;

            do
            {
                Console.Clear();

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Inserción ");
                Console.WriteLine("[2] Eliminar  ");
                Console.WriteLine("[3] Recorrer  ");
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
                        Console.Write("Ingrese una edad: ");
                        Edades = Convert.ToInt32(Console.ReadLine());

                        Insertar();
                        Console.WriteLine();
                        Imprimir();

                        Console.WriteLine();

                        Console.Write("¿Ingresar otra edad? [1] Sí, [2] No: ");
                        opc = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                    }while(opc == 1);
                    break;

                    case 2:
                    do
                    {
                        Imprimir();
                        Console.WriteLine("");

                        Console.Write("Eliminar una edad? [1] Sí, [2] No: ");
                        opc = Convert.ToInt32(Console.ReadLine());

                        if(opc == 1)
                        {
                            Console.Write("Ingrese la edad a eliminar: ");
                            Edades = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();
                            Eliminar();
                            Console.WriteLine();
                        }

                        Console.Clear();
                    }while(opc == 1);
                    break;

                    case 3:
                        Imprimir();

                        Console.WriteLine();

                        Console.Write("Presione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    default:
                    opc = 0;
                    break;
                }
            }while(opc != 0);
        }
        public static void Insertar()
        {
            if(Tamaño < 100)
            {
                if( i == null)
                {
                    i = new Nodo();
                    i.dato = Edades;
                    f = i;
                    f.dir = i;
                }
                else
                {
                    t = new Nodo();
                    t.dato = Edades;
                    f.dir = t;
                    f = t;
                    f.dir = i;
                    
                    a = i;
                    s = i.dir;

                    while(Edades > s.dato)
                    {
                        a = s;
                        s = s.dir;
                    }
                }
            }
            Tamaño = Tamaño + 1;
        }
        public static void Eliminar()
        {
            if(Tamaño > -1)
            {
                if(i == null)
                {
                    Console.Write("Lista vacía");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    if(i == f)
                    {
                        if(Edades == i.dato)
                        {
                            temp = i.dato;

                            i = null;
                            f = null;

                            Console.Write("Edad eliminada: " + temp);
                            Console.ReadKey();
                        
                            Tamaño = Tamaño - 1;
                        }
                        else
                        {
                            Console.Write("El dato no existe");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        if(Edades == i.dato)
                        {
                            temp = i.dato;

                            t = i;
                            i = i.dir;
                            t = null;
                            f.dir = i;

                            Console.Write("Edad eliminada: " + temp);
                            Console.ReadKey();

                            Tamaño = Tamaño - 1;
                        }
                        else
                        {
                            if(Edades == f.dato)
                            {
                                temp = f.dato;
                                a = i;
                                s = i.dir;

                                while(s != f)
                                {
                                    a = s;
                                    s = s.dir;
                                }
                                f = a;
                                s = null;
                                f.dir = i;

                                Console.WriteLine("Edad eliminada: " + temp);
                                Console.WriteLine();
                                Console.Write("Pulse una tecla para continuar.");
                                Console.ReadKey();

                                Tamaño = Tamaño - 1;
                            }
                            else
                            {
                                a = i;
                                s = i.dir;
                                while(Edades != s.dato && s != f)
                                {
                                    a = s;
                                    s = s.dir;
                                }
                                if(s == f)
                                {
                                    Console.Write("El dato no existe");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    temp = s.dato;

                                    t = s.dir;
                                    a.dir = t;
                                    s = i;

                                    Console.WriteLine("Edad eliminada: " + temp);
                                    Console.WriteLine();
                                    Console.Write("Pulse una tecla para continuar.");
                                    Console.ReadKey();

                                    Tamaño = Tamaño - 1;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void Imprimir()
        {
            Console.WriteLine("Lista de edades guardadas [" + Tamaño + "]");
            Console.WriteLine("");

            t = i;

            if(i != null)
            {
                a = i;
                s = i.dir;
            }
            else
            {
                a = null;
                s = null;
            }
            if(a == null)
            {
                Console.Write("Lista vacía");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("[" + a.dato + "]");
                while (s != a)
                {
                    Console.Write("[" + s.dato + "]");
                    s = s.dir;
                }
            Console.WriteLine("");
            }
        }
    }
}
