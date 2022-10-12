using System;

namespace _1_ArbolBinario
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
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Crea, Inserta y Recorre en árboles binarios.";
            
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar.");
            Console.ReadKey();
            
            Console.Clear();
            int opc;
            
            do
            {
            Console.Clear();
            
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("[1] Ingresar calificaciones.");
            Console.WriteLine("[2] Recorrer Orden previo.");
            Console.WriteLine("[0] Salir del programa.");
            Console.WriteLine();
            Console.Write("Ingrese una opción: ");
            opc = int.Parse(Console.ReadLine());

            Console.Clear();

                switch(opc)
                {
                case 1:
                do
                {
                    Insertar();
                    
                    Console.Write("¿Ingresar otra calificación? [1] Sí, [2] No: ");
                    opc = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }while(opc == 1);
                break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Recorrido por PreOrden.");
                    re = raiz;
                    PreOrden(re);
                    Console.ReadKey();
                break;

                default:
                opc = 0;
                break;
                }
            }while(opc != 0);
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
        public static void PreOrden(Arbol temp)
        {
            if(temp != null)
            {
                Console.WriteLine("[" + temp.info +"] ");
                if(temp.izq != null)
                {
                    PreOrden(temp.izq);
                }
                if(temp.der != null)
                {
                    PreOrden(temp.der);
                }
            }
            else
            {
                Console.WriteLine("El ábol binario está vacío.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
