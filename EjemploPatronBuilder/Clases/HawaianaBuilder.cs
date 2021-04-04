using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    //Es un builderConcreto, el cual implementa el la clase abstracta PizzaBuilder
    //construye y ensambla el objeto Pizza
    public class HawaianaBuilder : PizzaBuilder
    {
        #region Consturctores
        public HawaianaBuilder(string tamaño)
        {
            _pizza = new Pizza{Tamaño = tamaño};
            //_pizza pertenece a la clase abstracta, la cual se construye aqui
        }
        #endregion

        #region Metodos
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "Piña - Tomate - Jamón";
        }
        #endregion
    }
}
