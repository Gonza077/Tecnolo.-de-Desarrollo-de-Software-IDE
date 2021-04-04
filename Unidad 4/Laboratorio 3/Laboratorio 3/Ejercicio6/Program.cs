using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            SqlConnection myConn = new SqlConnection();

            myConn.ConnectionString = "Server=localhost;Database=northwind;Integrated Security=false; User=net; Password=net;";

            SqlDataAdapter myAdapter = new SqlDataAdapter("select  CustomerID,CompanyName from Customers", myConn);
            myAdapter.Fill(dtEmpresas);
            myConn.Close();

            Console.WriteLine("Listado de empresas: ");
            foreach (DataRow rowEmpresas in dtEmpresas.Rows)
            {
                string idEmpresa = rowEmpresas["CustomerID"].ToString();
                string nombreEmpresa = rowEmpresas["CompanyName"].ToString();
                Console.WriteLine(idEmpresa + "--" + nombreEmpresa);
            }
            Console.ReadLine();

            Console.WriteLine("Ingrese el CustomerID que desea modificar");
            string custID = Console.ReadLine();

            DataRow[] rwEmpresas = dtEmpresas.Select("CustomerID = '"+custID+"'");
            if (rwEmpresas.Length!=1)
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }

            DataRow rowMiEmpresa = rwEmpresas[0];
            string nombreActual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine("Nombre  actual de la empresa --> " + nombreActual);
            Console.WriteLine("\nIngrese nuevo nombre");
            string nuevoNombre = Console.ReadLine();

            rowMiEmpresa.BeginEdit();
            rowMiEmpresa["CompanyName"] = nuevoNombre;
            rowMiEmpresa.EndEdit();

            SqlCommand updCommand = new SqlCommand();
            updCommand.Connection = myConn;
            updCommand.CommandText = "update Customers set CompanyName = @CompanyName where CustomerID = @CustomerID";
            updCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            myAdapter.UpdateCommand = updCommand;
            myAdapter.Update(dtEmpresas);


        }
    }
}
