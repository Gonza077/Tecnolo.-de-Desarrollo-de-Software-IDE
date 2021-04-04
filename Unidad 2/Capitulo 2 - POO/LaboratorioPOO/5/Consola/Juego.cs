using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioPOO.Consola
{
    class Juego
    {
        private int m_record=9999;      
        private int m_maxValor;

        public Juego(int valor)
        {
            m_maxValor = valor;
        }
        public void ComenzarJuego()
        {   
            ConsoleKeyInfo opcionMenu,opcPartida;
            //Jugada jugada = new Jugada(this.m_maxValor);
            JugadaConAyuda jugada = new JugadaConAyuda(this.m_maxValor);
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese opcion");
                Console.WriteLine("1    - Para adivinar el numero");
                Console.WriteLine("2    - Visualizar record de menor cantidad de aciertos");
                //Console.WriteLine("3 - Para visualizar el numero a adivinar");
                Console.WriteLine("ESC  - Para salir del juego");
                opcionMenu = Console.ReadKey();
                Console.WriteLine("\n");
                switch (opcionMenu.Key)
                {   
                    case ConsoleKey.NumPad1:                                                                  
                        Continuar(jugada);                        
                        do
                        {
                            if (jugada.Adivino == false)
                            {
                                Console.WriteLine("Desea continuar partida (Y)/(N)");
                                opcPartida = Console.ReadKey();
                                switch (opcPartida.Key)
                                {
                                    case (ConsoleKey.Y):
                                        Continuar(jugada);                                       
                                        break;
                                    case (ConsoleKey.N):
                                        //jugada = new Jugada(this.m_maxValor);
                                        jugada = new JugadaConAyuda(this.m_maxValor);
                                        break;
                                    default:                                      
                                        break;
                                }
                            }
                            else 
                            {
                                //jugada = new Jugada(this.m_maxValor);
                                jugada = new JugadaConAyuda(this.m_maxValor);
                                break;
                            }
                        } while (opcPartida.Key!= ConsoleKey.N);                                     
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        PreguntarMaximo();
                        break;
                    /*case ConsoleKey.NumPad3:
                        Console.Clear();
                        PreguntarNumero(jugada);
                        break;*/
                    case ConsoleKey.Escape:
                        System.Console.WriteLine("Saliendo el programa... Pulse una tecla para finalizar");
                        System.Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        break;
                }               
            } while (opcionMenu.Key != ConsoleKey.Escape);       
        }
        private void Continuar(JugadaConAyuda jugada)
        {
            int numAdivina;
            numAdivina = PreguntarNumero();
            jugada.Comparar(numAdivina);
            if (jugada.Adivino == true)
                 {
                    CompararRecord(jugada);
                 }
        }
        private void CompararRecord(JugadaConAyuda jugada)
        {
            if (jugada.Intentos <= m_record)
            {
                m_record = jugada.Intentos;
                Console.Clear();
                Console.WriteLine("Haz acertado!!");
                Console.WriteLine("Nuevo record obtenido!!");
                Console.WriteLine("Cantidad de intentos -> " + jugada.Intentos);
                Console.WriteLine("Se creara una nueva partida");
                Console.WriteLine("Pulse una tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Haz acertado!!");
                Console.WriteLine("Cantidad de intentos -> " + jugada.Intentos);
                Console.WriteLine("Pulse una tecla para continuar...");
                Console.ReadKey();
            }
        }
        private void PreguntarMaximo()
        {   
            if (m_record==9999)
            { 
                Console.WriteLine("No hay record registrado hasta el momento");
                Console.WriteLine("Pulse una tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El record hasta el momento es -> " + this.m_record);
                Console.WriteLine("Pulse una tecla para continuar...");
                System.Console.ReadKey();
            }          
        }
        private int PreguntarNumero()
        {
            int numAdivina;
            Console.Clear();
            Console.WriteLine("Los posibles valores a adivinar van desde 0 hasta " + this.m_maxValor);
            Console.WriteLine("Ingrese Numero a adivinar");
            do
            {
                numAdivina = Int32.Parse(Console.ReadLine());
                if (numAdivina < 0)
                {
                    Console.WriteLine("Numero ingresado negativo, no es valido");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey();
                    numAdivina = PreguntarNumero();

                }
                else if (numAdivina > this.m_maxValor)
                {
                    Console.WriteLine("El numero ingresado exede el maximo a adivinar, no es valido");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.ReadKey();
                    numAdivina = PreguntarNumero();
                }
            } while (!(numAdivina >= 0 && numAdivina <= this.m_maxValor));
            return numAdivina;
        }
    }
}
