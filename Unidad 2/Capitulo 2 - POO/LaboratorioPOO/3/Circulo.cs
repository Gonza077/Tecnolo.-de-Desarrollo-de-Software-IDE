using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => m_radio;
            set
            {
                m_radio = value;
            }
        }

        public void CalcularPerimetro()
        {
           Console.WriteLine("El permitro del circulo es ->" +(Radio* Math.PI*2));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine((Radio^2)*Math.PI);
        }
    }
}
