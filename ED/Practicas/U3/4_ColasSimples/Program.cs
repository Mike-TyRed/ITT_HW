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

            string[] Materias = new string [50];
            int[] Calfs = new int [50];

            int i = 0, f = -1;
            int clf = 0, ti = 0;
            string mat = " ";
            string ts = " ";

            int opc, oo;

            Console.Clear();

            do
            {
                Console.Clear();

                Console.WriteLine("----MENU----");
                Console.WriteLine("[1] Insertar");
                Console.WriteLine("[2] Eliminar");
                Console.WriteLine("[3] Mostrar");
                Console.WriteLine("[4] Buscar");
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
                            f = Insertar(Materias, Calfs, mat, clf, f, i);

                            Console.WriteLine();

                            Console.Write("¿Ingresar nueva materia? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                        }while(oo == 1);
                        
                    break;

                    case 2:
                        do
                        {
                            Console.Write("¿Seguro que desea eliminar una materia? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());

                            if(oo == 1)
                                i = Eliminar(Materias, Calfs, mat, clf, f, i, ti, ts);

                            Console.WriteLine();

                        }while(oo == 1);
                    break;

                    case 3:
                        Console.WriteLine("Materias guardadas y sus calificaciones");
                        Console.WriteLine();

                        Imprimir(Materias, Calfs, f);

                        Console.WriteLine();
                        Console.WriteLine("Presione cualquier telca para salir");
                        Console.ReadKey();
                    break;

                    case 4:
                        do
                        {
                            Console.Write("Ingrese la materia que quiere buscar: ");
                            ts = Console.ReadLine();

                            Buscar(Materias, Calfs, f, i, ts, ti);

                            Console.WriteLine();
                            Console.Write("¿Buscar otra materia? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());
                        }while(oo == 1);
                        
                    break;
                }

            }while(opc != 0);
        }
        public static int Insertar(string[] Materias, int[] Calfs, string mat, int clf, int f, int i)
        {
            if(f >= 50)
            {
                Console.WriteLine("Cola llena");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Ingrese una materia: ");
                mat = Console.ReadLine();
                Console.Write("Ingrese su calificación: ");
                clf = Convert.ToInt32(Console.ReadLine());

                f = f + 1;
                Materias[f] = mat;
                Calfs[f] = clf;
            }
            if(i == 0)
                i = 0;

            return f;
        }
        public static int Eliminar(string[] Materias, int[] Calfs, string mat, int clf, int f, int i, int ti, string ts)
        {
            if(i == f)
            {
                Console.WriteLine("Único elemento eliminado");
                ts = Materias[i];
                ti = Calfs[i];
                Console.WriteLine("La materia " + ts + ", con calificación: " + ti + " fue eliminada");
                Materias[i] = null;
                Calfs[i] = 0;
                i = 0; f = -1;

                Console.WriteLine();
            }
            else
            {
                ts = Materias[i];
                ti = Calfs[i];
                Console.WriteLine("La materia " + ts + " con calificación: " + ti + " fue eliminada");
                Materias[i] = null;
                Calfs[i] = 0;
                i = i + 1;

                Console.WriteLine();
            }
            return i;
        }
        public static int Imprimir(String[] Materias, int[] Calfs, int f)
        {
            for(int j = 0; j <= f; j++)
                Console.Write("| Materia: " + Materias[j] + " Calificación: " + Calfs[j] + " |");
            return f;
        }
        public static int Buscar(string[] Materias, int[] Calfs, int f, int i, string ts, int ti)
        {
            for(int y = i; y <= f; y++)
            {
                ti = 0;
                if(ts == Materias[y])
                {
                    ti = y;
                    Console.WriteLine("La materia " + ts + " sí se encuentra y su calificación es: " + Calfs[ti]);
                    ti = 1;
                }
                if(ti == 0)
                {
                    Console.WriteLine("No se encontró la materia");
                }
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
            }
            return f;
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
