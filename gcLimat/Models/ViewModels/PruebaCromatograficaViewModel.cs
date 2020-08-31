using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gcLimat.Models.ViewModels
{
    public class PruebaCromatograficaViewModel
    {
        public int idPruebaCroma { get; set; }
        [Required]
        [Display(Name = "ID del Equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Dioxido de Carbono")]
        public String dioxidoCarbono { get; set; }
        [Required]
        [Display(Name = "Acetileno")]
        public String acetileno { get; set; }
        [Required]
        [Display(Name = "Etileno")]
        public String etileno { get; set; }
        [Required]
        [Display(Name = "Etano")]
        public String etano { get; set; }
        [Required]
        [Display(Name = "Equipo")]
        public String metano { get; set; }
        [Required]
        [Display(Name = "Monoxido de Carbono")]
        public String monoxidoCarbono { get; set; }
        [Required]
        [Display(Name = "Hidrogeno")]
        public String hidrogeno { get; set; }
        [Required]
        [Display(Name = "Total de Gases Combusibles")]
        public String totalGasesCombusibles { get; set; }
    }
}