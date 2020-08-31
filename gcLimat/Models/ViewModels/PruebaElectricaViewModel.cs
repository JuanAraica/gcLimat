using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gcLimat.Models.ViewModels
{
    public class PruebaElectricaViewModel
    {
        public int idPruebaElectrica { get; set; }
        [Required]
        [Display(Name = "ID del Equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Rigidez DioElectrica")]
        public String rigidezDioElectrica { get; set; }
        [Required]
        [Display(Name = "Factor Potencia 100C°")]
        public String factorPotencia100C { get; set; }
        [Required]
        [Display(Name = "Resistividad 100")]
        public String resistividad100 { get; set; }
    }
}