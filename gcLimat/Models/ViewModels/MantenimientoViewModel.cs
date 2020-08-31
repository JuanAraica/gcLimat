using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class MantenimientoViewModel
    {
       
        public int idMantenimiento { get; set; }
        [Required]
        [Display(Name = "Id del equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Tipo del mantenimiento")]
        public String tipoMantenimiento { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        public String descripcion { get; set; }
        [Required]
        [Display(Name = "Supervisor")]
        public String supervisor { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de mantenimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String fecha { get; set; }

    }
}