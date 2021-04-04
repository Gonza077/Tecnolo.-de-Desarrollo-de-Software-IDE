using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Clases
{
    public class A
    {
        private string NombreInstancia;

        /// <summary>
        /// Metodo contructor sin parametros
        /// </summary>
        public A()
        {
            NombreInstancia = "Instancia sin nombre";
            M1();
        }

        /// <summary>
        /// Metodo contructor con parametros
        /// </summary>
        public A( string parametro )
        {
            NombreInstancia = parametro;
            M2();
        }

        public void MostrarNombre()
        {
             Console.WriteLine("El nombre de la instancia es -> " +NombreInstancia);
            M3();
        }

        public void M1()
        {
            Console.WriteLine("Se invoco al metodo Constructor sin parametro");
        }

        public void M2()
        {
            Console.WriteLine("Se invoco al metodo Constructor con parametro");
        }

        public void M3()
        {
            Console.WriteLine("Se invoco el metodo MostrarNombre");
        }
    }
}
