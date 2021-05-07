using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castillo.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Castillo.Datos
{
    public class UsuarioAdapter:Base
    {
        public List<Usuario> recuperarTodos()
        {
            List<Usuario> Usuarios = new List<Usuario>();
            AbrirConexion();
            SqlCommand cmdUsuarios = new SqlCommand("select * from Usuarios", SQLConn);
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
            while (drUsuarios.Read())
            {
                Usuario Usu = new Usuario();
                Usu.NombreUsuario = (string)drUsuarios["NombreUsuario"];
                Usu.Clave = (string)drUsuarios["Clave"];
                Usu.Email = (string)drUsuarios["Email"];
                Usu.UltimoIngreso = (DateTime)drUsuarios["UltimoIngreso"];
                Usu.TipoUsuario = (int)drUsuarios["TipoUsuario"];
                Usuarios.Add(Usu);
            }
            CerrarConexion();
            return Usuarios;
        }

        public void Agregar(Usuario usuario)
        {
            AbrirConexion();
            SqlCommand cmdUsuarios = new SqlCommand("insert into Usuarios (NombreUsuario,Clave,Email,UltimoIngreso,TipoUsuario) " +
            "values (@nombUsu,@claveUsu,@emailUsu,@ultimoIngreso,@tipoUsu)", SQLConn);
            cmdUsuarios.Parameters.Add("@nombUsu", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
            cmdUsuarios.Parameters.Add("@claveUsu", SqlDbType.VarChar, 50).Value = usuario.Clave;
            cmdUsuarios.Parameters.Add("@emailUsu", SqlDbType.VarChar, 50).Value = usuario.Email;
            cmdUsuarios.Parameters.Add("@ultimoIngreso", SqlDbType.DateTime).Value = usuario.UltimoIngreso;
            cmdUsuarios.Parameters.Add("@tipoUsu", SqlDbType.VarChar, 50).Value = usuario.TipoUsuario;
            cmdUsuarios.ExecuteNonQuery();
            CerrarConexion();
        }

        public Usuario recuperarUno(string nombre)
        {
            try
            {
                AbrirConexion();
                Usuario Usu = new Usuario();
                SqlCommand cmdUsuarios = new SqlCommand("select * from Usuarios where NombreUsuario=nombre", SQLConn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    
                    Usu.NombreUsuario = (string)drUsuarios["NombreUsuario"];
                    Usu.Clave = (string)drUsuarios["Clave"];
                    Usu.Email = (string)drUsuarios["Email"];
                    Usu.UltimoIngreso = (DateTime)drUsuarios["UltimoIngreso"];
                    Usu.TipoUsuario = (int)drUsuarios["TipoUsuario"];
                }
                return Usu;              
            }
            catch(Exception ex)
            {
                Exception ExepcionMejorada = new Exception("El nombre de usuario ingresado estaba vacio", ex);
                throw ExepcionMejorada;
            }
            finally
            {
                CerrarConexion();
            }
            
        }
    }
}
