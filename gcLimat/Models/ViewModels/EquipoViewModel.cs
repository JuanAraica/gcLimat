using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class EquipoViewModel
    {
        [Required]
        [Display(Name = "Id del equipo")]
        public String idEquipo { get; set; }
        [Required]
        [Display(Name = "Tipo del equipo")]
        public String tipoEquipo { get; set; }
        [Required]
        [Display(Name = "Región")]
        public String region { get; set; }
        [Required]
        [Display(Name = "Potencia Maxima")]
        public String potenciaMaxima { get; set; }
        [Required]
        [Display(Name = "Serie")]
        public String serie { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public String marca { get; set; }
        [Required]
        [Display(Name = "Sub Estacion")]
        public String subEstacion { get; set; }
        [Required]
        [Display(Name = "Tipo de refrigeracion")]
        public String tipoRefrigeracion { get; set; }
        [Required]
        [Display(Name = "Tension")]
        public String tension { get; set; }
        [Required]
        [Display(Name = "Cantidad fase")]
        public String cantidadFase { get; set; }
        [Required]
        [Display(Name = "Cantidad de aceite")]
        public String cantidadAceite { get; set; }
        [Required]
        [Display(Name = "Año del equipo")]
        public String annio { get; set; }
        [Required]
        [Display(Name = "MVA")]
        public String MVA { get; set; }
        [Required]
        [Display(Name = "Relacion tencion")]
        public String relacioTension { get; set; }
        [Required]
        [Display(Name = "Humedad relativa")]
        public String humedadRelativa { get; set; }
        [Required]
        [Display(Name = "Temperatura ambiente")]
        public String temperaturaAmbiente { get; set; }
        [Required]
        [Display(Name = "Temperatura del equipo")]
        public String temperaturaEquipo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ultimo reporte")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String ultimoReporte { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ultimo mantenimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String ultimoMantenimiento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ultimo muestreo")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String ultimoMuestreo { get; set; }

    }
}