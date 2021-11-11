using System;

namespace ES_8
{
    class Program
    {
        public struct Agenda
        {
            public string Name;
            public string Date;
            public double Telf;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Programa de manejo de registros";
            Console.WriteLine("Agenda de datos con Struct");
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Agenda[] Ca = new Agenda[5];

            string O = "si";
            int i = 0;
            while(O == "si")
            {
                if(i<5)
                {
                    Console.Write("Ingrese un nombre: ");
                    Ca[i].Name = Console.ReadLine();
                    Console.Write("Ingrese un número de contacto: ");
                    Ca[i].Telf = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese su fecha de nacimiento (dd/mm): ");
                    Ca[i].Date = Console.ReadLine();

                    i++;
                    Console.WriteLine();
                }
                else
                {    Console.WriteLine("Ya no puede registrar más datos");
                break;}
            }
            Console.Clear();

            Console.WriteLine("Datos agendados");
            Console.SetCursorPosition(1,0);
            Console.WriteLine(" Contacto\t\tTeféfono\tCumpleaños    \n");

            int x, y = 1;
            for(x=0; x<i; x++)
            {
                Console.SetCursorPosition(y*2, x+1);
                Console.Write("{0}\t", Ca[x].Name);
                Console.Write("\t{0}\t", Ca[x].Telf);
                Console.Write("\t{0}\t", Ca[x].Date);
            }
        }
    }
}
