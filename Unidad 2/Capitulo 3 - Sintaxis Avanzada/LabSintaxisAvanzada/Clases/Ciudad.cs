using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Clases
{
    public class Ciudad
    {
        private string m_Nombre, m_CodigoPostal;

        public string NombreCiudad
            {
                get => m_Nombre;
                set
                {
                m_Nombre = value;
                }
            }
        public string CodigoPostal
        {
            get => m_CodigoPostal;
            set
            {
                m_CodigoPostal = value;
            }
        }

        public Ciudad(string nombre,string codigoPostal)
        {
            NombreCiudad = nombre;
            CodigoPostal = codigoPostal;

        }
    }
}
