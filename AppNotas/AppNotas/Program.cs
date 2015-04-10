using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio, suma ;

            Console.WriteLine("                                           ");
            Console.WriteLine(" ==========================================");
            Console.WriteLine(" Programa Que Calcula Si Aprobo El Semestre");
            Console.WriteLine(" ==========================================");
            Console.WriteLine("                                           ");

            Console.WriteLine("                    ");
            Console.Write(" Digite Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("                    ");
            Console.Write(" Digite Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("                    ");
            Console.Write(" Digite Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            suma = (nota1 + nota2 + nota3);

            promedio = (suma / 3);
            if(promedio>=3)
             {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("                              "); 
                Console.WriteLine(" ¡¡¡ Aprobo El Semestre !!!!! ");
                Console.WriteLine("                              ");
                Console.WriteLine(" Su Promedio Fue: " + promedio);
             }

            else
            {
                Console.WriteLine("                               ");
                Console.WriteLine("                               ");
                Console.WriteLine("                               ");
                Console.WriteLine(" ¡¡¡ Reprobo El Semestre !!!!! ");
                Console.WriteLine("                               ");
                Console.WriteLine(" Su Promedio Fue: " + promedio);
            }

            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro Ing Alvaro Carvajal ");
            Console.WriteLine(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();
        }
    }
}
