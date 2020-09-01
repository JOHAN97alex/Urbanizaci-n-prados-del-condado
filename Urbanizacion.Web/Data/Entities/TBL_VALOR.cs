using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_VALOR
    {
        public int VAL_ID { get; set; }
        public string VAL_VALOR { get; set; }
        public DateTime VAL_FECHAINICIO { get; set; }
        public DateTime VAL_FECHAFIN { get; set; }
        public DateTime VAL_FECHACREACION { get; set; }
        public DateTime VAL_ESTADO { get; set; }
        public TBL_PAGO Pago { get; set; }
    }
}
