using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListPruebaFisicaViewModel
    {
        public int idPruebasFisicas { get; set; }
        public String idEquipo { get; set; }
        public String examenVisual { get; set; }
        public String color { get; set; }
        public String tensionInterfacial { get; set; }
        public String gravedadEspecifica15C15C { get; set; }

    }
}