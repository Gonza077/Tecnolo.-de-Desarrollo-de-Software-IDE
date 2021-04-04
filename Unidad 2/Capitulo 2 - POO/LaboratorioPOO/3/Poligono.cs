using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria.Geometria
{
    public class Poligono
    {
        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Rectangulo:Poligono
    {
        private float m_base, m_lado;
        
        public Rectangulo()
        {            
            Console.WriteLine("Ingrese base del rectangulo");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura del lado");
            Lado = float.Parse(Console.ReadLine());
        }

        
        public float Base
        {
            get => m_base;
            set
            {
                m_base = value;
            }
        }
        public float Lado
        {
            get => m_lado;
            set
            {
                m_lado = value;
            }
        }

        new public void CalcularPerimetro()
        {
            Console.WriteLine("El permitro del cuadrado es -> " + ((2 * Base) + (2 * Lado)));
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();

        }

        new public void CalcularSuperficie()
        {
            Console.WriteLine("El area del cuadrado es -> " + (Base * Lado));
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }

    }

    public class Cuadrado : Rectangulo 
    {
        public Cuadrado()
        {          
            Console.WriteLine("Ingrese area del cuadrado");
            Base= float.Parse(Console.ReadLine());
            Lado = Base;
        }

        new public void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro del cuadrado es -> " + (4 * Base));
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
        new public void CalcularSuperficie()
        {
            Console.WriteLine("El area del cuadrado es -> " + ( Base * Base));
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}