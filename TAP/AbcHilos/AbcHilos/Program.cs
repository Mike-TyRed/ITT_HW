using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AbcHilos
{
    class Program
    {
        public void ImprimirA()
        {
            lock (this)
            {

                Console.WriteLine("Numero de hilo   | letra");
                for (int i = 97; i < 123; i++)
                {
                    //Thread.Sleep(1000);
                    Console.WriteLine("     {0}          |   {1}", Thread.CurrentThread.Name.ToString(), (char)i);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Title = "Abecedario con hilos";
            Console.WriteLine("Abecedario");
            Program ABC = new AbcHilos.Program();

            Thread[] hilo = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                hilo[i] = new Thread(new ThreadStart(ABC.ImprimirA));
                hilo[i].Name = "" + (i + 1);
            }
            foreach (Thread h in hilo)
            {
                h.Start();
            }
            Console.ReadKey();
            ABC.ImprimirA();
        }
    }
}