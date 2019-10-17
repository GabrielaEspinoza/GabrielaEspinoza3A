using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que muestre un menú como este:
//1) Salir
//2) Sumatorio
//3) Factorial
//Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba.Si se
//elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial(en ambos casos el programa
//pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la
//factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente. RESUELTO
namespace Tarea10
{
    class Program
    {
        static void Main(string[] args)
        {        int Operador = 0;
                 string Data = "";
            do
            {
                Console.WriteLine("Menú  \n" +
                " \n 1) Salir" +
                " \n 2) Sumatorio" +
                " \n 3) factorial \n");

            int  Opcion = 0;
            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    Console.WriteLine("Opción salir (1)");
                    break;
                case 2:
                    Console.WriteLine("Opción Sumatoria (2)");
                    break;
                case 3:
                    Console.WriteLine("Opción Factorial (3)");
                    break;

            }
                Data = Console.ReadLine();
                Operador = Convert.ToInt32(Data);
                if ( Operador == 1 ||Operador == 2 || Operador == 3)
                {

                    if (Operador == 1)
                    {
                      Console.WriteLine("Salir");
                    }
                    else
                    {
                        if (Operador == 2)
                        {
                            int Number1 = 0, primero = 0, segundo = 1;
                            string Data2 = "";
                            Console.WriteLine("Ingrese valores: ");
                            Data2 = Console.ReadLine();
                            Number1 = Convert.ToInt32(Data2);
                            for (int i = 0; i <= Number1 - 1; i++)
                            {
                                Console.Write("{0,8}\t", segundo);
                                primero = primero + segundo;
                                segundo = segundo + 1;

                            }
                            Console.WriteLine("La Sumatoria es: \n {0,10:N0}", primero);
                        }
                        else
                        {

                        }
                        if (Operador == 3)
                        {
                            int Number2 = 0, fac = 2;
                            double Number3 = 1;
                            string Data4 = "";
                            Console.WriteLine("Ingrese valor:");
                            Data4 = Console.ReadLine();
                            Number2 = Convert.ToInt32(Data4);
                            while (fac <= Number2)
                            {
                                Number3 *= fac;
                                fac++;

                            }
                            Console.WriteLine("La Factorizacion da:\n {0:N0}", Number3);
                        }
                    }

                }
                else
                {
                }

            } while (Operador != 1);
            Console.ReadKey();
        }
    }
 }
    


            
            