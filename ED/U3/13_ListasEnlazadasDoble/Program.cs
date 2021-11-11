using System;

namespace _13_ListasEnlazadasDoble
{
    class Nodo
    {
        public string Dato;
        public Nodo DirDer;
        public Nodo DirIzq;
    }
    class Program
    {
        static Nodo i;
        static Nodo f;
        static Nodo t;
        static Nodo s;
        static Nodo a;
        static public string Temp;
        static public string Nombre;
        public static int Tamaño = 1;
        static int opc = 0;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Lista enlazada doble.";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Presione una tecla para iniciar el programa.");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.Clear();

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Ingresar  ");
                Console.WriteLine("[2] Imprimir  ");
                Console.WriteLine("[3] Eliminar  ");
                Console.WriteLine("[0] Salir     ");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());
                
                Console.Clear();
                switch(opc)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese un nombre: ");
                            Nombre = Console.ReadLine();

                            Ingresar();

                            Console.WriteLine();

                            Console.Write("¿Ingresar otro nombre? [1] Sí, [2] No: ");
                            opc = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                        }while(opc == 1);
                    break;

                    case 2:
                        Console.WriteLine("Nombres guardados hata ahora.");
                        Console.WriteLine();

                        ImprimirI();
                        Console.WriteLine();
                        ImprimirD();

                        Console.WriteLine();
                        Console.Write("Presione una tecla para continuar.");
                        Console.ReadKey();
                    break;

                    case 3:
                        do
                        {
                            Console.Write("¿Eliminar nombres? [1] Sí, [2] No: ");
                            opc = int.Parse(Console.ReadLine());

                            if(opc == 1)
                            {
                                Console.Write("Ingrese el dato que quiera eliminar: ");
                                Nombre = Console.ReadLine();

                                Eliminar();

                                ImprimirI();
                                Console.WriteLine();
                                ImprimirD();
                            }
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
            if(i == null)
            {
                i = new Nodo();
                i.Dato = Nombre;
                f = i;
                f.DirDer = null;
                i.DirIzq = null;
            }
            else
            {
                if(string.Compare(Nombre, i.Dato) == -1) // O =, 1 >, -1 <
                {
                    t = new Nodo();
                    t.Dato = Nombre;
                    t.DirDer = i;
                    i.DirIzq = t;
                    i = t;
                    t.DirIzq = null;
                }
                else
                {
                    if(string.Compare(Nombre, f.Dato) == 1)
                    {
                        t = new Nodo();
                        t.Dato = Nombre;
                        t.DirIzq = f;
                        f.DirDer = t;
                        f = t;
                        f.DirDer = null;
                    }
                    else
                    {
                        if(string.Compare(Nombre, i.Dato) == -1)
                        {
                            t = new Nodo();
                            t.Dato = Nombre;
                            t.DirDer = i;
                            i.DirIzq = t;
                            i = t;
                            t.DirIzq = null;
                        }
                        else
                        {
                            if(string.Compare(Nombre, f.Dato) == 1)
                            {
                                t = new Nodo();
                                t.Dato = Nombre;
                                t.DirIzq = f;
                                f.DirDer = t;
                                f = t;
                                f.DirDer = null;
                            }
                            else
                            {
                                a = i;
                                s = i.DirDer;

                                while(string.Compare(Nombre, s.Dato) == 1)
                                {
                                    a = s;
                                    s = s.DirDer;
                                }

                                t = new Nodo();
                                t.Dato = Nombre;
                                t.DirIzq = a;
                                a.DirDer = t;
                                t.DirDer = s;
                                s.DirIzq = t;
                            }
                        }
                    }
                }
                Tamaño = Tamaño + 1;
            }
        }
        public static void ImprimirD()
        {
            Console.WriteLine("Total de espacios: [" + Tamaño + "]");
            Console.WriteLine("Ordenado ascendentemente.");

            if(Tamaño == 0)
                Console.Write("Lista vacía.");
                Console.ReadKey();

            t = f;

            Console.WriteLine();

            while(t != null)
            {
                Console.Write("[" + t.Dato + "]");
                t = t.DirIzq;
            }
            Console.WriteLine();
        }
        public static void ImprimirI()
        {
            Console.WriteLine("Total de espacios: [" + Tamaño + "]");
            Console.WriteLine("Ordenado descendentemente");

            if(Tamaño == 0)
                Console.Write("Lista vacía.");
                Console.ReadKey();

            t = i;

            Console.WriteLine();

            while(t != null)
            {
                Console.Write("[" + t.Dato + "]");
                t = t.DirDer;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void Eliminar()
        {
            if(i == null)
            {
                Console.Write("Lista vacía.");
                Console.ReadKey();
            }
            else if(i == f)
            {
                if(Nombre == i.Dato)
                {
                    Temp = i.Dato;
                    i = null;
                    f = null;

                    Tamaño = Tamaño - 1;
                }
                else
                {
                    Console.Write("El dato no existe.");
                    Console.ReadKey();
                }
            }
            else if(Nombre == i.Dato)
            {
                Temp = i.Dato;
                t = i;
                i = i.DirDer;
                i.DirIzq = null;

                Console.WriteLine("Nombre eliminado exitosamente: " + Nombre);
                Tamaño = Tamaño - 1;
            }
            else
            {
                a = i;
                s = i.DirDer;
                while(Nombre != s.Dato && s != f)
                {
                    a = s;
                    s = s.DirDer;
                }

                if(s == f)
                {
                    Console.Write("El dato no existe.");
                    Console.ReadKey();
                }
                else
                {
                    Temp = s.Dato;
                    t = s.DirDer;
                    t.DirIzq = a;
                    a.DirDer = t;

                    Console.WriteLine("Nombre eliminado exitosamente: " + Nombre);
                    Tamaño = Tamaño - 1;
                }
            }
        }
    }
}