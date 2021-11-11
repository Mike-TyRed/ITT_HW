using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_RadixSort
{
    class Program
    {
        static int [] Sorteo = new int [50];    //dato, arreglo
        static IList <IList<int>> Urnas = new List<IList<int>>(); //digitos,List
        static Random r = new Random();
        static int max = 0;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Radix Sort: Sorteo aleatorio.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para iniciar.");
            Console.ReadKey();

            Console.Clear();

            for (int x = 0; x < Sorteo.Length; x++)
            {
                Urnas.Add(new List<int>());//Generando las urnas
            }

            for(int x = 0; x < Sorteo.Length; x++)
            {
                Sorteo[x] = r.Next(0,1000);
                if(max < Sorteo[x].ToString().Length)
                    max = Sorteo[x].ToString().Length;
            }

            Console.WriteLine("Ordenado por ingreso.");
            foreach (int so in Sorteo)
            {
                Console.WriteLine(so);
            }
            Console.ReadKey();
            RadixSort();
        }
        public static void RadixSort()
        {
            for(int i = 0; i < max; i++)
            {
                for (int j = 0; j < Sorteo.Length; j++)
                {
                    int u = (int)((Sorteo[j] % Math.Pow(50,i+1))/Math.Pow(50,i));
                    Urnas[u].Add(Sorteo[j]);
                }
                int indice = 0;
                for(int k = 0; k < Urnas.Count; k++)
                {
                    IList<int> su = Urnas[k];
                    for (int l = 0; l < su.Count; l++)
                    {
                        Sorteo[indice++] = su[l];
                    }
                }
                Limpiar();
            }
            Imprimir();
        }
        public static void Limpiar()
        {
            for (int m = 0; m < Sorteo.Length; m++)
            {
                Urnas[m].Clear();
            }
        }
        public static void Imprimir()
        {
            Console.WriteLine("Ordenado Raíz Sort.");
            for (int n = 0; n < Sorteo.Length; n++)
            {
                Console.WriteLine(Sorteo[n]);
            }
        }
    }
}