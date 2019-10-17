using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Crear un programa que lea cantidades y precios y al final indique el total de la factura.
//Primero se pregunta:
//Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.
//Después se pregunta:
//Introduzca el precio que será un número decimal positivo.
//La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total. RESUELTO
namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cantidad = 0, ubicacion = 0;
            double precio = 0, total = 0, pago = 0;
            char opciones;
            string producto;
            string linea;
            ubicacion = 6;
            Console.SetCursorPosition(6, 4);
            Console.Write("Producto Cantidad Precio Total");
            do
            {
                Console.SetCursorPosition(6, ubicacion);
                producto = Console.ReadLine();
                Console.SetCursorPosition(16, ubicacion);
                linea = Console.ReadLine();

                cantidad = int.Parse(linea);
                Console.SetCursorPosition(23, ubicacion);
                linea = Console.ReadLine();

                precio = int.Parse(linea);
                total = cantidad * precio;
                Console.SetCursorPosition(30, ubicacion);
                Console.Write(total);
                pago = pago + total;
                ubicacion = ubicacion + 1;
                Console.SetCursorPosition(40, 5);
                linea = Console.ReadLine();
                opciones = char.Parse(linea.ToUpper());
            } while (opciones.ToString().Contains("0"));
            Console.WriteLine("Total:" + pago);
            
        }
    }
}
        
