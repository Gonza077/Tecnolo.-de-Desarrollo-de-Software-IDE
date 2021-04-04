using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    // La clase PizzaBuilder seria el builder, es quien debe saber que tipo de objeto se instancia
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public string Tamaño { get; set; }

        #region Constructores
        public Pizza ObtenerPizza()
        {
            return _pizza;
        }
        #endregion

        #region Metodos
        public virtual void PasoPrepararMasa()
        { }
        public virtual void PasoAñadirSalsa()
        { }
        public virtual void PasoPrepararRelleno()
        { }
        #endregion
    }
}
