using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Data.Entities
{
    public class TBL_CONJUNTO
    {
        [Key]
        public int CON_ID { get; set; }


        [MaxLength(100, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Nombre Urbanizacion")]
        public string CON_NOMBRE { get; set; }



        [MaxLength(13, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        [MinLength(13, ErrorMessage = "El {0} campo no puede tener menos de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "RUC")]
        public string CON_IDENTIFICACION { get; set; }



        [MaxLength(10, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        [MinLength(10, ErrorMessage = "El {0} campo no puede tener menos de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Celular")]
        public string CON_TELEFONO { get; set; }

        public ICollection<TBL_PROPIETARIO> Propietario { get; set; }
    }
}
