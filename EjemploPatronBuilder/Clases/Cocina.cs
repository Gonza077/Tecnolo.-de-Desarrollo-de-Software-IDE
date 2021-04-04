using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    //Cocina es la clase directora, quiere decir que es la encargada de crear el builder y instanciarlo
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        #region Metodos

        /// <summary>
        /// Recibe el objeto pizza instanciado con su respectivo tamaño
        /// </summary>
        /// <param name="pizzaBuilder"></param>
        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        /// <summary>
        /// Se prepara la masa, salsa y relleno de la pizza
        /// </summary>
        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAñadirSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }       
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna la pizza 
        /// </summary>
        public Pizza PizzaPreparada
        {
            get => _pizzaBuilder.ObtenerPizza();
        }
        #endregion
    }
}
