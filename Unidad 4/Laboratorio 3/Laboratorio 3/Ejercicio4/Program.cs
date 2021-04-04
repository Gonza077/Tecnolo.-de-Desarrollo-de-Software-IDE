using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Laboratorio3.Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            SqlConnection myConn = new SqlConnection();

            myConn.ConnectionString ="Server=localhost;Database=northwind;Integrated Security=false; User=net; Password=net;";

            SqlCommand myComando = new SqlCommand();
            myComando.CommandText = "SELECT CustomerID,CompanyName FROM Customers";
            myComando.Connection = myConn;

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT CustomerID,CompanyName FROM Customers", myConn);
            myConn.Open();
            SqlDataReader myDr = myComando.ExecuteReader();

            dtEmpresas.Load(myDr);
            myConn.Close();

            Console.WriteLine("Listado de empresas: ");
            foreach(DataRow rowEmpresas in dtEmpresas.Rows)
            {
                string idEmpresa = rowEmpresas["CustomerID"].ToString();
                string nombreEmpresa = rowEmpresas["CompanyName"].ToString();
                Console.WriteLine(idEmpresa + "--" + nombreEmpresa);
            }
            Console.ReadLine();
        }
    }
}
