using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Castillo.Entidades;
using Castillo.Negocio;

namespace Castillo.Web
{
    public partial class UsuarioWeb : System.Web.UI.Page
    {
        private UsuarioNegocio usuNegocio
        {
            get;
            set;
        }
        public UsuarioWeb()
        {
            usuNegocio = new UsuarioNegocio();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblDatos.Visible = false;
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuNegocio.recuperoUno(txtUsuario.Text))
                {
                    Usuario usu = usuNegocio.recuperarUno(txtUsuario.Text);
                    lblDatos.Visible = true;
                    lblDatos.Text = usu.NombreUsuario + ", " + usu.Clave + ", " + usu.Email + ", " + usu.TipoUsuario + ", " + usu.UltimoIngreso;                  
                }
            }
            catch(Exception ex)
            {
                lblDatos.Visible = true;
                lblDatos.Text = ex.Message;
            }
        }
    }
}