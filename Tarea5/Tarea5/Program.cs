using System;
//5. Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de
//asteriscos.Por ejemplo, si se introduce el 6, el resultado sería:
// RESUELTO 
namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el número de amplitud que tendra su prirámide:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write(" * ");
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
