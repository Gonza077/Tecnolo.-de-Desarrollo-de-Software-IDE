using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Business.Entities
{
    public class Persona
    {          
      
        private string m_apellido;
        public string Apellido
        {
            get => m_apellido;
            set => m_apellido = value;
        }

        private string m_nombre;
        public string Nombre
        {
            get => m_nombre;
            set => m_nombre = value;
        }

        private string m_telefono;
        public string Telefono
        {
            get => m_telefono;
            set => m_telefono = value;
        }

        private string m_direccion;
        public string Direccion
        {
            get => m_direccion;
            set => m_direccion = value;
        }

        private string m_email;
        public string Email
        {
            get => m_email;
            set => m_email = value;
        }

        private DateTime m_fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get => m_fechaNacimiento;
            set => m_fechaNacimiento = value;
        }

        private int m_IDPlan;
        public int IDPlan
        {
            get => m_IDPlan;
            set => m_IDPlan = value;
        }

        private int m_legajo;
        public int Legajo
        {
            get => m_legajo;
            set => m_legajo = value;
        }

        /*private TiposPersonas m_tipoPersona;
        public TipoPersona Legajo
        {
            get => m_tipoPersona;
            set => m_tipoPersona=value;
        }
        */
    }
}
