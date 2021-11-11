
/*using System;
using System.Collections.Generic;

namespace _6E_Uso_de_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {   
            Program Me = new Program();

            Console.Clear();

            Console.Title = "Uso de Conjuntos";
            Console.Write("Alumno: Terrazas Rojo Miguel Arturo");
            Console.Write("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("¿Cuántos conjuntos desea realizar? ");
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("¿Cuántos datos guardarán? ");
            int d = Int32.Parse(Console.ReadLine());

            if(c >= 2 && c <= 6)
            {
                Console.WriteLine("-----Menú de opciónes-----");
                Console.WriteLine("1.- Unión de conjuntos");
                Console.WriteLine("2.- Intersección de conjuntos");
                Console.WriteLine("3.- Diferencia de conjuntos");
                Console.WriteLine("4.- Diferencia simétrica");
                Console.WriteLine("5.- Todas las opciones");

                Console.WriteLine();

                Console.Write("Elige una operación a realizar: ");
                int o = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                HashSet<string> A = new HashSet<string>();
                HashSet<string> B = new HashSet<string>(); 
                HashSet<string> C = new HashSet<string>();
                HashSet<string> D = new HashSet<string>(); 
                HashSet<string> E = new HashSet<string>();
                HashSet<string> F = new HashSet<string>(); 

                switch(c)
                {
                    case(2):
                        Me.Dos(A, B);
                    break;
                    case(3):
                        x = 0;
                        Console.WriteLine("Ingresa los datos del conjunto A: ");
                        for(int i=0; i<d; i++)
                        {
                            Console.Write("[{0}]", x=x+1);
                            string v1 = Console.ReadLine();
                            A.Add(v1);
                        }
                        Console.WriteLine();
                        x = 0;

                        Console.WriteLine("Ingresa los datos del conjunto B: ");
                        for(int i=0; i<d; i++)
                        {
                            Console.Write("[{0}]", x=x+1);
                            string v2 = Console.ReadLine();
                            B.Add(v2);
                        }
                        Console.WriteLine();

                        Console.Write("Conjunto A: ");
                            foreach(string i in A)
                            {
                                Console.Write( " {0}", i);
                            }
                        Console.WriteLine();

                        Console.Write("Conjunto B: ");
                            foreach(string i in B)
                            {
                                Console.Write( " {0}", i);
                            }
                        Console.WriteLine();

                        HashSet<string> Union2 = new HashSet<string>(A);
                        Union2.UnionWith(B);
                        HashSet<string> Union3 = new HashSet<string>(Union2);
                        Union3.UnionWith(C);
                        HashSet<string> Inter2 = new HashSet<string>(A);
                        Inter2.IntersectWith(B);
                        Inter2.IntersectWith(B);
                        HashSet<string> Dif2 = new HashSet<string>(A);
                        Dif2.ExceptWith(B);
                        HashSet<string> DifS2 = new HashSet<string>(A);
                        DifS2.SymmetricExceptWith(B);

                        switch(o)
                        {
                            case(1):
                                Console.Write("Unión de A y B: ");
                                foreach(string i in Union2)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                                break;
                                
                            case(2):
                                Console.Write("Intersección de A y B: ");
                                foreach(string i in Inter1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                            case(3):
                                Console.Write("Diferencia de A y B: ");
                                foreach(string i in Dif1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                            case(4):
                                Console.Write("Diferencia Simétrica de A y B: ");
                                foreach(string i in DifS1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                            case(5):
                                Console.Write("Unión de A y B: ");
                                foreach(string i in Union1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();

                                Console.Write("Intersección de A y B: ");
                                foreach(string i in Inter1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();

                                Console.Write("Diferencia de A y B: ");
                                foreach(string i in Dif1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();

                                Console.Write("Diferencia Simétrica de A y B: ");
                                foreach(string i in DifS1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                        }
                    break;
                    case(4):
                    break;
                    case(5):
                    break;
                    case(6):
                    break;
                }
            }
            else{Console.WriteLine("Esa cantidad no está permitida, try again");}
        }

        void Dos(HashSet<string> A, HashSet<string> B, d, )
        {
            HashSet<string> Union1 = new HashSet<string>(A);
            Union1.UnionWith(B);
            HashSet<string> Inter1 = new HashSet<string>(A);
            Inter1.IntersectWith(B);
            HashSet<string> Dif1 = new HashSet<string>(A);
            Dif1.ExceptWith(B);
            HashSet<string> DifS1 = new HashSet<string>(A);
            DifS1.SymmetricExceptWith(B);
            
            int x = 0;
            Console.WriteLine("Ingresa los datos del conjunto A: ");
            for(int i=0; i<d; i++)
            {
                Console.Write("[{0}]", x=x+1);
                string v1 = Console.ReadLine();
                A.Add(v1);
            }
            Console.WriteLine();
            x = 0;

            Console.WriteLine("Ingresa los datos del conjunto B: ");
            for(int i=0; i<d; i++)
            {
                Console.Write("[{0}]", x=x+1);
                string v2 = Console.ReadLine();
                B.Add(v2);
            }
            Console.WriteLine();

            Console.Write("Conjunto A: ");
            foreach(string i in A)
            {
                Console.Write( " {0}", i);
            }
            Console.WriteLine();

            Console.Write("Conjunto B: ");
            foreach(string i in B)
            {
            Console.Write( " {0}", i);
            }
            Console.WriteLine();

            switch(o)
            {
            case(1):
                Console.Write("Unión de A y B: ");
                                foreach(string i in Union1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                                break;
                                
                            case(2):
                                Console.Write("Intersección de A y B: ");
                                foreach(string i in Inter1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                            case(3):
                                Console.Write("Diferencia de A y B: ");
                                foreach(string i in Dif1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                            case(4):
                                Console.Write("Diferencia Simétrica de A y B: ");
                                foreach(string i in DifS1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                            case(5):
                                Console.Write("Unión de A y B: ");
                                foreach(string i in Union1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();

                                Console.Write("Intersección de A y B: ");
                                foreach(string i in Inter1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();

                                Console.Write("Diferencia de A y B: ");
                                foreach(string i in Dif1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();

                                Console.Write("Diferencia Simétrica de A y B: ");
                                foreach(string i in DifS1)
                                {
                                    Console.Write( " {0}", i);
                                }
                                Console.WriteLine();
                            break;
                        }
        }
    }
}
*/