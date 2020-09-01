using System;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_VEHICULO
    {
        public int VEH_ID { get; set; }
        public string VEH_CODIGO { get; set; }
        public string VEH_PLACA { get; set; }
        public DateTime VEH_FECHACREACION { get; set; }
        public char VEH_ESTADO { get; set; }
        public TBL_PROPIETARIO Propietario { get; set; }
    }
}
