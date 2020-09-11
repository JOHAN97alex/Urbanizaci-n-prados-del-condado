﻿using System;
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "El tipo de vivienda es obligatorio")]
        [Display(Name = "Tipo de Vivienda")]
        public string PRO_TIPO { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los nombres deben tener un minimo de 3 caracteres y un maximo de 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los nombres son obligatorios")]
        [Display(Name = "Nombres")]
        public string PRO_NOMBRES { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "los apellidos deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "los apellidos son obligatorios")]
        [RegularExpression(@"^[a-z]+[a-za-z]*$")]
        [Display(Name = "Apellidos")]
        public string PRO_APELLIDOS { get; set; }

        [Display(Name = "Observaciones")]
        public string PRO_OBSERVACIONES { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Telefono/Celular")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de telefono es obligatorio")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "El numero de telefono deben tener un minimo de 3 caracteres y un maximo de 50")]
        public string PRO_TELEFONO { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El email es obligatorio")]
        [Display(Name = "Email")]
        public string PRO_EMAIL { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El tipo de identificacion es obligatorio")]
        [Display(Name = "Tipo de Identificacion")]
        public char PRO_TIPOIDENTIFICACION { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de identificacion es obligatorio")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "La identificacion deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Display(Name = "Identificacion")]
        public string PRO_IDENTIFICACION { get; set; }

        [Display(Name = "Nombre Familiar")]
        public string PRO_NOMBREFAMILIAR { get; set; }

        [Display(Name = "Tipo de Identificacion")]
        public string PRO_APELLIDOFAMILIAR { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Telefono/Celular Familiar")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de telefono es obligatorio")]
        [StringLength(10, MinimumLength = 3,
         ErrorMessage = "El numero de telefono deben tener un minimo de 3 caracteres y un maximo de 50")]
        public string PRO_TELEFONOFAMILIAR { get; set; }


        public string PRO_NOMENCLATURA { get; set; }
        public string PRO_PASSWORD { get; set; }
        public string PRO_PERFIL { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
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

        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        //[Display(Name = "Fecha de Creacion")]
        //public DateTime PRO_FECHACREACION => PRO_FECHACREACION.ToLocalTime();

        public Char PRO_ESTADO { get; set; }

        //ESTOS CAMPOS CORRESPONDEN A LAS RELACIONES
        public TBL_CONJUNTO Conjunto { get; set; }
        public ICollection<TBL_PAGO> Pago { get; set; }
        public ICollection<TBL_NEGOCIO> Negocio { get; set; }
        public TBL_ROL Rol { get; set; }
        public ICollection<TBL_VEHICULO> Vehiculo { get; set; }

    }
}

