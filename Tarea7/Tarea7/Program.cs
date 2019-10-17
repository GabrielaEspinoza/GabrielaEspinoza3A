using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al
//100, en la segunda los números del 100 al 1   RESUELTO
namespace Tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite el numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(+i);
            }
            Console.WriteLine();
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine( +i);
            }
            Console.ReadKey();
        }

    }
}


