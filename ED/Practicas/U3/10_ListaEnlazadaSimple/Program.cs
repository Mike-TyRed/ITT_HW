using System;
namespace _10_ListaEnlazadaSimple
{
    class Nodo
    {
        public int dato;
        public Nodo dir;
    }
    class Program
    {
        static Nodo i;
        static Nodo f;
        static Nodo t;
        static int temp;
        static int calf;
        public static int tamaño = 0;
        static int opc = 0;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Usando listas enlazadas simples";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            f = null;
            i = null;

            Console.WriteLine();

            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Insertar  ");
                Console.WriteLine("[2] Eliminar  ");
                Console.WriteLine("[3] Imprimir  ");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opc)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese un numero: ");
                            calf = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            Insertar();

                            Imprimir();

                            Console.Write("¿Ingresar otra calificación? [1] Sí, [2] No: ");
                            opc = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                        }while(opc == 1);
                    break;

                    case 2:
                        do
                        {
                            Imprimir();

                            Eliminar();

                            Console.WriteLine("¿Eliminar dato? [1] Sí, [2] No: ");
                            opc = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                        }while(opc == 1);
                    break;

                    case 3:
                        Console.WriteLine("Calificaciones guardadas");
                        Console.WriteLine("");

                        Imprimir();

                        Console.Write("Presione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                    break;
                }
            }while(opc != 0);
        }
        public static void Insertar()
        {
            if(tamaño < 100)
            {
                if( i == null)
                {
                    i = new Nodo();
                    i.dato = calf;
                    f = i;
                    f.dir = null;

                    tamaño = tamaño + 1;
                }
                else
                {
                    t = new Nodo();
                    t.dato = calf;
                    f.dir = t;
                    f = t;
                    f.dir = null;

                    tamaño = tamaño + 1;
                }
            }
        }
        public static void Eliminar()
        {
            if(tamaño > -1)
            {
                if(i == null)
                {
                    Console.Write("Lista vacía");
                    Console.ReadKey();
                    Console.Clear();

                    tamaño = tamaño - 1;
                }
                else
                {
                    temp = i.dato;
                    t = i;
                    i = i.dir;

                    tamaño = tamaño - 1;
                }
            }
        }
        public static void Imprimir()
        {
            Console.WriteLine("Lista de calificaciones [" + tamaño + "] guardadas");
            Console.WriteLine("");

            t = i;

            while (t != null)
            {
                Console.Write("[" + t.dato + "]");
                t = t.dir;
            }
            Console.WriteLine("");
        }
    }
}
