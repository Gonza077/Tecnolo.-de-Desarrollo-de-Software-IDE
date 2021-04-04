using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    class ProgramaPrincipal
    {
        static void Main()
        {
            Cocina cocina = new Cocina();
           
            cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder("Familiar"));
            cocina.CocinarPizzaPasoAPaso();
            Pizza pizzaCuatroQuesos = cocina.PizzaPreparada;
            
            Console.WriteLine("La pizza Cuatro Quesos tiene:\n \tTamaño: {0}\n\tRelleno: {1}\n\tSalsa: {2}\n\tMasa: {3}\n", pizzaCuatroQuesos.Tamaño, pizzaCuatroQuesos.Relleno, pizzaCuatroQuesos.Salsa, pizzaCuatroQuesos.Masa);
            
            cocina.RecepcionarProximaPizza(new HawaianaBuilder("Mediana"));
            cocina.CocinarPizzaPasoAPaso();
            Pizza pizzaHawaiana = cocina.PizzaPreparada;        
            
            Console.WriteLine("La pizza Hawaiana tiene:\n \tTamaño: {0}\n\tRelleno: {1}\n\tSalsa: {2}\n\tMasa: {3}\n", pizzaHawaiana.Tamaño, pizzaHawaiana.Relleno, pizzaHawaiana.Salsa, pizzaHawaiana.Masa);           
                     
            cocina.RecepcionarProximaPizza(new EspecialBuilder("Grande"));
            cocina.CocinarPizzaPasoAPaso();           
            Pizza pizzaEspecial = cocina.PizzaPreparada;
            
            Console.WriteLine("La pizza Especial tiene:\n \tTamaño: {0}\n\tRelleno: {1}\n\tSalsa: {2}\n\tMasa: {3}\n", pizzaEspecial.Tamaño, pizzaEspecial.Relleno, pizzaEspecial.Salsa, pizzaEspecial.Masa);
            Console.ReadKey();
            
            Console.Clear();
            Console.WriteLine("Eso fue todo amigos!!");
            Console.ReadKey();
        }
    }
}
