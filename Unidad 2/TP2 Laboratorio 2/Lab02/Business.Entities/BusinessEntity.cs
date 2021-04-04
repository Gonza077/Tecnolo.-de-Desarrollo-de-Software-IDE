using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Business.Entities
{
    public class BusinessEntity
    {


        private int m_ID;
        
        public int ID
        {
            get => m_ID;
            set { m_ID = value; }
        }

        private States m_state;

        public States State { get { return m_state; } set { m_state = value; } }


        public enum States
        {
            Deleted,
            New,
            Update,
            Unmodified,
        }

        public BusinessEntity()
        {
            this.State = States.New;
        }
    }
}
