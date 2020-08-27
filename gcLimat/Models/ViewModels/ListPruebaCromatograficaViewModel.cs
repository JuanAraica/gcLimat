using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListPruebaCromatograficaViewModel
    {
        public int idPruebaCroma { get; set; }
        public String idEquipo { get; set; }
        public String dioxidoCarbono { get; set; }
        public String acetileno { get; set; }
        public String etileno { get; set; }
        public String etano { get; set; }
        public String metano { get; set; }
        public String monoxidoCarbono { get; set; }
        public String hidrogeno { get; set; }
        public String totalGasesCombusibles { get; set; }
    }
}