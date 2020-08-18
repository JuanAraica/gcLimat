using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListEquipoViewModel
    {
        public String idEquipo{get;set;}
        public String tipoEquipo { get; set; }
        public String region { get; set; }
        public String potenciaMaxima { get; set; }
        public String serie { get; set; }
        public String marca { get; set; }
        public String subEstacion { get; set; }
        public String tipoRefrigeracion { get; set; }
        public String tension { get; set; }
        public String cantidadFase { get; set; }
        public String cantidadAceite { get; set; }
        public String annio { get; set; }
        public String MVA { get; set; }
        public String relacioTension { get; set; }
        public String humedadRelativa { get; set; }
        public String temperaturaAmbiente { get; set; }
        public String temperaturaEquipo { get; set; }
        public String ultimoReporte { get; set; }
        public String ultimoMantenimiento { get; set; }
        public String ultimoMuestreo { get; set; }
    }
}