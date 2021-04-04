using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Laboratorio02
{
    class ManejadorArchivosTxt:ManejadorDeArchivos
    {
        public string connectionString
        {
            get => @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Gonza y Jere\Desktop\Gonza\Drive PC\Facultad\4°\.Net\Laboratorios\Unidad 4\Laboratorio 2\Laboratorio02\bin\Debug;" +
            "Extended Properties='text;HDR=Yes;FMT=Delimited'";
        }

        public override DataTable getTabla()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdSelect = new OleDbCommand("select * from agenda.txt", Conn);
                Conn.Open();
                OleDbDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader!=null)
                {
                    contactos.Load(reader);
                }
                Conn.Close();
                return contactos;
            }            
        }

        public override void aplicaCambios()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdInsert = new OleDbCommand("insert into agenda.txt values (@id,@nombre,@apellido,@email,@telefono)", Conn);
                cmdInsert.Parameters.Add("@id", OleDbType.Integer);
                cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@email", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdUpdate = new OleDbCommand("update agenda.txt set nombre=@nombre,apellido=@apellido,email=@email,telefono=@telefono where id=@id)", Conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);
                cmdUpdate.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdDelete = new OleDbCommand("delete from agenda.txt where id=@id", Conn);
                cmdDelete.Parameters.Add("@id", OleDbType.Integer);

                DataTable filasNuevas = misContactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = misContactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = misContactos.GetChanges(DataRowState.Modified);

                Conn.Open();
                if (filasNuevas!=null)
                {
                    foreach(DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value=fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if (filasModificadas!=null)
                {
                    foreach(DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                if (filasBorradas!=null)
                {
                    foreach(DataRow fila in filasBorradas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id",DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
