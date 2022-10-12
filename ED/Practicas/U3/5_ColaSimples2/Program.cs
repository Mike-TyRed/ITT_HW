using System;

namespace _4_ColasSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Manejo de colas simples con métodos";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            int[] Calfs = new int [40];

            int i = 0, f = -1;
            int clf = 0, ti = 0;

            int opc, oo;

            do
            {
                Console.Clear();

                Console.WriteLine("----MENU----");
                Console.WriteLine("[1] Insertar");
                Console.WriteLine("[2] Eliminar");
                Console.WriteLine("[3] Mostrar");
                Console.WriteLine("[4] Promedio");
                Console.WriteLine("[0] Salir");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opc)
                {
                    case 1:
                        do
                        {   
                            if(f >= 50)
                            {
                                Console.WriteLine("Cola llena");
                                Console.WriteLine();
                            }
                            else
                            {
                            Console.Write("Ingrese su calificación: ");
                            clf = Convert.ToInt32(Console.ReadLine());

                            f = f + 1;
                            Calfs[f] = clf;
                            }
                            if(i == 0)
                                i = 0;

                            Console.WriteLine();

                            Console.Write("¿Ingresar nueva calificación? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                        }while(oo == 1);
                    break;

                    case 2:
                        do
                        {
                            Console.Write("¿Seguro que desea eliminar una calificación? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());

                            if(oo == 1)
                            {
                                if(i == f)
                                {
                                    Console.WriteLine("Único elemento eliminado");
                                    ti = Calfs[i];
                                    Console.WriteLine("La calificación: " + ti + " fue eliminada");
                                    Calfs[i] = 0;
                                    i = 0; f = -1;

                                    Console.WriteLine();
                                }
                                else
                                {
                                    ti = Calfs[i];
                                    Console.WriteLine("La calificación: " + ti + " fue eliminada");
                                    Calfs[i] = 0;
                                    i = i + 1;

                                    Console.WriteLine();
                                }
                            }
                            Console.WriteLine();
                        }while(oo == 1);
                    break;

                    case 3:
                        Console.WriteLine("Calificaciones guardadas");
                        Console.WriteLine();

                        for(int j = 0; j <= f; j++)
                        Console.Write("| " + Calfs[j] + " |");

                        Console.WriteLine();
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadKey();
                    break;

                    case 4:
                        Console.WriteLine("El promedio de calificaciones es: ");

                        int temp = 0, d = 0;
                        for(int ii = 0; ii <= (f+1) ; ii++)
                        {
                            temp = temp + Calfs[ii];
                            d = ii;
                        }

                        Console.WriteLine(f);
                        Console.WriteLine(temp);

                        float promedio = (temp/d);
                        Console.WriteLine(promedio);
                            
                        Console.WriteLine();
                        Console.WriteLine("Presione cualquier telca para salir");
                        Console.ReadKey();
                    break;
                }

            }while(opc != 0);
        }
        public static bool full(int t)
        {
            if(t == 100)
                return true;
            else
                return false;
        }
        public static bool empty(int t)
        {
            if(t == -1)
                return true;
            else
                return false;
        }
    }
}