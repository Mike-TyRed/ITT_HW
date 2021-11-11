using System;
using System.Collections.Generic;

namespace herencia
{
     abstract class Musico
    {
        protected string name;

        public  Musico(string n)
        {  
            name = n;
        }

        public abstract void Saludo();
        
        public abstract void afina();
        
        public abstract void toca();
        
    }
    class Baterista:Musico
    {
        protected string bateria;

        public Baterista(string name, string bateria):base(name)
        {
            this.bateria = bateria;
        }
        public override void Saludo()
        {
            Console.WriteLine("Hola soy {0} y toco la {1}", name, bateria);
        }
        public override void afina()
        {
            Console.WriteLine("*Afina su instrumento*");
        }
        public override void toca()
        {
            Console.WriteLine("*Empieza a tocar*");
        }
    }
    class Bajista:Musico
    {
        protected string bajista;

        public Bajista(string name, string bajista):base(name)
        {
            this.bajista = bajista;
        }
        public override void Saludo()
        {
            Console.WriteLine("Hola soy {0} y toco el {1}", name, bajista);
        }
        public override void afina()
        {
            Console.WriteLine("*Afina su instrumento*");
        }
        public override void toca()
        {
            Console.WriteLine("*Empieza a tocar*");
        }
    }
    class Guitarrista:Musico
    {
        protected string guitarra;        

        public Guitarrista(string name, string guitarra):base(name)
        {
            this.guitarra = guitarra;
        }
        public override void Saludo()
        {
            Console.WriteLine("Hola soy {0} y toco la {1}", name, guitarra);
        }
        public override void afina()
        {
            Console.WriteLine("*Afina su instrumento*");
        }
        public override void toca()
        {
            Console.WriteLine("*Empieza a tocar*");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
    //        Musico Mike = new Musico("Mike");
    //        Mike.Saludo();

            Baterista Fer = new Baterista("Fer", "Batería");
            Bajista Vlady = new Bajista ("Vlady", "Bajo");
            
            List<Musico> musicos = new List<Musico>();
    //        musicos.Add(Mike);
            musicos.Add(Fer);
            musicos.Add(Vlady);
            musicos.Add(new Guitarrista("Pepe", "Guitarra"));
            
            foreach(Musico m in musicos)
            {
                m.Saludo();
                m.afina();
                m.toca();
            }

        }
    }
}
