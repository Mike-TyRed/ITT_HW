using System;
using System.Collections;

namespace _4_ManejoPilasDinamicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa de pilas dinámicas";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Stack Saldos = new Stack (100);
            int top = 0, saldo, o, oo = 0;
            int i, j, aux;
            float promedio = 0;

            int [] x = new int [100];
            //int [] y = new int [100];

            do
            {
                Console.Clear();

                Console.WriteLine("Tamaño de pila: [" + (top + 1) + "]");

                Console.WriteLine("----MENU----");
                Console.WriteLine("[1] Insertar");
                Console.WriteLine("[2] Eliminar");
                Console.WriteLine("[3] Imprimir");
                Console.WriteLine("[4] Obtener mayor y desplegar");
                Console.WriteLine("[5] Obtener menor y desplegar");
                Console.WriteLine("[6] Obtener promedio");
                Console.WriteLine("[0] Salir");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                o = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(o)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingresa saldo: ");
                            saldo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            if(full(Saldos) != true)
                                Console.Write("No hay mas espacios");
                            else
                            {
                                Saldos.Push(saldo);
                                x[top] = saldo;
                                top++;
                            }

                            Console.WriteLine();

                            Console.Write("Ingresar otro saldo? [1] Si, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());

                        }while(oo == 1);
                    break;

                    case 2:
                        do
                        {
                            Console.Write("Continuar borrando saldos? [1] Si, [2] No; ");
                            oo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            if(empty(Saldos) != true)
                            Console.WriteLine("El valor eliminado fue: " + Saldos.Pop());
                            else
                            Console.WriteLine("El Stack esta vacio");

                        }while(oo == 1);
                        
                    break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("Los saldos guardados son: ");
                        foreach(int s in Saldos)
                        {
                            Console.WriteLine(s);
                        }

                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                    break;

                    case 4:
                        for(i = 0; i < (top-1); i++)
                        {
                            for(j = 0; j < (top-1); j++)
                            {
                                if(x[top] > x[top+1])
                                {
                                    aux = x[top];
                                    x[top] = x[top+1];
                                    x[top+1] = aux;
                                }
                            }
                        }

                        Console.WriteLine("Mayor a menor");
                        for(i = top-1; i > -1; i--)
                            Console.WriteLine(x[i]);

                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                    break;

                    case 5:
                        for(i = 0; i < (top-1); i++)
                        {
                            for(j = 0; j < (top-1); j++)
                            {
                                if(x[top] > x[top+1])
                                {
                                    aux = x[top];
                                    x[top] = x[top+1];
                                    x[top+1] = aux;
                                }
                            }
                        }

                        Console.WriteLine("Menor a mayor");
                        for(i = 0; i < top; i++)
                        Console.WriteLine(x[i]);

                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                    break;

                    case 6:
                        promedio = 0;

                        for(i = (top-1); i > -1; i--)
                            promedio = promedio + x[i];

                        Console.WriteLine((promedio/(top)));

                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                    break;

                    default:
                        o = 0;
                    break;
                }

            }while(o != 0);
        }
        public static bool full(Stack Saldos)
        {
            if(Saldos.Count < 100)
                return true;
            else
                return false;
        }
        public static bool empty(Stack Saldos)
        {
            if(Saldos.Count >= 100)
                return true;
            else
                return false;
        }

    }
}
