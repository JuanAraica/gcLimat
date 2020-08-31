using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gcLimat.Models.ViewModels
{
    public class ReporteViewModel
    {
        [Required]
        [Display(Name = "Codigo de Muestra")]
        public String codigoMuestra { get; set; }
        [Required]
        [Display(Name = "idCliente")]
        public String idCliente { get; set; }
        [Required]
        [Display(Name = "Cliente")]
        public String cliente { get; set; }
        [Required]
        [Display(Name = "ID de Equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public String direccion { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public String telefono { get; set; }
        [Required]
        [Display(Name = "Lugar")]
        public String lugarMuestreo { get; set; }
        [Required]
        [Display(Name = "Tipode Muestra")]
        public String tipoMuestra { get; set; }
        [Required]
        [Display(Name = "Procedimiento de Muestreo")]
        public String procMuestreo { get; set; }
        [Required]
        [Display(Name = "Recolector de Muestra")]
        public String recolectorMuestra { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ultimo muestreo")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String fechaMuestreo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ultima prueba PBC")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String fechaPruebaPBC { get; set; }
        [Required]
        [Display(Name = "Condiciones Ambientales")]
        public String condAmbientales { get; set; }
    }
}