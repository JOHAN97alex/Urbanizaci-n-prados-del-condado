using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_PROPIETARIO
    {
        [Key]
        public int PRO_ID { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de lote es obligatorio")]
        [StringLength(4, ErrorMessage = "El número es demasiado largo")]
        [Display(Name = "No. Lote")]
        public string PRO_LOTE { get; set; }

        //helper
        public string PRO_TIPO { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los nombres deben tener un minimo de 3 caracteres y un maximo de 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los nombres son obligatorios")]
        [Display(Name = "Nombres")]
        public string PRO_NOMBRES { get; set; }

        [StringLength(50, MinimumLength = 3,
       ErrorMessage = "Los apellidos deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los apellidos son obligatorios")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name = "Apellidos")]
        public string PRO_APELLIDOS { get; set; }

        [Display(Name = "Observaciones")]
        public string PRO_OBSERVACIONES { get; set; }
        
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name ="Telefono/Celular")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de telefono es obligatorio")]
        public string PRO_TELEFONO { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El email es obligatorio")]
        [Display(Name = "Email")]
        public string PRO_EMAIL { get; set; }


        public char PRO_TIPOIDENTIFICACION { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PRO_IDENTIFICACION { get; set; }
        public string PRO_NOMBREFAMILIAR { get; set; }
        public string PRO_APELLIDOFAMILIAR { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string PRO_TELEFONOFAMILIAR { get; set; }
        public string PRO_NOMENCLATURA { get; set; }
        public string PRO_PASSWORD { get; set; }
        public string PRO_PERFIL { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}",ApplyFormatInEditMode =false)]
        public DateTime PRO_FECHAINGRESOBASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de Ingreso del Inquilino")]
        public DateTime PRO_FECHAINGRESO => PRO_FECHAINGRESOBASE.ToLocalTime();

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime PRO_FECHASALIDABASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de Ingreso del Inquilino")]
        public DateTime PRO_FECHASALIDA => PRO_FECHASALIDABASE.ToLocalTime();

        public bool PRO_INQUILINOS { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime PRO_FECHACREACIONBASE { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de Creacion")]
        public DateTime PRO_FECHACREACION => PRO_FECHACREACION.ToLocalTime();

        public bool PRO_ESTADO { get; set; }

        //ESTOS CAMPOS CORRESPONDEN A LAS RELACIONES
        public TBL_CONJUNTO Conjunto { get; set; }
        public ICollection<TBL_PAGO> Pago { get; set; }
        public ICollection<TBL_NEGOCIO> Negocio { get; set; }
        public TBL_ROL Rol { get; set; }
        public ICollection<TBL_VEHICULO> Vehiculo { get; set; }

    }
}

