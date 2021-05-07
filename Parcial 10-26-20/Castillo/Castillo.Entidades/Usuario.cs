using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castillo.Entidades
{
    public class Usuario
    {
        public Usuario()
        {

        }

        
        public enum TiposUsuarios
        {
            Admin=1,
            JefeDeCatedra=2,
            Ayudante=3
        }
        

        public static List<TiposUsuarios> dameTipos()
        {
            List<TiposUsuarios> tipos = new List<TiposUsuarios>();
            tipos.Add(TiposUsuarios.Admin);
            tipos.Add(TiposUsuarios.JefeDeCatedra);
            tipos.Add(TiposUsuarios.Ayudante);
            return tipos;
        }

        public Usuario(string nombreUsu,string clave, string email, int tipoUsu, DateTime ultimoIngreso)
        {
            NombreUsuario = nombreUsu;
            Clave = clave;
            Email = email;
            TipoUsuario = tipoUsu;
            UltimoIngreso = ultimoIngreso;
        }

        public string Clave
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string NombreUsuario
        {
            get;
            set;
        }

        public int TipoUsuario
        {
            get;
            set;
        }

        public DateTime UltimoIngreso
        {
            get;
            set;
        }

        public int DiasUltimoIngreso
        {
            get { return (DateTime.Now - this.UltimoIngreso).Days; }
        }
    }
}
