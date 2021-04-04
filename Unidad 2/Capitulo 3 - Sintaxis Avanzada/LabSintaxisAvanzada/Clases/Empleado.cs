using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Clases
{
    public class Empleado
    {
        private int m_Id;
        private string m_Nombre;
        private decimal m_Sueldo;

      public int ID
        {
            get => m_Id;
            set
            {
                m_Id = value;
            }
        }

        public string Nombre
        {
            get => m_Nombre;
            set
            {
                m_Nombre = value;
            }
        }

        public decimal Sueldo
        {
            get => m_Sueldo;
            set
            {
                m_Sueldo = value;
            }
        }

        public Empleado(int id,string nombre,decimal sueldo)
        {
            ID = id;
            Nombre = nombre;
            Sueldo = sueldo;
        }
        public Empleado()
        {
            Console.WriteLine("Ingrese ID del empleado");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del empleado");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo");
            Sueldo = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
