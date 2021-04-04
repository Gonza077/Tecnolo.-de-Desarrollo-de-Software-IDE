using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.Geometria;

namespace Geometria.Consola
{
    class Program
    {
        static void Main()
        {
            Cuadrado cuad= new Cuadrado();
            cuad.CalcularPerimetro();
            cuad.CalcularSuperficie();
        }
    }
}
