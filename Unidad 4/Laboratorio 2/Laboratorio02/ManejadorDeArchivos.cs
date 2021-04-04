using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Laboratorio02
{
    public class ManejadorDeArchivos
    {
        protected DataTable misContactos;
   
        public ManejadorDeArchivos()
        {
            misContactos = getTabla();
        }
        public void Listar()
        { 
            foreach(DataRow fila in misContactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn columna in misContactos.Columns)
                    {
                        Console.WriteLine("{0}: {1} ", columna.ColumnName, fila[columna]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void nuevaFila()
        {
            DataRow fila = misContactos.NewRow();
            foreach(DataColumn col in misContactos.Columns)
            {
                Console.WriteLine("Ingrese {0} ", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
            misContactos.Rows.Add(fila);
        }

        public void editarFila()
        {
            ;
            Console.WriteLine("Ingrese numero de fila a modificar");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = misContactos.Rows[nroFila - 1];
            for (int nroCol = 1; nroCol < misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = misContactos.Columns[nroCol];
                Console.WriteLine("Ingrese {0} ", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
        }

        public void eliminarFila()
        {
            Console.WriteLine("Ingrese  el numero de fila a eliminar");
            int fila = int.Parse(Console.ReadLine());
            misContactos.Rows[fila - 1].Delete();

        }

        public virtual DataTable getTabla()
        {
            return new DataTable();
        }

        public virtual void aplicaCambios()
        {

        }

    }
}
