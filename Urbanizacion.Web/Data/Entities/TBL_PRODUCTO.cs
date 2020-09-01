using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_PRODUCTO
    {
        public int PRO_ID { get; set; }
        public string PRO_NOMBRE { get; set; }
        public string PRO_PRECIO { get; set; }
        public DateTime PRO_FECHACREACION { get; set; }
        public Char PRO_ESTADO { get; set; }
        public TBL_NEGOCIO Negocio { get; set; }
    }
}
