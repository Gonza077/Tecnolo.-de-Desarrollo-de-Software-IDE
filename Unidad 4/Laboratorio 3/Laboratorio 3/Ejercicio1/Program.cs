using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio3.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataRow rowAlumno = dtAlumnos.NewRow();

            DataColumn colNombre = new DataColumn("Nombre", typeof(string));
            DataColumn colApellido = new DataColumn("Apellido", typeof(string));

            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.Columns.Add(colApellido);
            rowAlumno[colApellido] = "Perez";
            rowAlumno[colNombre] = "Juan";
            dtAlumnos.Rows.Add(rowAlumno);

            DataRow rowAlumno2 = dtAlumnos.NewRow();
            rowAlumno2[colApellido] = "Perez";
            rowAlumno2[colNombre] = "Marcelo";
            dtAlumnos.Rows.Add(rowAlumno2);

            Console.WriteLine("Listado de alumnos: ");
            foreach(DataRow row in dtAlumnos.Rows)
            {
                Console.WriteLine(row[colApellido].ToString()+ ", " + row[colNombre].ToString());
            }
            Console.ReadLine();

        }
    }
}
