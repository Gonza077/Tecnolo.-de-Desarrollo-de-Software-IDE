using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    //Es un BuilderConcreto, el cual implementa el la clase abstracta PizzaBuilder
    //construye y ensambla el objeto Pizza
    class EspecialBuilder :PizzaBuilder
    {
        public EspecialBuilder(string tamaño)
        {
            _pizza = new Pizza() { Tamaño = tamaño };
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Tomate";
        }

        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Crocante";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "Jamon - Morron";
        }
    }
}
