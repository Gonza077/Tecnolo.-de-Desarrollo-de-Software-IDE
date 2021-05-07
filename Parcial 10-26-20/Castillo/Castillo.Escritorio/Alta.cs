using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castillo.Negocio;
using Castillo.Entidades;

namespace Castillo.Escritorio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            cbTiposUsuario.DataSource = Usuario.dameTipos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private bool validarCampos()
        {
            bool validador = true;
            if(String.IsNullOrEmpty(txtUsuario.Text))
            {
                validador = false;
                errProvider.SetError(txtUsuario,"Este campo no puede estar vacio");
            }
            if(String.IsNullOrEmpty(txtClave.Text))
            {
                validador = false;
                errProvider.SetError(txtClave, "Este campo no puede estar vacio");
            }
            if(String.IsNullOrEmpty(txtEmail.Text))
            {
                validador = false;
                errProvider.SetError(txtEmail, "Este campo no puede estar vacio");
            }
            else if(!Validaciones.esMailValido(txtEmail.Text))
            {
                validador = false;
                errProvider.SetError(txtEmail,"El email ingresado no es valido");
            }
            return validador;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                Usuario usuario = new Usuario(txtUsuario.Text, txtClave.Text, txtEmail.Text,(int)cbTiposUsuario.SelectedItem, DateTime.Now);
                new UsuarioNegocio().Agregar(usuario);
            }
            else
            {
                MessageBox.Show("Existen campos erroneos, verificar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
