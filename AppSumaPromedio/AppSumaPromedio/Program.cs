using System;

namespace AppSumaPromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			float numero1, numero2, numero3, numero4, suma, promedio ;
			String linea1, linea2, linea3, linea4;

			Console.WriteLine ("                                                     ");
			Console.WriteLine (" ====================================================");
			Console.WriteLine (" Programa Que Calcula La Suma Y Promedio De 4 Numeros");
			Console.WriteLine (" ====================================================");
			Console.WriteLine ("                                                     ");


			Console.Write (" Ingrese El Numero 1: ");
			numero1 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("                     ");

			Console.Write (" Ingrese El Numero 2: ");
			numero2 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("                     ");

			Console.Write (" Ingrese El Numero 3: ");
			numero3 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("                     ");

			Console.Write (" Ingrese El Numero 4: ");
			numero4 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("                     ");

			suma = (numero1 + numero2 + numero3 + numero4);
			promedio = (suma / 4);

			Console.WriteLine ("                                 ");
			Console.WriteLine ("                                 ");
			Console.Write (" la Suma De Los 4 Numeros Es: " + suma);
			Console.WriteLine ("                                 ");
			Console.WriteLine ("                                 ");

			Console.Write (" El Promedio De Los 4 Numeros Es: " + promedio);
			Console.WriteLine ("                                         ");
			Console.WriteLine ("                                         ");
			Console.WriteLine ("                                         ");
			Console.WriteLine ("                                         ");

			Console.WriteLine (" Elaboro Ing Alvaro Carvajal ");
			Console.WriteLine (" Universidad Simon Bolivar - Ext. Cucuta ");

			Console.ReadKey ();
		}
	}
}
