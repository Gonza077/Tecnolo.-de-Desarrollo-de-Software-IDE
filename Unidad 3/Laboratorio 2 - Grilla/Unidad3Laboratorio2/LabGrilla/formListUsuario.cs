using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabGrilla
{
    public partial class formListUsuario : Form
    {
        private Negocio.Usuarios _usuarios;

        public formListUsuario()
        {
            InitializeComponent();
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();

        }
        public Negocio.Usuarios oUsuarios
        {
            get => _usuarios; 
            set =>_usuarios = value; 
        }

    }
}
