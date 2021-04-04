using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabABM
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        private void CargarDatosUsuario(int idUsuario)
        {
            Usuario usuarioActual = new ManagerUsuarios().GetUsuario(idUsuario);           
            txtApellido.Text = usuarioActual.Apellido;
            txtNombre.Text = usuarioActual.Nombre;
            rblTipoDocumento.SelectedValue = usuarioActual.TipoDoc.ToString();
            txtNroDocumento.Text = usuarioActual.NroDoc.ToString();
            ddlDiaFechaNacimiento.SelectedValue = DateTime.Parse(usuarioActual.FechaNac.ToString()).Day.ToString();
            ddlMesFechaNacimiento.SelectedValue= DateTime.Parse(usuarioActual.FechaNac.ToString()).Month.ToString();
            txtAnioFechaNacimiento.Text = DateTime.Parse(usuarioActual.FechaNac.ToString()).Year.ToString();
            txtTelefono.Text = usuarioActual.Telefono;
            txtDirección.Text = usuarioActual.Direccion;
            txtEmail.Text = usuarioActual.Email;
            txtCelular.Text = usuarioActual.Celular;
            txtNombreUsuario.Text = usuarioActual.NombreUsuario;
            txtClave.Text = usuarioActual.Clave;         
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDiasCalendario();
            if(PaginaEnEstadoEdicion())
            {
                lblAccion.Text = "Editar Usuario "+Request.QueryString["id"];
                CargarDatosUsuario(Int32.Parse(Request.QueryString["id"]));
            }
            else
            {
                lblAccion.Text = "Agregar Nuevo Usuario";
            }
        }

        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cargarDiasCalendario()
        {
            int i = 1;
            if (ddlDiaFechaNacimiento.Items.Count==0)
            {
                do
                {
                    ddlDiaFechaNacimiento.Items.Add(i.ToString());
                    i++;
                }
                while (i <= 31);
            }           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuarioActual = new Usuario();
            usuarioActual.Id = Int32.Parse(Request.QueryString["id"]);
            usuarioActual.Apellido = txtApellido.Text;
            usuarioActual.Nombre= txtNombre.Text;
            usuarioActual.TipoDoc = rblTipoDocumento.SelectedIndex;
            usuarioActual.NroDoc = Int32.Parse(txtNroDocumento.Text);
            usuarioActual.FechaNac = DateTime.Parse(ddlDiaFechaNacimiento.SelectedItem.Value + "/" + ddlMesFechaNacimiento.SelectedItem.ToString() + "/" + txtAnioFechaNacimiento.Text).ToString();
            usuarioActual.Telefono = txtTelefono.Text;
            usuarioActual.Direccion = txtDirección.Text ;
            usuarioActual.Email= txtEmail.Text;
            usuarioActual.Celular = txtCelular.Text;
            usuarioActual.NombreUsuario=txtNombreUsuario.Text;
            usuarioActual.Clave= txtClave.Text;
            if (PaginaEnEstadoEdicion())
            {
                new ManagerUsuarios().ActualizarUsuario(usuarioActual);
            }
            else
            {
                new ManagerUsuarios().AgregarUsuario(usuarioActual);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}