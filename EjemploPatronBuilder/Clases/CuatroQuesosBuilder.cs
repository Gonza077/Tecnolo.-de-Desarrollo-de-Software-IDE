using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    //Es un BuilderConcreto, el cual implementa el la clase abstracta PizzaBuilder
    //construye y ensambla el objeto Pizza
    public class CuatroQuesosBuilder : PizzaBuilder
    {
        #region Constructor
        public CuatroQuesosBuilder(string tamaño)
        {
            _pizza = new Pizza() { Tamaño = tamaño };
        }
        #endregion

        #region Metodos
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Cocido";
        }
        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Roquefort";
        }
        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "Mozzarela - Gorgonzola - Parmesano - Ricotta";
        }
        #endregion
    }
}
