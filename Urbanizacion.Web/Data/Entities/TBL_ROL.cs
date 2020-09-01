using Java.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_ROL
    {
        public int ROL_ID { get; set; }
        public string ROL_DESCRIPCION { get; set; }
        public DateTime ROL_FECHACREACION { get; set; }
        public Char ROL_ESTADO { get; set; }
        public ICollection<TBL_PROPIETARIO> Propietario { get; set; }
        public TBL_SERVICIO Servicio { get; set; }
    }
}
