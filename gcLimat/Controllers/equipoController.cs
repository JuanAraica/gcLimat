using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Windows.Controls;
using gcLimat.Models;
using gcLimat.Models.ViewModels;
using Xceed.Wpf.Toolkit;

namespace gcLimat.Controllers
{
    public class equipoController : Controller
    {
        RegistroController registro = new RegistroController();
        // GET: equipo
        public ActionResult Index()
        {
            List<ListEquipoViewModel> lst;
            using (gdlimatEntities1 db= new gdlimatEntities1())
            {
                lst = (from d in db.tbl_EQUIPO
                       select new ListEquipoViewModel
                       {
                           idEquipo = d.idEquipo,
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

        public ActionResult NuevoEquipo() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoEquipo(EquipoViewModel model)
        {
            try 
            {
                if (ModelState.IsValid) 
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    { 
                    var oEquipo = new tbl_EQUIPO();
                    var oRegistro  = new tbl_REGISTROS();
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

                        registro.RegistrarEvento();
                    }
                    return Redirect("~/equipo/");
                }
                return View(model);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult EditarEquipo(String idEquipo)
        {
            EquipoViewModel model = new EquipoViewModel();
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oEquipo = db.tbl_EQUIPO.Find(idEquipo);

                model.tipoEquipo = oEquipo.tipoEquipo;
                model.region = oEquipo.region;
                model.potenciaMaxima = oEquipo.potenciaMaxima;
                model.serie = oEquipo.serie;
                model.marca = oEquipo.marca;
                model.subEstacion = oEquipo.subEstacion;
                model.tipoRefrigeracion = oEquipo.tipoRefrigeracion;
                model.tension = oEquipo.tension;
                model.cantidadFase = oEquipo.cantidadFase;
                model.cantidadAceite = oEquipo.cantidadAceite;
                model.annio = oEquipo.annio;
                model.MVA = oEquipo.MVA;
                model.relacioTension = oEquipo.relacioTension;
                model.humedadRelativa = oEquipo.humedadRelativa;
                model.temperaturaAmbiente = oEquipo.temperaturaAmbiente;
                model.temperaturaEquipo = oEquipo.temperaturaEquipo;
                model.ultimoReporte = oEquipo.ultimoReporte;
                model.ultimoMantenimiento = oEquipo.ultimoMantenimiento;
                model.ultimoMuestreo = oEquipo.ultimoMuestreo;
                model.idEquipo = oEquipo.idEquipo;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarEquipo(EquipoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oEquipo = db.tbl_EQUIPO.Find(model.idEquipo);
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

                        db.Entry(oEquipo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/equipo/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult EliminarEquipo(String idEquipo)
        {
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oEquipo = db.tbl_EQUIPO.Find(idEquipo);
                db.tbl_EQUIPO.Remove(oEquipo);
                db.SaveChanges();
            }
            return Redirect("~/equipo/");
        }
    }
}