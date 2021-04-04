using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Clases
{
    public class B:A
    {
        
        public B(string NombreInstancia) : base("Instancia de B")
        {
            M4();
        }
        public B() : base()
        {
            M4();
        }

        public void M4()
        {
            Console.WriteLine("Metodo del hijo invocado");
        }
    }
}
