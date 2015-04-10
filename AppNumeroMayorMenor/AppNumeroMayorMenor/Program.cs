using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeroMayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, suma, resta, producto, division ;

            Console.WriteLine("                                                   ");
            Console.WriteLine(" ==================================================");
            Console.WriteLine(" Programa Que Calcula Si Un Numero Es Mayor O Menor");
            Console.WriteLine(" ==================================================");
            Console.WriteLine("                                                   ");

            Console.WriteLine("                    ");
            Console.Write(" Ingrese Numero 1: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("                    ");
            Console.Write(" Ingrese Numero 2: ");
            numero2 = float.Parse(Console.ReadLine());

            suma     = (numero1 + numero2);
            resta    = (numero1 - numero2);
            producto = (numero1 * numero2);
            division = (numero1 / numero2);

            if(numero1 > numero2)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine(" ¡¡¡ El Numero 1 Es Mayor Que El 2 !!!!! ");
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine(" La Suma De Los 2 Numeros Es: " + suma);
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine(" La Resta De Los 2 Numeros Es: " + resta);

            }

            else
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine(" ¡¡¡ El Numero 1 Es Menor Que El 2 !!!!! ");
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine(" El Producto De Los 2 Numeros Es: " + producto);
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine(" La Division De Los 2 Numeros Es: " + division);
            }


            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro Ing Alvaro Carvajal ");
            Console.WriteLine(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();
        }
    }
}
