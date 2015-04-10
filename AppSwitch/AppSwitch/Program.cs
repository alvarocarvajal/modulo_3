using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero;

            Console.WriteLine("                           ");
            Console.WriteLine(" ==========================");
            Console.WriteLine(" Programa Utilizando Switch");
            Console.WriteLine(" ==========================");
            Console.WriteLine("                           ");

            Console.Write(" Digite El Numero En letras Del 1 al 5: ");
            numero = Console.ReadLine();

            switch(numero.ToUpper())
            {
                case "UNO":
                    Console.WriteLine(" El Numero Digitado Fue 1 ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case "DOS":
                    Console.WriteLine(" El Numero Digitado Fue 2 ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case "TRES":
                    Console.WriteLine(" El Numero Digitado Fue 3 ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case "CUATRO":
                    Console.WriteLine(" El Numero Digitado Fue 4 ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case "CINCO":
                    Console.WriteLine(" El Numero Digitado Fue 5 ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                default:
                    Console.WriteLine("                                          ");
                    Console.WriteLine("                                          ");
                    Console.WriteLine(" ¡¡¡ Numero Fuera Del Rango permitido !!! ");
                    Console.WriteLine("                                          ");
                    Console.WriteLine("                                          ");
                    Console.WriteLine("        ¡¡¡ Intentelo De Nuevo !!! ");
                    Console.WriteLine("                          ");
                    break;
                }

            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro Ing Alvaro Carvajal ");
            Console.WriteLine(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();

        }
    }
}
