using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4. Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares
//por hora si éstas no superan las 35 horas.Cada hora por encima de 35 se considerará extra y se paga a
//22 dólares.
//El programa pide las horas del trabajador y devuelve el salario que se le debe pagar. RESUELTO
namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, Hextra ;
            int repetir;
            double salario, Sextra, Stotal;
            do
            {
                Console.WriteLine("Ingrese el total de horas que trabajó:");
                horas = Convert.ToInt32(Console.ReadLine());
                if (horas <= 35)
                {
                    salario = horas * 15;
                    Console.WriteLine("Horas trabajadas {0} Hrs" + horas);
                }
                else
                {
                    Hextra = horas - 35;
                    Sextra = horas * 22;
                    salario = horas - Hextra;
                    Stotal =  Sextra * 35;
                    salario = Sextra + Stotal;
                    Console.WriteLine("Horas trabajadas {0} Hrs" + horas);
                }
                Console.WriteLine("El salario total es :" + salario);
                Console.WriteLine();
                Console.WriteLine(" ¿Desea calcular un nuevo salario? Digite 0 ");
                repetir = Convert.ToInt32(Console.ReadLine());


            } while (repetir == 0);
            Console.ReadKey();
        }
    }
}
