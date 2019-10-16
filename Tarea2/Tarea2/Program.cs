using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese
//tamaño.Los asteriscos sólo se verán en el borde del cuadrado, no en el interior
//RESUELTO
namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el número de amplitud que tendra su cuadrado :");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                for (int b = 0; b < numero; b++)
                {
                    Console.Write("  *  ");
                }
                for (int a = 0; a < numero; a++)
                {
                    Console.WriteLine();      
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }

}

