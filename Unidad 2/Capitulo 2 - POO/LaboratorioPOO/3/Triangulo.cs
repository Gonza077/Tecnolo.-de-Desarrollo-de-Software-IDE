using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria.Geometria.Triangulo
{
    public class Triangulo
    {
        private float m_base, m_altura;

        public float Altura
        {
                get => m_altura;
            set
            {
                m_altura = value;
            }
        }

        public float Base
        {
            get => m_base;
            set
            {
                m_base = value;
            }

        }
        public void CalcularPerimetro()
        {
            Console.WriteLine("El permitro del triangulo es ->" + (3 * Base));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("La superficie del triangulo es -> " + (Base * Altura / 2));
        }
    }
}
