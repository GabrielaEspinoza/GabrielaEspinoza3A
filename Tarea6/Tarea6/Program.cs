using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Modificar el ejercicio anterior para que aparezca un rombo. RESUELTO

namespace Tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el número de amplitud que tendra su rombo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                for (int a = numero; a < i; a++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            for (int i = numero; i >= 0; i--)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                for (int a = numero; a < i; a++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
