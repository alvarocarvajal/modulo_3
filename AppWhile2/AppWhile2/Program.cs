using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador, suma, valor, promedio;

            Console.WriteLine("                            ");
            Console.WriteLine(" ===========================");
            Console.WriteLine(" Programa Utilizando While 2");
            Console.WriteLine(" ===========================");
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");


            contador = 1;
            suma = 0;
            while (contador <= 10)
            {
                Console.Write(" Ingrese un Numero: ");
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
                contador = contador + 1;
            }

            promedio = suma / 10;

            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine(" La Suma De Los 10 Numeros es: " + suma);
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");
            Console.WriteLine(" El Promedio De Los 10 Numeros Es: " + promedio);
            Console.WriteLine("                            ");
            Console.WriteLine("                            ");


            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();
        }
    }
}
