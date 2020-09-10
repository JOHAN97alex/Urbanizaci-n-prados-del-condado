using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_PAGO
    {
        [Key]
        public int PAG_ID { get; set; }
        public string PAG_TOTAL { get; set; }
        public string PAG_PAGADO { get; set; }
        public DateTime PAG_FECHAPAGADO { get; set; }
        public string PAG_VALOR { get; set; }
        public DateTime PAG_FECHACREACION { get; set; }
        public char PAG_ESTADO { get; set; }
       // public TBL_PROPIETARIO Propietario { get; set; }
        public ICollection<TBL_VALOR> Valor { get; set; }
    }
}
