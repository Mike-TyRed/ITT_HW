using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 

namespace Proyecto1
{
    class Producto
    {
        public string Descripción;
        public int Departamento, Likes, Codigo;

        List<PrecioFecha> Precios;
    }

    class ProductoDB:Producto
    {
        BinaryWriter bw = null;
        BinaryReader br = null;

        public void CrearArchivo(String Archivo)
        {
            //Variable local método.
            char resp;
            
            try
            {
                //Creación del flujo para escribir datos al archivo
                bw = new BinaryWriter (new FileStream(Archivo, FileMode.Create, FileAccess.Write));

                //Captura de datos.
                do 
                {
                    Console.Clear();

                    Console.WriteLine("Código del producto: ");
                    Codigo = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Descripción del producto: ");
                    Descripción = Console.ReadLine();

                    Console.WriteLine("Departamento del producto: ");
                    Departamento = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Likes del producto: ");
                    Likes = Int32.Parse(Console.ReadLine());

                    //Escribe los datos al archivo.
                    bw.Write(Codigo);
                    bw.Write(Descripción);
                    bw.Write(Departamento);
                    bw.Write(Likes);

                    Console.Write("\n\nDeseas almacenar otro Registro (s/n)?");
                    resp = char.Parse(Console.ReadLine());
                } 
                    while ((resp == 's') || (resp =='S'));
            }
                        catch(IOException es)
                        {
                        Console.WriteLine("\nMensaje del Error: " + es.Message);
                        Console.WriteLine("\nRuta del Error: " + es.StackTrace);
                        }
                            finally
                            {
                             if(bw != null) bw.Close(); //Cierra el flujo de estructura.
                                Console.WriteLine("\nPresione <enter> para terminar la escritura de datos y regresal al menú.");
                                Console.ReadKey();
                            }
        }

        public void MostrarArchivo(string Archivo)
        {
            try
            {
                //Verifica si existe el archivo
                if (File.Exists(Archivo))
                {
                    //creación flujo para leer datos del archivo
                    br = new BinaryReader(new FileStream(Archivo, FileMode.Open, FileAccess.Read));
                    
                    //despliegue de datos en pantalla
                    Console.Clear();
                    do
                    {
                        //lectura de registros mientras no llegue al End Of File
                        Codigo = br.ReadInt32();
                        Descripción = br.ReadString();
                        Departamento = br.ReadInt32();
                        Likes = br.ReadInt32();
                        /*
                        DiasTrabajados = br.ReadInt32();
                        SalarioDiario = br.ReadSingle();
                        */
                        //muestra los datos en pantalla
                        Console.WriteLine("Código del producto: " + Codigo);
                        Console.WriteLine("Descripción del producto: " + Descripción);
                        Console.WriteLine("Departamento del producto: "+ Departamento);
                        Console.WriteLine("Likes del producto: "+ Likes);
                        /*
                        Console.WriteLine("Dias Trabajados del Empleado : "+ DiasTrabajados);
                        Console.WriteLine("Salario Diario del Empleado :{0:C} ",SalarioDiario);
                        Console.WriteLine("SUELDO TOTAL del Empleado :{0:C} ", (DiasTrabajados*SalarioDiario));
                        */
                        Console.WriteLine("\n");
                    } 
                        while (true);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\nEl Archivo " + Archivo + " No Existe en el Disco!!");
                    Console.Write("\nPresione <enter> para Continuar...");
                    Console.ReadKey();
                }
            }
                    catch (EndOfStreamException)
                    {
                        Console.WriteLine("\n\nFin del Listado de Productos");
                        Console.Write("\nPresione <enter> para Continuar...");
                        Console.ReadKey();
                    }
            finally
            {
                if (br != null) br.Close(); //cierra flujo lectura
                Console.Write("\nPresione <enter> para terminar la Lectura de Datos y regresar al Menú.");
                Console.ReadKey();
            }
        }
    }
    class PrecioFecha
    {
        DateTime FechaInicio, FechaFinal;
        Decimal Precio;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Variables auxiliares.
            string Arch = null;
            int opcion;

            //Creación del objeto.
            ProductoDB A1 = new ProductoDB();

            //Menu de opciones
            do
            {
                Console.Clear();
                Console.WriteLine("\n*** Archivo de productos***");
                Console.WriteLine("1.- Creación de un Archivo.");
                Console.WriteLine("2.- Lectura de un Archivo.");
                Console.WriteLine("3.- Salida del Programa.");
                Console.Write("\n¿Qué opción deseas? ");
                opcion = Int16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    //bloque de escritura
                        try
                        {
                        //captura nombre archivo
                        Console.Write("\nAlimenta el Nombre del Archivo a Crear: "); Arch = Console.ReadLine();
                        //verifica si existe el archivo
                        char resp = 's';
                            if (File.Exists(Arch))
                            {
                            Console.Write("\nEl Archivo Existe!!, Deseas Sobreescribirlo (s/n)? ");
                            resp = Char.Parse(Console.ReadLine());
                            }

                            if ((resp == 's') || (resp == 'S'))
                            A1.CrearArchivo(Arch);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;
                    case 2:
                    //bloque de lectura
                        try
                        {
                        //captura nombre archivo
                        Console.Write("\nAlimenta el Nombre del Archivo que deseas Leer: "); Arch = Console.ReadLine();
                        A1.MostrarArchivo(Arch);
                        }
                            catch (IOException e)
                            {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                            }
                        break;
                    case 3:
                            Console.Write("\nPresione <enter> para Salir del Programa.");
                            Console.ReadKey();
                            break;
                    default:
                    Console.Write("\nEsa Opción No Existe!!, Presione <enter> para Continuar...");
                    Console.ReadKey();break;
                }
            }
            while(opcion !=3);             
        }
    }
}

