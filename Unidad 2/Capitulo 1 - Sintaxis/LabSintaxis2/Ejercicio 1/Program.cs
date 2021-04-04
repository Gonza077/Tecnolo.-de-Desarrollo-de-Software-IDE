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
         
            #region Ejercicio 1.3
            /*
            string inputTexto;
            System.Console.WriteLine("Ingrese el texto");
            inputTexto = System.Console.ReadLine();
            if (inputTexto == null)
            {
                System.Console.WriteLine("No se ingreso el texto");
                System.Console.ReadKey();
            }
            else 
            {
                
                System.Console.WriteLine("El texto ingresado es : ");
                System.Console.WriteLine(inputTexto);
                System.Console.ReadKey();
            }*/
            #endregion

            #region Ejercicio 1.4
            /*
            string inputTexto;
            System.Console.WriteLine("Ingrese el texto");
            inputTexto = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese opcion");
            System.Console.WriteLine("1 - Texto en Minusculas");
            System.Console.WriteLine("2 - Texto en Mayusculas");
            System.Console.WriteLine("3 - Visualizar cantidad de caracteres ingresados");
            ConsoleKeyInfo opcion = Console.ReadKey(); 
            System.Console.WriteLine("\n");
            if (opcion.KeyChar == '1')
            {
                System.Console.WriteLine("El texto en Minusculas -> "+ inputTexto.ToLower());
                System.Console.ReadKey();
            }  
            else if(opcion.KeyChar == '2')
            {
                System.Console.WriteLine("El texto en Mayusculas -> " + inputTexto.ToUpper());
                System.Console.ReadKey();
            }
                else if (opcion.KeyChar == '3')
                    {
                    System.Console.WriteLine("Cantidad de caracteres -> " + inputTexto.Length);
                    System.Console.ReadKey();
                    }
            */
            #endregion

            #region Ejercicio 1.5
            /*
            string inputTexto;
            System.Console.WriteLine("Ingrese el texto");
            inputTexto = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese opcion");
            System.Console.WriteLine("1 - Texto en Minusculas");
            System.Console.WriteLine("2 - Texto en Mayusculas");
            System.Console.WriteLine("3 - Visualizar cantidad de caracteres ingresados");
            ConsoleKeyInfo opcion = Console.ReadKey();
            System.Console.WriteLine("\n");
            if (opcion.Key == ConsoleKey.NumPad1)
            {
                System.Console.WriteLine("El texto en Minusculas -> " + inputTexto.ToLower());
                System.Console.ReadKey();
            }
            else if (opcion.Key == ConsoleKey.NumPad2)
                    {
                     System.Console.WriteLine("El texto en Mayusculas -> " + inputTexto.ToUpper());
                     System.Console.ReadKey();
                    }
                else if(opcion.Key == ConsoleKey.NumPad3)
                    {
                        System.Console.WriteLine("Cantidad de caracteres -> " + inputTexto.Length);
                        System.Console.ReadKey();
                    }
                    else
                     {
                        System.Console.WriteLine("Opcion ingresada no es valida");
                     }
            */
            #endregion
            
        }
    }
}
