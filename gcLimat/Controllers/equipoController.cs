using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gcLimat.Models;
using gcLimat.Models.ViewModels;

namespace gcLimat.Controllers
 
{
    public class equipoController : Controller
    {
        // GET: equipo
        public ActionResult Index()
        {

            List<ListEquipoViewModel> lst;
            using (gdlimatEntities db= new gdlimatEntities()) {
                  lst = (from d in db.tbl_EQUIPO
                           select new ListEquipoViewModel
                           {
                               idEquipo=d.idEquipo,
                               tipoEquipo = d.tipoEquipo,
                               region = d.region,
                               potenciaMaxima = d.potenciaMaxima,
                               serie = d.serie,
                               marca = d.marca,
                               subEstacion = d.subEstacion,
                               tipoRefrigeracion = d.tipoRefrigeracion,
                               tension = d.tension,
                               cantidadFase = d.cantidadFase,
                               cantidadAceite = d.cantidadAceite,
                               annio = d.annio,
                               MVA = d.MVA,
                               relacioTension = d.relacioTension,
                               humedadRelativa = d.humedadRelativa,
                               temperaturaAmbiente = d.temperaturaAmbiente,
                               temperaturaEquipo = d.temperaturaEquipo,
                               ultimoReporte = d.ultimoReporte,
                               ultimoMantenimiento = d.ultimoMantenimiento,
                               ultimoMuestreo = d.ultimoMuestreo
                           }).ToList();
            }
                return View(lst);
        }
    }
}