using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_SERVICIO
    {
        public int SER_ID { get; set; }
        public string SER_NOMBRE { get; set; }
        public string SER_DESRIPCION { get; set; }
        public DateTime SER_FECHACREACION { get; set; }
        public Char SER_ESTADO { get; set; }
        public ICollection<TBL_ROL> Rol { get; set; }
    }
}
