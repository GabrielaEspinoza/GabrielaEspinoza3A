using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9. Crear el programa tablaMultiplicar que escriba la tabla 
//de multiplicar del número 1 al número 15.

namespace Tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i<= 15; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", numero, i, (numero * i));
            }
            Console.ReadKey();
        }
    }
}
