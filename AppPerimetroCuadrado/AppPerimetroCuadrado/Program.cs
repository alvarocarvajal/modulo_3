using System;

namespace AppPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, perimetro;
			string linea;

			Console.WriteLine ("                                                 ");
			Console.WriteLine (" ================================================");
			Console.WriteLine (" Programa Que Calcula El Perimetro De Un Cuadrado");
			Console.WriteLine (" ================================================");
			Console.WriteLine ("                                                 ");


			Console.Write (" Ingrese El Lado Del Cuadrado: ");
			linea=Console.ReadLine ();
			lado = float.Parse (linea);
			perimetro = (4 * lado);

			Console.WriteLine ("                                           ");
			Console.WriteLine ("                                           ");
			Console.Write (" El Perimetro Del Cuadrado Es: " + perimetro);

			Console.ReadKey ();
		}
	}
}
