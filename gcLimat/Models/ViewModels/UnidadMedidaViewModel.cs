using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gcLimat.Models.ViewModels
{
    public class UnidadMedidaViewModel
    {
        [Required]
        [Display(Name = "Factor a  medir")]
        public String factorAMedir { get; set; }
        [Required]
        [Display(Name = "Unidad de Medida")]
        public String unidadMedida { get; set; }
        [Required]
        [Display(Name = "Valor Recomendado")]
        public String valorRecomendado { get; set; }
    }
}