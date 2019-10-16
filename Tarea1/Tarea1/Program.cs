using System;
//1. Programa que lea una serie de números por teclado e indique cuál es el mayor. RESUELTO

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int numero;
            int mayor = 0;
            Console.Write("Digite la cantidad de número a usar:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < cantidad; j++)
            {
                Console.WriteLine("Ingrese numero:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (j == 0)
                {
                    mayor = numero;
                }
                else if (j == 0)
                {
                }
                if (numero > mayor)
                {
                    mayor = numero;
                }
            }
            Console.WriteLine("El numero mayor es;" + mayor);
            Console.ReadKey();

        }
    }
}









