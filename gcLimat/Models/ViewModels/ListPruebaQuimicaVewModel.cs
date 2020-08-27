using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gcLimat.Models.ViewModels
{
    public class ListPruebaQuimicaVewModel
    {
        public int idPruebaEQuimica { get; set; }
        public String idEquipo { get; set; }
        public String contenidoAgua { get; set; }
        public String numNeutralizacionAcido { get; set; }
        public String PBC { get; set; }
    }
}