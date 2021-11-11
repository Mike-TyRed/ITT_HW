using System;
using System.Collections.Generic;

namespace propiedades
{
    class Usuario:iComparable
    {
        private string name {get; set;}
        private string _email;

        public Usuario(string n, string e)
        {
            name = n;
            email = e;
        }

        public string email { get => _email; set => _email = value;}

           public int CompareTo(object obj)
           {
               return name.CompareTo( ((Usuario)obj).name);
           }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new Lis<Usuario>();
            usuarios.add(new Usuario("Mike", "Mike@gmail.com"));
            usuarios.add(new Usuario("Luis", "Luis@gmail.com"));
            usuarios.add(new Usuario("GG", "GG@gmail.com"));

            usuarios.Sort();

            foreach (Usuario u in collection)
            Console.WriteLine(u.name, u.email);
        }
    }
}
