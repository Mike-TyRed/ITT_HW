using System;
using System.Collections.Generic;

class Peliculas
	{
		private string Titulo;
		private int Año;
		private string Pais;
		private string Director;
		public void imprime()
			{
			Console.WriteLine(Titulo + Año + Pais + Director);
			}

			public  Peliculas(string t, int a, string p, string d)
			{
			this.Titulo = t;
			this.Año = a;
           	this.Pais = p;
           	this.Director = d;
			}
		}
		public class Program
		{
			static void Main(String[] args)
			{
				Console.WriteLine("|-----------------|-------------------------------------|");
				List<Peliculas> P = new List<Peliculas>();
				P.Add(new Peliculas("|Joker            |", 2019,  "|USA|", "Todd Phillips              |"));
				P.Add(new Peliculas("|Revenant         |", 2015, "|USA|", "Alejandro González Iñárritu|"));
				P.Add(new Peliculas("|Birdman          |", 2014, "|USA|", "Alejandro González Iñárritu|"));
				P.Add(new Peliculas("|La forma del agua|",2017 ,"|USA|" ,"Guillermo del Toro         |" ));
				P.Add(new Peliculas("|Gladiador        |", 1992,"|UK |", "Ridley Scott               |"));
				
				
				foreach(Peliculas a in P)
					{
					a.imprime();
					}
				Console.WriteLine("|------------------------------------------------------|");
			}    
    
}
