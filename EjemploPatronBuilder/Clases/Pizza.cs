using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronBuilder.Clases
{
    public class Pizza
    {
        #region Propiedades
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamaño { get; set; }
        #endregion

        #region Constructores
        public Pizza()
        { }

        public Pizza(string tamaño, string masa, string salsa, string relleno)
        {
            Tamaño = tamaño;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
        }
        #endregion
    }
}
