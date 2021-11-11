using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Producto
    {
    public string Codigo{get; set;}
    public string Descripcion{get; set;}
    public int Likes{get; set;}
    public double Precio{get; set;}
    public string Departamento{get; set;}

        public override string ToString()
        {
        return String.Format("{0}|{1}|{2}|{3}|{4}|",Codigo,Descripcion,Precio,Departamento,Likes);
        }
            public Producto(string c, string d, double p, string dp, int l)
            {
            this.Codigo=c;
            this.Descripcion=d;
            this.Departamento=dp;
            this.Likes=l;
            this.Precio=p;
            }   
        }
        class ProductoBD
        {
            public static void WriteToTXT(string path, List<Producto> productos)
            {
                StreamWriter txtOut = new StreamWriter(
                new FileStream(path, FileMode.Append, FileAccess.Write));
                    foreach(Producto p in productos)
                    {
                        txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.Codigo,p.Descripcion,p.Precio,p.Departamento,p.Likes);
                    }
                txtOut.Close();
            }
            public static List<Producto> ReadFromTXT(string path)
            {
                List<Producto> productos = new List<Producto>();
                StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                while(txtIn.Peek()!= -1)
                {
                    string line = txtIn.ReadLine();
                    string[]Columnas = line.Split('|');
                    
                    Producto p = new Producto(Columnas[0], Columnas[1], Double.Parse(Columnas[2]), Columnas[3], Int32.Parse(Columnas[4]));
                    productos.Add(p);
                }
            return productos;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            Console.WriteLine("-----MENÚ DE PRODUCTOS-----");
            Console.WriteLine("1.- Guardar Producto");
            Console.WriteLine("2.- Buscar dato(s) del producto");
            Console.WriteLine("3.- Nuevo archivo");
            Console.WriteLine("4.- Salir");
            Console.WriteLine("SELECCIONE UNA OPCIÓN");

            int c = 0; //Int32.Parse(Console.ReadLine());
            
            try
            {
                c = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe)
            {
                Console.WriteLine("Debes escribir uno de los 4 números del menú.");
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException ofe)
            {
                Console.WriteLine("Debes escribir uno de los 4 números del menú.");
                Console.WriteLine(ofe.Message);
            }
            //Console.Clear();
            switch(c)
            {
                case 1: //---------------------------------------------------------------------------------------------------Guardar un producto nuevo
                string code, desc, dep, name ;
                double pre;
                int lik, i, v;

                Console.Write("Escriba el nombre del archivo al que desea agregar el producto: ");
                name = Console.ReadLine();
                Console.Clear();

                if(File.Exists(name))
                {
                    do
                    {
                        Console.WriteLine("Código del producto: ");
                        code = Console.ReadLine();
                        Console.WriteLine("Descripción del producto: ");
                        desc = Console.ReadLine();
                        Console.WriteLine("Precio del producto: ");
                        pre = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Departamento del producto: ");
                        dep = Console.ReadLine();
                        Console.WriteLine("Likes del producto: ");
                        lik = Int32.Parse(Console.ReadLine());

                        productos.Add(new Producto(code, desc, pre, dep, lik));
                        ProductoBD.WriteToTXT(name, productos);
                        Console.Clear();

                        Console.WriteLine("Los datos han sido guardados.");
                        Console.Clear();

                        Console.WriteLine("¿Desea agregar otro producto?");
                        Console.WriteLine("1 = Sí");
                        Console.WriteLine("2 = No");
                        i = 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                i = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe2)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe2.Message);
            }
            catch(OverflowException ofe2)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe2.Message);
            }
            //Console.Clear();
                    }while(i==1);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No existe el archivo escrito.");
                }
                Console.Clear();
                break;

                case 2: //--------------------------------------------------------------------------------------------------Buscar información
                Console.Write("Escriba el nombre del archivo de donde desea la información: ");
                name = Console.ReadLine();
                Console.Clear();
                
                if(File.Exists(name))
                {
                Console.WriteLine("¿Qué desea ver?");
                Console.WriteLine("1.- Toda la información completa.");
                Console.WriteLine("2.- Una columna en específico.");
                v = 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                v = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe3)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe3.Message);
            }
            catch(OverflowException ofe3)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe3.Message);
            }
            //Console.Clear();

                    switch(v)
                    {
                        case 1:
                        productos = ProductoBD.ReadFromTXT(name);
                        foreach(Producto p  in productos)
                        {
                        Console.WriteLine(p);
                        }
                        break;

                        case 2:
                        Console.WriteLine("Elija la columna que desea ver: 1: Código, 2: Descripción, 3: Precio, 4: Departamento o 5: Likes.");
                        int n = Int32.Parse(Console.ReadLine());

                        switch(n)
                        {
                            case 1:
                            productos = ProductoBD.ReadFromTXT(name);
                            foreach(Producto p in productos)
                            {
                            Console.WriteLine(p.Codigo);
                            }
                            break;

                            case 2:
                            productos = ProductoBD.ReadFromTXT(name);
                            foreach(Producto p in productos)
                            {
                            Console.WriteLine(p.Descripcion);
                            }
                            break;
                            
                            case 3:
                            productos = ProductoBD.ReadFromTXT(name);
                            foreach(Producto p in productos)
                            {
                            Console.WriteLine(p.Precio);
                            }
                            break;
                            
                            case 4:
                            productos = ProductoBD.ReadFromTXT(name);
                            foreach(Producto p in productos)
                            {
                            Console.WriteLine(p.Departamento);
                            }
                            break;
                                    
                            case 5:
                            productos = ProductoBD.ReadFromTXT(name);
                            foreach(Producto p in productos)
                            {
                            Console.WriteLine(p.Likes);
                            }
                            break;   
                        }break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No existe el archivo escrito.");
                }
                break;

                case 3: //------------------------------------------------------------------------------------------------Nuevo archivo

                Console.WriteLine("Escriba un nombre para su archivo escribiendo al final .txt: ");
                name = Console.ReadLine();
                Console.Clear();

                    if(File.Exists(name))
                    {

                    Console.WriteLine("El archivo ya existe, ¿desea sobreescribirlo?");
                    Console.WriteLine("1: Sí, 2: No");
                    int y = 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                y = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe4)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe4.Message);
            }
            catch(OverflowException ofe4)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe4.Message);
            }
            //Console.Clear();
                    
                        if(y == 1)
                        {
                            ProductoBD.WriteToTXT(name, productos);    

                            Console.WriteLine("¿Desea agregar un producto?");
                            Console.WriteLine("1 = Sí");
                            Console.WriteLine("2 = No");
                            i = 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                i = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe5)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe5.Message);
            }
            catch(OverflowException ofe5)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe5.Message);
            }
            //Console.Clear();

                            while(i == 1)
                            {
                                Console.WriteLine("Código del producto: ");
                                code = Console.ReadLine();
                                Console.WriteLine("Descripción del producto: ");
                                desc = Console.ReadLine();
                                Console.WriteLine("Precio del producto: ");
                                pre = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Departamento del producto: ");
                                dep = Console.ReadLine();
                                Console.WriteLine("Likes del producto: ");
                                lik = Int32.Parse(Console.ReadLine());

                                productos.Add(new Producto(code, desc, pre, dep, lik));
                                ProductoBD.WriteToTXT(name, productos);
                                Console.Clear();

                                Console.WriteLine("Los datos han sido guardados.");
                                Console.Clear();

                                Console.WriteLine("¿Desea agregar otro producto?");
                                Console.WriteLine("1 = Sí");
                                Console.WriteLine("2 = No");
                                i = 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                i = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe6)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe6.Message);
            }
            catch(OverflowException ofe6)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe6.Message);
            }
            //Console.Clear();
                            }
                        }
                        
                    }
                    else
                    {
                        ProductoBD.WriteToTXT(name, productos);    
                        Console.WriteLine("¿Desea agregar un producto?");
                        Console.WriteLine("1 = Sí");
                        Console.WriteLine("2 = No");
                        i= 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                i = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe7)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe7.Message);
            }
            catch(OverflowException ofe7)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe7.Message);
            }
            //Console.Clear();

                        while(i == 1)
                        {
                            Console.WriteLine("Código del producto: ");
                            code = Console.ReadLine();
                            Console.WriteLine("Descripción del producto: ");
                            desc = Console.ReadLine();
                            Console.WriteLine("Precio del producto: ");
                            pre = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Departamento del producto: ");
                            dep = Console.ReadLine();
                            Console.WriteLine("Likes del producto: ");
                            lik = Int32.Parse(Console.ReadLine());

                            productos.Add(new Producto(code, desc, pre, dep, lik));
                            ProductoBD.WriteToTXT(name, productos);
                            Console.Clear();

                            Console.WriteLine("Los datos han sido guardados.");
                            Console.Clear();

                            Console.WriteLine("¿Desea agregar otro producto?");
                            Console.WriteLine("1 = Sí");
                            Console.WriteLine("2 = No");
                            i = 0; //Int32.Parse(Console.ReadLine());
            

            try
            {
                i = Int32.Parse(Console.ReadLine());
            }

            catch(FormatException fe8)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(fe8.Message);
            }
            catch(OverflowException ofe8)
            {
                Console.WriteLine("Debes escribir una de las dos opciones.");
                Console.WriteLine(ofe8.Message);
            }
            //Console.Clear();
                        }
                    }
                break;
            }
        }
    }
}