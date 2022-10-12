using System;

namespace Edad
{
    class EdadOverflowException : Exception
    {
        public EdadOverflowException():base("Edad no valida.")
        {  }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Captura tu edad: ");
        //    string edad_capturada = Console.ReadLine();
            int edad = -1;

            try
            {
                edad = Int16.Parse(Console.ReadLine());
            //    edad = edad/0;

                if(edad>130)
                {
                edad = -1;
                throw new EdadOverflowException();
                }
            }

            catch (FormatException fe)
            {
                Console.WriteLine("Solo puedes escribir números");
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException)
            {
                 Console.WriteLine("Haz caso crack");
            }
            catch (Exception e)
            {
                 Console.WriteLine("Error {0}", e.GetType());
            }

            if(edad != -1)
            {            
                if(edad > 40)
                {
                    Console.WriteLine("Estas en riesgo.");
                }
                else{Console.WriteLine("Riesgo bajo.");}
            }
            
        }
    }
}
