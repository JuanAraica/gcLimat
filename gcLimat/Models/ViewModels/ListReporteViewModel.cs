using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListReporteViewModel
    {
        public String codigoMuestra { get; set; }
        public String idCliente { get; set; }
        public String cliente { get; set; }
        public String idEquipo { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String lugarMuestreo { get; set; }
        public String tipoMuestra { get; set; }
        public String procMuestreo { get; set; }
        public String recolectorMuestra { get; set; }
        public String fechaMuestreo { get; set; }
        public String fechaPruebaPBC { get; set; }
        public String condAmbientales { get; set; }
    }
}