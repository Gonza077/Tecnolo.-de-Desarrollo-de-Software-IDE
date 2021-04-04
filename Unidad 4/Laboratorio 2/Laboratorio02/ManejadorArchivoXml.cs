using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class ManejadorArchivoXml : ManejadorDeArchivos
    {
        protected DataSet ds;

        public override DataTable getTabla()
        {
            ds = new DataSet();
            ds.ReadXml("agenda.xml");
            return ds.Tables["contactos"];      
        }

        public override void aplicaCambios()
        {
            ds.WriteXml("agenda.xml");
            ds.WriteXml("agendaConSchema.xml", XmlWriteMode.WriteSchema);
        }
    }
}
