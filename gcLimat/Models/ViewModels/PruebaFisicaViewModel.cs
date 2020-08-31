using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gcLimat.Models.ViewModels
{
    public class PruebaFisicaViewModel
    {
        public int idPruebasFisicas { get; set; }
        [Required]
        [Display(Name = "ID del Equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Examen Visual")]
        public String examenVisual { get; set; }
        [Required]
        [Display(Name = "Color")]
        public String color { get; set; }
        [Required]
        [Display(Name = "tensionInterfacial")]
        public String tensionInterfacial { get; set; }
        [Required]
        [Display(Name = "ID del Equipo")]
        public String gravedadEspecifica15C15C { get; set; }
    }
}