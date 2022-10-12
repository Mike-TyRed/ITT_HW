using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Alumno
    {
        protected string name;
        protected int age;
        public int especialidad;

        public Alumno (string n, int a)
        {
            name = n;
            age = a;
        }

        public virtual void SS()
        {
            Console.WriteLine("Hace servicio social. ");
        }

        public virtual void Residencia()
        {
            Console.WriteLine("Hace residencia. ");
        }

        public virtual void inv()
        {
            Console.WriteLine("Tiene tema de investigación. ");
        }
        
        class Licenciatura:Alumno
        {
            protected string licenciatura;

            public licenciatura(string name, int age, string licenciatura):base(name, age)
            {
                this.licenciatura = licenciatura;
            }
            public override void SS()
            {
                Console.WriteLine("Hola soy {0}, tengo {1} años y estoy en {3} ", name, age, licenciatura);
            }
            public override void Residencia()
            {
                Console.WriteLine("Hola soy {0}, tengo {1} años y estoy en {3} ", name, age, licenciatura);
            }
        }
        class Posgrado:Alumno
        {
            protected string posgrado;

            public posgrado(string name, int age, string posgrado):base(name, age)
            {
                this.posgrado = posgrado;
            }
            public override void inv()
            {
                Console.WriteLine("Hola soy {0}, tengo {1} años y estoy en {3} ", name, age, posgrado);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Guitarrista("Mike",25, "Posgrado"));
            alumnos.Add(new Guitarrista("Luis", 30, "Posgrado"));
            alumnos.Add(new Guitarrista("Pepe", 27, "Licenciado"));
            alumnos.Add(new Guitarrista("Jackie", 20 , "Licenciado"));
            alumnos.Add(new Guitarrista("Alan", 26 ,"Posgrado"));

            foreach(Alumno a in alumnos)
            {
                m.SS();
                m.Residencia();
                m.inv();
            }
        }
    }
}
