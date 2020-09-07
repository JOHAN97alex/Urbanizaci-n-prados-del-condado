using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_NEGOCIO
    {
        [Key]
        public int NEG_ID { get; set; }
        public string NEG_NOMBRE { get; set; }
        public string NEG_DESCRIPCION { get; set; }
        public string NEG_TELEFONO { get; set; }
        public string NEG_DIRECCION { get; set; }
        public string NEG_EMAIL { get; set; }
        public DateTime NEG_FECHACREACION { get; set; }
        public Char NEG_ESTADO { get; set; }
        public TBL_PROPIETARIO Propietario { get; set; }
        public ICollection<TBL_PRODUCTO> Producto { get; set; }
    }
}
