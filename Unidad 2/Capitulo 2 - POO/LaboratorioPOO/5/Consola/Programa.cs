using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioPOO.Consola
{
    class Programa
    {
        static void Main()
        {
            //Console.WriteLine("Ingrese el numero maximo  para conocer el limite");
            //int numMax = Int32.Parse(Console.ReadLine());                
            Juego juego = new Juego(99);
            juego.ComenzarJuego();            
        }
    }
}
