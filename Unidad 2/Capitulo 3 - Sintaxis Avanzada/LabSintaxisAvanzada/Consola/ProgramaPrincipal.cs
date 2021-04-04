using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Clases;

namespace UI.Consola
{
    class ProgramaPrincipal
    {      
        public static List<Ciudad> CargoCiudades()
        {
            List<Ciudad> Ciudades = new List<Ciudad>();
            Ciudades.Add(new Ciudad("rosario", "2000"));
            Ciudades.Add(new Ciudad("buenos Aires", "1000"));
            Ciudades.Add(new Ciudad("cordoba", "5000"));
            Ciudades.Add(new Ciudad("Santa Fe", "3000"));
            Ciudades.Add(new Ciudad("corrientes", "3400"));
            Ciudades.Add(new Ciudad("la plata", "1900"));
            Ciudades.Add(new Ciudad("bariloche", "8400"));
            Ciudades.Add(new Ciudad("mar del Plata", "7600"));
            Ciudades.Add(new Ciudad("salta", "4400"));
            Ciudades.Add(new Ciudad("ushuaia", "9410"));
            return Ciudades;
        }

        public static void BuscoCiudad(List<Ciudad> Ciudades)
        {    
            string cadena;           
            Console.WriteLine("Ingrese cadena a comparar");
            cadena = Console.ReadLine();
            var arreglo = from Ciu in Ciudades
                          where (Ciu.NombreCiudad.Contains(cadena.ToLower())== true)
                          select Ciu;

            Console.Clear();
            Console.WriteLine("Los codigos postales de las ciudades son:");
            foreach(Ciudad Ciu in arreglo)
            {
                Console.WriteLine(Ciu.CodigoPostal+ " perteneciente a -> "+Ciu.NombreCiudad);
            }          
            Console.ReadKey();          
        }


        static void Main()
        {
            #region Ejercicio 1
            /*
            Argentina pais = new Argentina();
            pais.BuscoProvinciasConSoT();
            Console.ReadKey();
            */
            #endregion

            #region Ejercicio 2
            /*
            List<int> ArregloDeNumeros = new List<int>();
            ConsoleKeyInfo Respuesta;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese numero");
                ArregloDeNumeros.Add(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("Desea ingresar otro Numero? N para finalizar");
                Respuesta = Console.ReadKey();
            } while (Respuesta.Key != ConsoleKey.N);

            var numABuscar = from num in ArregloDeNumeros
                             where (num > 20)
                             select num;
            Console.Clear();
            Console.WriteLine("Los numeros mayores a 20 son :");
            foreach (int n in numABuscar)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            */
            #endregion

            #region Ejercicio 3  
            /*
            List<Ciudad> Ciudades = new List<Ciudad>();
            Ciudades=CargoCiudades();
            BuscoCiudad(Ciudades);
            */
            #endregion

            #region Ejercicio4
            List<Empleado> Empleados = new List<Empleado>();
            ConsoleKeyInfo resp;
            Empleados.Add(new Empleado(1,    "Lionel Messi"  ,99999));
            Empleados.Add(new Empleado(2,    "Roberto Perez" ,12345));
            Empleados.Add(new Empleado(5,    "Jorge Lopez"   ,54321));
            Empleados.Add(new Empleado(9,    "Steve Jobs"    ,58754));
            Empleados.Add(new Empleado(10,   "Yoel Lopez",987654));
            do
            {
                Console.Clear();
                Empleados.Add(new Empleado());
                Console.WriteLine("Desea cargar un nuevo empleado? -- Escape para finalizar");
                resp = Console.ReadKey();
            } while (resp.Key != ConsoleKey.Escape);
            Console.Clear();
            var listaAscendente = from emp in Empleados
                        orderby emp.Sueldo ascending
                        select emp;
            var listaDescendente = from emp in Empleados
                                  orderby emp.Sueldo descending
                                  select emp;
            Console.WriteLine("La lista ordenada por sueldo ascendentes es :\n");
            foreach(Empleado emp in listaAscendente)
            {
                Console.WriteLine("Id ->\t"+emp.ID+"\tNombre}->\t"+emp.Nombre+"\t\tSueldo->\t"+emp.Sueldo);
                
            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("La lista ordenada por sueldo descendentes es :\n");
            foreach (Empleado emp in listaDescendente)
            {
                Console.WriteLine("Id ->\t" + emp.ID + "\tNombre}->\t" + emp.Nombre + "\tSueldo->\t" + emp.Sueldo);

            }
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
         #endregion

        }
    }
}
