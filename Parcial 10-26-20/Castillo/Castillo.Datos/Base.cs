using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castillo.Entidades;
using System.Data.SqlClient;

namespace Castillo.Datos
{
    public class Base
    {
        private SqlConnection _sqlConn;

        public SqlConnection SQLConn
        {
            get => _sqlConn;
            set => _sqlConn = value;
        }

        public Base()
        {
            string cadenaDeConexion;
            cadenaDeConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jeremias\Desktop\Net.DB.Usuario.mdf;Integrated Security=True;Connect Timeout=30";
            SQLConn = new SqlConnection(cadenaDeConexion);
        }

        protected void AbrirConexion()
        {           
            SQLConn.Open();
        }

        protected void CerrarConexion()
        {
            SQLConn.Close();
            SQLConn = null;
        }


    }
}
