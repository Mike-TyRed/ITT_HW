using System;
using System.Collections.Generic;

namespace ilustra
{
    interface IDibujable
    {
        int X {get; set;}
        int Y {get; set;}
        string Color{get; set;}

        void Dibuja();
        void PrintColor();
    }

    class Circulo:IDibujable
    {
        int x, y;
        string color;
        public Circulo(int x, int y, string c)
        {
            this.x=x;
            this.y=y;
            this.color=c;
        }

        public int X {get => x; set => x = value;}
        
        public int Y {get => y; set => y = value;}

        public string Color {get => color; set => color = value;}
        
        public void Dibuja()
        {
            Console.WriteLine("Se dibuja un círculo {0}", Color);
        } 
        public void PrintColor()
        {
            Console.WriteLine("De color {0}", Color);
        }
    }
    class Rect:IDibujable
    {
        int x, y;
        string color;
        public Rect(int x, int y, string c)
        {
            this.x=x;
            this.y=y;
            this.color=c;
        }

        public int X {get => x; set => x = value;}
        
        public int Y {get => y; set => y = value;}

        public string Color {get => color; set => color = value;}
        
        public void Dibuja()
        {
            Console.WriteLine("Se dibuja un rectángulo {0}", Color);
        } 
        public void PrintColor()
        {
            Console.WriteLine("De color {0}", Color);
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            List<IDibujable> figuras = new List<IDibujable>();
            figuras.Add(new Circulo(12, 13, "Rojo"));
            figuras.Add(new Circulo(12, 13, "Azúl"));
            figuras.Add(new Rect(12, 13, "Azúl"));
            figuras.Add(new Rect(12, 13, "Rojo"));
            

            foreach(var f in figuras){f.Dibuja();}

            Circulo e = new Circulo(10,10,"Blanco");
            e.Dibuja();

            Rect r = new Rect(10,10,"Negro");
            r.Dibuja();
            

        }
    }
}