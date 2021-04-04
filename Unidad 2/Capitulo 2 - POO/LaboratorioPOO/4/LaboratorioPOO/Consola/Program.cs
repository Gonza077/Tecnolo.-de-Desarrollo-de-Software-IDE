using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioPOO.Clases;

namespace Consola
{
    class Program
    {
        public class Persona
        {
            private string m_nombre;
            private string m_apellido;
            private int m_edad;
            private string m_DNI;
            public string Nombre
            {
                get => m_nombre;
                set { m_nombre = value; }
            }
            public string Apellido
            {
                get => m_apellido;
                set { m_apellido = value; }
            }
            public int Edad
            {
                get => m_edad;
                set { m_edad = value; }
            }
            public string DNI
            {
                get => m_DNI;
                set { m_DNI = value; }
            }
            public Persona(string Nomb, string Apel, int Ed, string Dni)
            {
                Nombre = Nomb;
                Apellido = Apel;
                Edad = Ed;
                DNI = Dni;
                Console.WriteLine("Persona creada con exito");
            }
            ~Persona()
            {
                System.Diagnostics.Trace.WriteLine("Se destruyo la persona");

            }
            public string GetFullName()
            {
                return Apellido + ", " + Nombre;
            }
        }
        static void Main()
        {
            Persona per = new Persona("Juan", "Perez", 22, "123456");
            Console.WriteLine(per.Edad);
            Console.WriteLine(per.GetFullName());        
            Console.ReadKey();            
        }
    }
}
