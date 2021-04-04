using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Clases
{
    public class Argentina
    {
        private string[] arregloProvincias= new string[23];

        public Argentina()
        {
            arregloProvincias[0]    =   "Buenos Aires";
            arregloProvincias[1]    =   "Santa Fe";
            arregloProvincias[2]    =   "Cordoba";
            arregloProvincias[3]    =   "Tierra Del Fuego";
            arregloProvincias[4]    =   "Chubut";
            arregloProvincias[5]    =   "Santa Cruz";
            arregloProvincias[6]    =   "Rio Negro";
            arregloProvincias[7]    =   "Neuquen";
            arregloProvincias[8]    =   "Mendoza";
            arregloProvincias[9]    =   "Mendoza";
            arregloProvincias[10]   =   "San Luis";
            arregloProvincias[11]   =   "Entre Rios";
            arregloProvincias[12]   =   "La Rioja";
            arregloProvincias[13]   =   "San Juan";
            arregloProvincias[14]   =   "Corrientes";
            arregloProvincias[15]   =   "Santiago del Estero";
            arregloProvincias[16]   =   "Tucuman";
            arregloProvincias[17]   =   "Catamarca";
            arregloProvincias[18]   =   "Chacho";
            arregloProvincias[19]   =   "Misiones";
            arregloProvincias[20]   =   "Formosa";
            arregloProvincias[21]   =   "Salta";
            arregloProvincias[22]   =   "Jujuy";          
        }

        public void BuscoProvinciasConSoT()
        {
            var provABuscar = from p in arregloProvincias
                              where (p.StartsWith("S") || p.StartsWith("T") )
                              select p;
            Console.Clear();
            Console.WriteLine("Las provincias que empiezan con S o T son :");
            foreach (string prov in provABuscar)
            {
                Console.WriteLine(prov);
            }
            Console.ReadKey();
        }

    }
}
