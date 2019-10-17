using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8. Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. La primera
//cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos
//en dos y la tercera de tres.
namespace Tarea8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite la cantidad: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2=0, num3=0, num4=0;
            do
            {
                num2++;
                num3 = num3 + 2;
                num4 = num4 + 3;
                Console.WriteLine(num2+"      " +num3+ "      " +num4+ "      ");
                num1++;
            } while (num1 < numero);
            Console.ReadKey();
            }
        }
    }



