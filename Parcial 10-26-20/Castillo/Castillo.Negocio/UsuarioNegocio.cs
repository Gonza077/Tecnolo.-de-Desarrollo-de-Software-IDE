using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castillo.Datos;
using Castillo.Entidades;


namespace Castillo.Negocio
{
    public class UsuarioNegocio
    {
        public UsuarioNegocio()
        {
            UsuarioData = new UsuarioAdapter();
        }

        private UsuarioAdapter _usuAdapter;

        private UsuarioAdapter UsuarioData
        {
            get=> _usuAdapter;
            set=>_usuAdapter=value;
        }

        public List<Usuario> recuperarTodos()
        {
            return UsuarioData.recuperarTodos();
        }

        public void Agregar(Usuario usu)
        {
            UsuarioData.Agregar(usu);
        }

        public Usuario recuperarUno(string nombreUsu)
        {
            return UsuarioData.recuperarUno(nombreUsu);
        }

        public bool recuperoUno(string nombreUsu)
        {
            try
            {
                if(String.IsNullOrEmpty(recuperarUno(nombreUsu).NombreUsuario))
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
