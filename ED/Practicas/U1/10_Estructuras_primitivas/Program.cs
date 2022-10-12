using System;

namespace Estructuras_primitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PROGRAMA USANDO ESTRUCTURAS PRIMITIVAS";
            
            int p = 0, p2 = 0;
            double y = 0,r ,r2 = 0, x2 = 0;

            Console.WriteLine("Menú de opciones a realizar");
            Console.WriteLine("1.- Raíz Cuadrada");
            Console.WriteLine("2.- Potencias");
            Console.WriteLine("3.- Valor absoluto");
            Console.WriteLine("4.- Número máximo");
            Console.WriteLine("5.- Número mínimo");
            Console.WriteLine("6.- Truncar valor decimal");
            Console.WriteLine("7.- Redondear");

            Console.WriteLine("Seleccione una opción: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa un número: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro número: ");
            y = double.Parse(Console.ReadLine());

            Console.Clear();

            if(z<=7)
            {
                switch(z)
                {
                    case 1:
                        Console.WriteLine("Raíz cuadrada");
                        r = Math.Sqrt(x2);
                        Console.WriteLine("La raíz cuadrada de {0} es: {1}.", x2, r);
                        r2 = Math.Sqrt(y);
                        Console.WriteLine("La raíz cuadrada de {0} es: {1}.", y, r2);
                    break;
                
                    case 2:
                        Console.WriteLine("Potencias");
                        Console.WriteLine("Ingresa el número entero que será la potencia: ");
                        p = Int32.Parse(Console.ReadLine());
                        r = Math.Pow(x2, p);
                        Console.WriteLine("{0} elevado a {1} es: {2}.", x2, p, r);
                        Console.WriteLine("Ingresa el número entero que será la potencia: ");
                        p2 = Int32.Parse(Console.ReadLine());
                        r2 = Math.Pow(y, p2);
                        Console.WriteLine("{0} elevado a {1} es: {2}.", y, p2, r2);
                    break;
                
                    case 3:
                        Console.WriteLine("Valor absoluto");
                        r = Math.Abs(x2);
                        Console.WriteLine("El valor absoluto de {0} es: {1}.", x2, r);
                        Console.WriteLine("Valor absoluto");
                        r2 = Math.Abs(y);
                        Console.WriteLine("El valor absoluto de {0} es: {1}.", y, r2);
                    break;
                
                    case 4:
                        Console.WriteLine("Número máximo");
                        r = Math.Max(x2, y);
                        Console.WriteLine("El número máximo de {0} y {1} es: {2}.", x2, y, r );
                    break;
                
                    case 5:
                        Console.WriteLine("Número mínimo");
                        r = Math.Min(x2, y);
                        Console.WriteLine("El número máximo de {0} y {1} es: {2}.", x2, y, r );
                    break;
                
                    case 6:
                        Console.WriteLine("Truncar valor decimal");
                        //Console.WriteLine("Ingresa un numero: ");
                       // x2 = double.Parse(Console.ReadLine());
                        r = Math.Truncate(x2);
                        Console.WriteLine("{0} truncado es: {1}",x2 , r );
                        r2 = Math.Truncate(y);
                        Console.WriteLine("{0} truncado es: {1}",y , r2 );
                    break;
                
                    case 7:
                        Console.WriteLine("Redondear");
                        r = Math.Truncate(x2);
                        Console.WriteLine("{0} redondeado es: {1}",x2 , r );
                        r2 = Math.Truncate(y);
                        Console.WriteLine("{0} redondeado es: {1}",y , r2 );
                    break;

                    default: Console.WriteLine("Opcion no valida.");
                    break;
                }
            }
            else{Console.WriteLine("Ingresa una de las 7 opciones."); Console.Clear();}
        }
    }
}
