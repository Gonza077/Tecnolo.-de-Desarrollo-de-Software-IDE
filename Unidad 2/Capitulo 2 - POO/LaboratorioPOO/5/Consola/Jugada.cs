using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioPOO.Consola
{
    class Jugada
    {
        private bool m_adivino;
        private int m_intentos;
        private int m_numero;

        public bool Adivino
        {
            get => m_adivino;
            set
            {
                m_adivino = value;
            }
        }

        public int Intentos
        {
            get => m_intentos;
            set
            {
                m_intentos = value;
            }
        }

        public int Numero
        {
            get => m_numero;
            set
            {
                m_numero = value;
            }
        }

        public void Comparar(int numAdivina)
        {
            if (numAdivina == Numero)
            {
                Adivino = true;
            }
            else
            {
                Console.WriteLine("No has acertado,segui participando");
                Intentos++;
            }
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
            Intentos = 1;
            Adivino = false;
        }
    }
}
