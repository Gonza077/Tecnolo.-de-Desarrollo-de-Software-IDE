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
            int cantIteraciones = 5;
            string[] vectCadenas;
            vectCadenas = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                System.Console.WriteLine("Ingrese el texto N°" + (i + 1));
                vectCadenas[i] = System.Console.ReadLine();
            }
            System.Console.Clear();
            System.Console.WriteLine("A continuacion se mostraran los textos \n");
            for (int i = 0; i < cantIteraciones; i++)
            {
                System.Console.WriteLine("Texto N°" + (i + 1) + " -> " + vectCadenas[i]);
            }
            System.Console.WriteLine("Pulse una tecla para finalizar");
            System.Console.ReadKey();
        }
    }
}
