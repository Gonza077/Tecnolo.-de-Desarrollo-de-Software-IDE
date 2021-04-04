using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioPOO.Consola
{
    class JugadaConAyuda:Jugada
    {
        public JugadaConAyuda(int maxNumero):base(maxNumero)
        {
            
        }

        new public void Comparar(int numAdivina)
        {
            if (numAdivina == Numero)
            {
                Adivino = true;
            }
            else
            {
                Intentos++;
                Console.WriteLine("No has acertado,segui participando");
                if (Math.Abs(this.Numero - numAdivina)<5)
                {
                    Console.WriteLine("El numero ingresado esta muy cerca...");
                }
                else 
                    if (Math.Abs(this.Numero - numAdivina)>10 && this.Numero < numAdivina)
                    {
                    Console.WriteLine("El numero es menor y dista 10");
                    }
                    else if (Math.Abs(this.Numero - numAdivina) > 10 && this.Numero > numAdivina)
                    {
                    Console.WriteLine("El numero es mayor y dista 10");
                }
            }
        }

    }
}
