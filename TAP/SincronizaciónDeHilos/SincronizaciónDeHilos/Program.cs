using System;
using System.Threading.Tasks;
using System.Threading;

namespace SincronizaciónDeHilos
{
    class Imprimir
    {
        public void ImprimirNumeros()
        {
            //lock(this)
            Monitor.Enter(this);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine(i);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Monitor.Exit(this);
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sincronización de hilos";
            Console.WriteLine("Se realiza el multi hilo");
            Imprimir imp = new SincronizaciónDeHilos.Imprimir();

            Thread[] hilo = new Thread[3];
            
            for(int i = 0; i < 3; i++)
            {
                hilo[i] = new Thread(new ThreadStart(imp.ImprimirNumeros));
                hilo[i].Name = "Hilo hijo" + i;
            }
            foreach(Thread h in hilo)
            {
                h.Start();
            }
            Console.ReadKey();
        }
    }
}
