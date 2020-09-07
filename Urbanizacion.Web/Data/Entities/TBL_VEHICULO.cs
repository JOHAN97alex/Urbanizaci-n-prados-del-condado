using System;
using System.ComponentModel.DataAnnotations;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_VEHICULO
    {
        [Key]
        public int VEH_ID { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de TAG es obligatorio")]
        [StringLength(5, ErrorMessage = "El número es demasiado largo")]
        [Display(Name = "No. TAG")]
        public string VEH_CODIGO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de lote es obligatorio")]
        [StringLength(4, ErrorMessage = "El número es demasiado largo")]
        [Display(Name = "No. PLACA")]
        public string VEH_PLACA { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "FECHA DE CREACION")]
        public DateTime VEH_FECHACREACIONBASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "FECHA DE CREACION")]
        public DateTime VEH_FECHACREACION => VEH_FECHACREACIONBASE.ToLocalTime();

        [Display(Name = "ESTADO")]
        public char VEH_ESTADO { get; set; }

        public TBL_PROPIETARIO Propietario { get; set; }
    }
}
