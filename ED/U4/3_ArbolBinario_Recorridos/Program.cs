using System;

namespace _3_ArbolBinario_Recorridos
{
    class Program
    {
        public static Arbol raiz;
        public static Arbol t;
        public static Arbol t2;
        public static Arbol re;
        public static int b = 0;
        public static string x;
        public class Arbol
        {
            public string dato;
            public Arbol ramader;
            public Arbol ramaizq;
        }
        public static int Opcion = 0;
        public static string Otro = null;
        public static string Eleccion = null;
        
        static void Main(string[] args)
        {
            Console.Clear();

            raiz = null;

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Materia: 19211740");
            Console.WriteLine();
            Console.Write("Iniciar programa.");
            Console.ReadKey();
            Console.Clear();
            int opc;

            do
            {
                Console.Clear();

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Insertar  ");
                Console.WriteLine("[2] R.Prefijo ");
                Console.WriteLine("[3] R.Infijo  ");
                Console.WriteLine("[4] R.Posfijo ");
                Console.WriteLine("[0] Salir     ");
                Console.WriteLine();
                Console.Write("Ingresa una opción: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        InsertarArbol(opc);
                        Console.WriteLine();
                break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Recorrido por PreFijo.");
                    re = raiz;
                    PreFijo(re);
                    Console.ReadKey();
                break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Recorrido por Infijo.");
                    re = raiz;
                    InFijo(re);
                    Console.ReadKey();
                break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Recorrido por PostFijo.");
                    re = raiz;
                    PostFijo(re);
                    Console.ReadKey();
                break;

                default:
                    opc = 0;
                break;
                }

            } while (opc != 0);
        }

        public static void InsertarArbol(int opc)
        {
            try
            {
                do
                {
                    Console.Write("Ingrese nombre: ");
                    x = Console.ReadLine();

                    Insertar();
                    re = raiz;
                    Console.WriteLine();
                    Console.Write("¿Ingresar otro nombre? [1] Sí, [2] No: ");
                    opc = int.Parse(Console.ReadLine());

                    Console.Clear();
                }while(opc==1);
            }
            catch(Exception)
            {
                Console.Write("Solo puede engresar nombres, vuelva a intentarlo.");
                Console.ReadKey();
            }
        }
        public static void Insertar()
        {
            if(raiz == null)
            {
                raiz = new Arbol
                {
                    dato = x,
                    ramader = null,
                    ramaizq = null
                };
                    Console.WriteLine("Dato guardado.");
            }
            else
            {
                b = 0;
                t = raiz;
                do
                {
                    if(string.Compare(x, t.dato) >= 0)
                    {
                        if(t.ramader == null)
                        {
                            t2 = new Arbol
                            {
                                dato = x,
                                ramader = null,
                                ramaizq = null
                            };
                            raiz.ramader = t2;
                            b = 1;
                        }
                        else
                        {
                            t = t.ramader;
                        }
                    }
                    else
                    {
                        if(t.ramaizq == null)
                        {
                            t2 = new Arbol
                            {
                                dato = x,
                                ramader = null,
                                ramaizq = null
                            };
                            t.ramaizq = t2;
                            b = 1;
                        }
                        else
                            t = t.ramaizq;
                    }
                }while(b==0);
                Console.WriteLine("Dato guardado.");
            }
        }
        static void PreFijo(Arbol re)
        {
            if(re != null)
            {
                Console.Write(re.dato + " ");
                PreFijo(re.ramaizq);
                PreFijo(re.ramader);
            }
        }
        public static void InFijo(Arbol re)
        {
            
            PreFijo(re.ramaizq);
            Console.Write(re.dato + " ");
            PreFijo(re.ramader);
        }
        public static void PostFijo(Arbol re)
        {
            
            PreFijo(re.ramaizq);
            PreFijo(re.ramader);
            Console.Write(re.dato + " ");
        }
    }
}
