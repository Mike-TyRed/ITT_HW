using System;

namespace _2_ArbolBinario_Menu
{
    class Program
    {
        public class Arbol
        {
            public double info;
            public Arbol izq;
            public Arbol der;
            public Arbol()
            {
                info = 0;
                izq = null;
                der = null;
            }
        }
        static Arbol re;
        static Arbol raiz = null;
        static float cal;
        static Arbol temp;
        static int opc;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Menú de árbol binario.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Materia: 19211740");
            Console.WriteLine();
            Console.Write("Iniciar programa.");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Insertar  ");
                Console.WriteLine("[2] Eliminar  ");
                Console.WriteLine("[3] Buscar    ");
                Console.WriteLine("[4] Recorrer  ");
                Console.WriteLine("[0] Salir     ");
                Console.WriteLine();
                Console.Write("Ingresa una opción: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                    do
                    {
                        Console.Clear();
                        Insertar();
                    
                        Console.Write("¿Ingresar otra calificación? [1] Sí, [2] No: ");
                        opc = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }while(opc == 1);
                break;

                case 2:
                    do
                    {
                        Console.Clear();
                        Eliminar();

                        Console.Write("¿Eliminar otra calificación? [1] Sí, [2] No ");
                        opc = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    } while (opc == 1);
                break;

                case 3:
                    do
                    {
                        Console.Clear();
                        Buscar(re);

                        Console.Write("¿Buscar otra calificación? [1] sí, [2] No: ");
                        opc = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    } while (opc == 1);
                break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Recorrido por PostFijo.");
                    re = raiz;
                    PostOrden(re);
                    Console.ReadKey();
                break;

                default:
                    opc = 0;
                break;
                }

            } while (opc != 0);
        }

        public static void Insertar()
        {
            Arbol p = new Arbol();
            Arbol q = new Arbol();
            int b = 0;
            p.izq = null;
            p.der = null;

            Console.Write("Ingrese una calificación: ");
            cal = int.Parse(Console.ReadLine());

            p.info = cal;

            if(raiz == null)
            {
                raiz = p;
            }
            else
            {
                q = raiz;

                while(b != 1)
                {
                    if(p.info <= q.info)
                    {
                        if(q.izq == null)
                        {
                            q.izq = p;
                            b = 1;
                        }
                        else
                            q = q.izq;
                    }
                    else
                    {
                        if(q.der == null)
                        {
                            q.der = p;
                            b = 1;
                        }
                        else
                        {
                            q = q.der;
                        }
                    }
                }
            }
        }
        public static void PostOrden(Arbol temp)
        {
            if(temp != null)
            {
                Console.WriteLine("[" + temp.info +"] ");
                if(temp.izq != null)
                {
                    PostOrden(temp.izq);
                }
                if(temp.der != null)
                {
                    PostOrden(temp.der);
                }
            }
            else
            {
                Console.WriteLine("El ábol binario está vacío.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Eliminar()
        {
            Arbol p, q, v, s, t;
            bool encontrado;
            double x;
            p = raiz;
            q = null;
            encontrado = false;

            if(p != null)
            {
                Console.Write("¿Calificación por eliminar?: ");
                x = int.Parse(Console.ReadLine());
                while (p != null && encontrado == false)
                {
                    if(p.info == x)
                    {
                        encontrado = true;
                        Console.WriteLine("El nodo" + p.info  + "será eliminado");
                    }
                    else
                    {
                        q = p;
                        if(x < p.info)
                            p = p.izq;
                        else
                            p = p.der;
                    }
                }
                if(encontrado == true)
                {
                    if(p.izq == null)
                        v = p.der;
                    else
                    {
                        if(p.der == null)
                            v = p.izq;
                        else
                        {
                            t = p;
                            v = p.der;
                            s = v.izq;
                            while(s != null)
                            {
                                t = v;
                                v = s;
                                s = v.izq;
                            }
                            if(t != p)
                            {
                                t.izq = v.der;
                                v.der = p.der;
                            }
                        }
                        v.izq = p.izq;
                    }
                    if(q == null)
                        raiz = v;
                    else
                    {
                        if(p == q.izq)
                            q.izq = v;
                        else
                            q.der = v;
                    }
                }
            else
            Console.WriteLine("El nodo " + x + "no se encuentra.");
            }
        else
            {Console.Clear();
            Console.Write("Arbol vacío.");
            Console.ReadKey();
            Console.Clear();}
        }

        public static void Buscar(Arbol temp)
        {
            Console.Write("Calificación a buscar: ");
            double x = int.Parse(Console.ReadLine());

            bool encontrado = false;

            while(temp != null && encontrado == false)
            {
                if(x == temp.info)
                    encontrado = true;
                else
                {
                    if(x < temp.info)
                        temp = temp.izq;
                    else
                        temp = temp.der;
                }
            }
            if(encontrado == false)
                {
                    Console.Clear();
                    Console.Write("El nodo "+x+" NO está en el árbol");
                    Console.ReadKey();
                }
            else
                {
                    Console.Clear();
                    Console.Write("El nodo "+x+" SÍ está en el árbol");
                    Console.ReadKey();
                }
        }
    }
}
