using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio3.Ejercicio5
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
        }
    }
}
