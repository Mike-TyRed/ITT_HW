using System;

namespace _2_manejo_de_estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "MANEJO DE ESTRUCTURAS SIMPLES";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: #19211740");

            Console.WriteLine("");

            Console.WriteLine("----Menú de opciones----");
            Console.WriteLine("1.- Mostrar longitud");
            Console.WriteLine("2.- Cambiar letras");
            Console.WriteLine("3.- Mostrar un apellido");
            Console.WriteLine("4.- Enter entre espacios");

            Console.WriteLine("");

            Console.WriteLine("Ingresa tu nombre: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Elige una opción: ");
            int z = int.Parse(Console.ReadLine());

            Console.Clear();

            switch(z)
            {
                case 1:
                    Console.WriteLine("Mostrar longitud");
                    int Longitud = cadena.Length;
                    Console.WriteLine("El tamaño del Nombre es: {0}", Longitud);
                break;

                case 2:
                    Console.WriteLine("Cambiar letras");
                    Console.Write("¿Qué letra desea reemplazar? ");
                    string l = Console.ReadLine();

                    Console.WriteLine("");

                    Console.WriteLine("¿Por cuál letra desea reemplazarla? ");
                    string r = Console.ReadLine();

                    string remplazo = cadena.Replace(l, r);
                    Console.WriteLine("Reemplazo de " + l + " por " + r + " y este queda: {0}", remplazo);

                break;

                case 3:
                    Console.WriteLine("¿Tienes uno o dos nombres?");
                    Console.Write("Escribe 1 o 2: ");
                    int n = int.Parse(Console.ReadLine());

                    if(n == 1)
                    {
                        Console.WriteLine("Mostrar primer apellido");
                    char delimitador = ' ';

                    string[] valores = cadena.Split(delimitador);

                    foreach(string palabra in valores)
                    Console.WriteLine(valores[1]);
                    }
                    else
                    {
                        Console.WriteLine("Mostrar un apellido");
                    char delimitador = ' ';

                    string[] valores = cadena.Split(delimitador);

                    foreach(string palabra in valores)
                    Console.WriteLine(valores[2]);
                    }

                    
                break;

                case 4:
                    Console.WriteLine("Enter entre espacios");
                    char delimitador2 = ' ';

                    string[] valores3 = cadena.Split(delimitador2);

                    foreach(string palabra in valores3)
                    Console.WriteLine(palabra);
                break;

                default:
                    Console.WriteLine("Opción inválida");
                break;
            }
        }
    }
}
