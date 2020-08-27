using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListMantenimientoViewModel
    {
        public int idMantenimiento { get; set; }
        public String idEquipo { get; set; }
        public String tipoMantenimiento { get; set; }
        public String descripcion { get; set; }
        public String supervisor { get; set; }
        public String fecha { get; set; }
    }
}
