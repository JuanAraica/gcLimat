using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListPruebaElectricaViewModel
    {
        public int idPruebaElectrica { get; set; }
        public String idEquipo { get; set; }
        public String rigidezDioElectrica { get; set; }
        public String factorPotencia100C { get; set; }
        public String resistividad100 { get; set; }
    }
}