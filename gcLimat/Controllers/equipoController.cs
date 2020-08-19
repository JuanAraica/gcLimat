using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
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
        public ActionResult NuevoEquipo() {
            return View( );

        }
        public ActionResult NuevoEquipo(EquipoViewModel model)
        {
            try {
                if (ModelState.IsValid) 
                {
                    using (gdlimatEntities db = new gdlimatEntities()) { 
                        var oEquipo = new tbl_EQUIPO();
                    oEquipo.idEquipo = model.idEquipo;
                    oEquipo.tipoEquipo = model.tipoEquipo;
                    oEquipo.region = model.region;
                    oEquipo.potenciaMaxima = model.potenciaMaxima;
                    oEquipo.serie = model.serie;
                    oEquipo.marca = model.marca;
                    oEquipo.subEstacion = model.subEstacion;
                    oEquipo.tipoRefrigeracion = model.tipoRefrigeracion;
                    oEquipo.tension = model.tension;
                    oEquipo.cantidadFase = model.cantidadFase;
                    oEquipo.cantidadAceite = model.cantidadAceite;
                    oEquipo.annio = model.annio;
                    oEquipo.MVA = model.MVA;
                    oEquipo.relacioTension = model.relacioTension;
                    oEquipo.humedadRelativa = model.humedadRelativa;
                    oEquipo.temperaturaAmbiente = model.temperaturaAmbiente;
                    oEquipo.temperaturaEquipo = model.temperaturaEquipo;
                    oEquipo.ultimoReporte = model.ultimoReporte;
                    oEquipo.ultimoMantenimiento = model.ultimoMantenimiento;
                    oEquipo.ultimoMuestreo = model.ultimoMuestreo;
                        db.tbl_EQUIPO.Add(oEquipo);
                        db.SaveChanges();
                    }
                }
                return Redirect("~/equipo/");
            } catch (Exception ex) {
                throw new Exception(ex.Message);
                    }

        }

    }
}