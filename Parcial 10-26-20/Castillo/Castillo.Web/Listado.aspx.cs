using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Castillo.Negocio;

namespace Castillo.Web
{
    public partial class Listado : System.Web.UI.Page
    {
        private UsuarioNegocio usuNegocio
        {
            get;
            set;
        }
        public Listado()
        {
            usuNegocio = new UsuarioNegocio();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = usuNegocio.recuperarTodos();
            gvListado.DataBind();
        }

    }
}