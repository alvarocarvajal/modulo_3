using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("                             ");
            Console.WriteLine(" ============================");
            Console.WriteLine(" Programa Utilizando Switch 2");
            Console.WriteLine(" ============================");
            Console.WriteLine("                             ");

            Console.Write(" Digite Un Numero Del 1 al 5: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    Console.WriteLine(" El Numero Digitado Fue << UNO >> ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case 2:
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    Console.WriteLine(" El Numero Digitado Fue << DOS >> ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case 3:
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    Console.WriteLine(" El Numero Digitado Fue << TRES >> ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case 4:
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    Console.WriteLine(" El Numero Digitado Fue << CUATRO >> ");
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    break;

                case 5:
                    Console.WriteLine("                          ");
                    Console.WriteLine("                          ");
                    Console.WriteLine(" El Numero Digitado Fue << CINCO >> ");
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
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();
        }
    }
}
