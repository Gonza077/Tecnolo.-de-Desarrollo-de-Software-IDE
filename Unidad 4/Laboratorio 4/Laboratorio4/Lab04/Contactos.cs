using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Laboratorio4.Lab04
{
    public class Contactos
    {
        protected DataTable misContactos;

        public Contactos()
        {
            misContactos = getTabla();
        }

        public virtual DataTable getTabla()
        {

        }
    }
}
