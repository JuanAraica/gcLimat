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
            try
            {
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }  
        }

        [HttpPost]
        public ActionResult EditarEquipo(EquipoViewModel model)
        {
            EquipoViewModel model2 = new EquipoViewModel();
            model2 = model;
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                {
                    var oEquipo = db.tbl_EQUIPO.Find(model.idEquipo);





                    //model2.idEquipo = model.idEquipo;
                    //model2.tipoEquipo = model.tipoEquipo;
                    //model2.region = model.region;
                    //model2.potenciaMaxima = model.potenciaMaxima;
                    //model2.serie = model.serie;
                    //model2.marca = model.marca;
                    //model2.subEstacion = model.subEstacion;
                    //model2.tipoRefrigeracion = model.tipoRefrigeracion;
                    //model2.tension = model.tension;
                    //model2.cantidadFase = model.cantidadFase;
                    //model2.cantidadAceite = model.cantidadAceite;
                    //model2.annio = model.annio;
                    //model2.MVA = model.MVA;
                    //model2.relacioTension = model.relacioTension;
                    //model2.humedadRelativa = model.humedadRelativa;
                    //model2.temperaturaAmbiente = model.temperaturaAmbiente;
                    //model2.temperaturaEquipo = model.temperaturaEquipo;
                    //model2.ultimoReporte = model.ultimoReporte;
                    //model2.ultimoMantenimiento = model.ultimoMantenimiento;
                    //model2.ultimoMuestreo = model.ultimoMuestreo;

                    oEquipo.idEquipo = model2.idEquipo;
                    oEquipo.tipoEquipo = model2.tipoEquipo;
                    oEquipo.region = model2.region;
                    oEquipo.potenciaMaxima = model2.potenciaMaxima;
                    oEquipo.serie = model2.serie;
                    oEquipo.marca = model2.marca;
                    oEquipo.subEstacion = model2.subEstacion;
                    oEquipo.tipoRefrigeracion = model2.tipoRefrigeracion;
                    oEquipo.tension = model2.tension;
                    oEquipo.cantidadFase = model2.cantidadFase;
                    oEquipo.cantidadAceite = model2.cantidadAceite;
                    oEquipo.annio = model2.annio;
                    oEquipo.MVA = model2.MVA;
                    oEquipo.relacioTension = model2.relacioTension;
                    oEquipo.humedadRelativa = model2.humedadRelativa;
                    oEquipo.temperaturaAmbiente = model2.temperaturaAmbiente;
                    oEquipo.temperaturaEquipo = model2.temperaturaEquipo;
                    oEquipo.ultimoReporte = model2.ultimoReporte;
                    oEquipo.ultimoMantenimiento = model2.ultimoMantenimiento;
                    oEquipo.ultimoMuestreo = model2.ultimoMuestreo;


                    //oEquipo.idEquipo = model.idEquipo;
                    //oEquipo.tipoEquipo = model.tipoEquipo;
                    //oEquipo.region = model.region;
                    //oEquipo.potenciaMaxima = model.potenciaMaxima;
                    //oEquipo.serie = model.serie;
                    //oEquipo.marca = model.marca;
                    //oEquipo.subEstacion = model.subEstacion;
                    //oEquipo.tipoRefrigeracion = model.tipoRefrigeracion;
                    //oEquipo.tension = model.tension;
                    //oEquipo.cantidadFase = model.cantidadFase;
                    //oEquipo.cantidadAceite = model.cantidadAceite;
                    //oEquipo.annio = model.annio;
                    //oEquipo.MVA = model.MVA;
                    //oEquipo.relacioTension = model.relacioTension;
                    //oEquipo.humedadRelativa = model.humedadRelativa;
                    //oEquipo.temperaturaAmbiente = model.temperaturaAmbiente;
                    //oEquipo.temperaturaEquipo = model.temperaturaEquipo;
                    //oEquipo.ultimoReporte = model.ultimoReporte;
                    //oEquipo.ultimoMantenimiento = model.ultimoMantenimiento;
                    //oEquipo.ultimoMuestreo = model.ultimoMuestreo;
                    //model2.idEquipo = db.tbl_EQUIPO.Find(model.idEquipo).idEquipo;
                    //model2.tipoEquipo = db.tbl_EQUIPO.Find(model.idEquipo).tipoEquipo;
                    //model2.region = db.tbl_EQUIPO.Find(model.idEquipo).region;
                    //model2.potenciaMaxima = db.tbl_EQUIPO.Find(model.idEquipo).potenciaMaxima;
                    //model2.serie = db.tbl_EQUIPO.Find(model.idEquipo).serie;
                    //model2.marca = db.tbl_EQUIPO.Find(model.idEquipo).marca;
                    //model2.subEstacion = db.tbl_EQUIPO.Find(model.idEquipo).subEstacion;
                    //model2.tipoRefrigeracion = db.tbl_EQUIPO.Find(model.idEquipo).tipoRefrigeracion;
                    //model2.tension = db.tbl_EQUIPO.Find(model.idEquipo).tension;
                    //model2.cantidadFase = db.tbl_EQUIPO.Find(model.idEquipo).cantidadFase;
                    //model2.cantidadAceite = db.tbl_EQUIPO.Find(model.idEquipo).cantidadAceite;
                    //model2.annio = db.tbl_EQUIPO.Find(model.idEquipo).annio;
                    //model2.MVA = db.tbl_EQUIPO.Find(model.idEquipo).MVA;
                    //model2.relacioTension = db.tbl_EQUIPO.Find(model.idEquipo).relacioTension;
                    //model2.humedadRelativa = db.tbl_EQUIPO.Find(model.idEquipo).humedadRelativa;
                    //model2.temperaturaEquipo = db.tbl_EQUIPO.Find(model.idEquipo).temperaturaEquipo;
                    //model2.ultimoReporte = db.tbl_EQUIPO.Find(model.idEquipo).ultimoReporte;
                    //model2.ultimoMantenimiento = db.tbl_EQUIPO.Find(model.idEquipo).ultimoMantenimiento;
                    //model2.ultimoMuestreo = db.tbl_EQUIPO.Find(model.idEquipo).ultimoMuestreo;
                    //oEquipo = model2;


                    //            db.Entry(oEquipo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("~/equipo/");
                }


                //    }
                //return View(model);

        }
            catch (Exception ex)
            {
                throw  ;
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