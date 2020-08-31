using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gcLimat.Models.ViewModels
{
    public class PruebaQuimicaViewModel
    {
        public int idPruebaEQuimica { get; set; }
        [Required]
        [Display(Name = "ID del Equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Contenido de Agua")]
        public String contenidoAgua { get; set; }
        [Required]
        [Display(Name = "Num. de Neutralizacion de acido")]
        public String numNeutralizacionAcido { get; set; }
        [Required]
        [Display(Name = "PBC")]
        public String PBC { get; set; }
    }
}