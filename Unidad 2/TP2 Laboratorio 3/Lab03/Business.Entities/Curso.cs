using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Business.Entities
{
    public class Curso:BusinessEntity
    {
        private int m_anioCalendario;
        private int m_cupo;
        private int m_descripcion;
        private int m_IDComision;
        private int m_IDMateria;

        public int AnioCalendario
        {
            get => default;
            set
            {
            }
        }

        public int Cupo
        {
            get => default;
            set
            {
            }
        }

        public int Descripcion
        {
            get => default;
            set
            {
            }
        }

        public int IDComision
        {
            get => default;
            set
            {
            }
        }

        public int IDMateria
        {
            get => default;
            set
            {
            }
        }
    }
}
