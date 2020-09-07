using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_VALOR
    {
        [Key]
        [Display(Name = "ID")]
        public int VAL_ID { get; set; }

        [Display(Name = "VALOR ALICUOTA")]
        public string VAL_VALOR { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime VAL_FECHAINICIOBASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "FECHA DE REGISTRO")]
        public DateTime VAL_FECHAINICIO => VAL_FECHAINICIOBASE.ToLocalTime();

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime VAL_FECHAFINBASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "FECHA DE CAMBIO")]
        public DateTime VAL_FECHAFIN => VAL_FECHAFINBASE.ToLocalTime();

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime VAL_FECHACREACIONBASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "FECHA DE CREACION")]
        public DateTime VAL_FECHACREACION => VAL_FECHACREACIONBASE.ToLocalTime();

        [Display(Name = "ESTADO")]
        public Char VAL_ESTADO { get; set; }
        public TBL_PAGO Pago { get; set; }
    }
}
