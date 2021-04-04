using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 2
            string inputTexto;
            ConsoleKeyInfo opcion;
            System.Console.WriteLine("Ingrese el texto");
            inputTexto = System.Console.ReadLine();
            do
            {
                System.Console.Clear();
                System.Console.WriteLine("El texto ingresado es -> " + inputTexto + "\n");
                System.Console.WriteLine("Ingrese opcion");
                System.Console.WriteLine("1 - Texto en Minusculas");
                System.Console.WriteLine("2 - Texto en Mayusculas");
                System.Console.WriteLine("3 - Visualizar cantidad de caracteres ingresados");
                System.Console.WriteLine("ESC - para finalizar");
                opcion = Console.ReadKey();          
                System.Console.WriteLine("\n");
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        System.Console.WriteLine("El texto en Minusculas -> " + inputTexto.ToLower());
                        System.Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        System.Console.WriteLine("El texto en Mayusculas -> " + inputTexto.ToUpper());
                        System.Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        System.Console.WriteLine("Cantidad de caracteres -> " + inputTexto.Length);
                        System.Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        System.Console.WriteLine("Saliendo el programa... Pulse una tecla para finalizar");
                        System.Console.ReadKey();
                        break;
                    default:
                        System.Console.WriteLine("Opcion ingresada no es valida");
                        System.Console.ReadKey();
                        break;
                }
            } while (opcion.Key != ConsoleKey.Escape);
            #endregion
        }
    }
}
