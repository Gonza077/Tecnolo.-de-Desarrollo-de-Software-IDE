using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Business.Entities
{
    class Comision:BusinessEntity
    {
        private int m_anioEspecialidad;
        public int AnioEspecialidad
        {
            get => m_anioEspecialidad;
            set => m_anioEspecialidad = value;
        }

        private string m_descripcion;
        public string Descripcion
        {
            get => m_descripcion;
            set => m_descripcion = value;
        }

        private int m_IDPlan;
        public int IDPlan
        {
            get => m_IDPlan;
            set => m_IDPlan = value;
        }
    }
}
