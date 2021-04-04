using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            dsUniversidad miUnversidad = new dsUniversidad();
            dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
            dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();
            dsUniversidad.dtAlumnosRow rowAlumno = dtAlumnos.NewdtAlumnosRow();
            dsUniversidad.dtAlumnosRow rowAlumno2 = dtAlumnos.NewdtAlumnosRow();

            rowAlumno.Apellido = "Perez";
            rowAlumno.Nombre="Juan";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            dsUniversidad.dtCursosRow rowCurso = dtCursos.NewdtCursosRow();

            rowCurso.Curso = "Informatica";
            dtCursos.AdddtCursosRow(rowCurso);

            dsUniversidad.dt_Alumnos_CursosDataTable dtAlumnos_Cursos = new dsUniversidad.dt_Alumnos_CursosDataTable();

            dsUniversidad.dt_Alumnos_CursosRow rowAlumnosCursos = dtAlumnos_Cursos.Newdt_Alumnos_CursosRow();

            dtAlumnos_Cursos.Adddt_Alumnos_CursosRow(rowAlumno, rowCurso);

            rowAlumno2.Nombre = "Marcelo";
            rowAlumno2.Apellido = "Perez";
            dtAlumnos.AdddtAlumnosRow(rowAlumno2);

            dtAlumnos_Cursos.Adddt_Alumnos_CursosRow(rowAlumno2, rowCurso);
        }
    }
}
