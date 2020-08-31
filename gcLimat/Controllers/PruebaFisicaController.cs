using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Windows.Controls;
using gcLimat.Models;
using gcLimat.Models.ViewModels;

namespace gcLimat.Controllers
{
    public class PruebaFisicaController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            List<ListPruebaFisicaViewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_PRUEBAFISICA
                       select new ListPruebaFisicaViewModel
                       {
                           idPruebasFisicas = d.idPruebasFisicas,
                           idEquipo = d.idEquipo,
                           examenVisual = d.examenVisual,
                           color = d.color,
                           tensionInterfacial = d.tensionInterfacial,
                           gravedadEspecifica15C15C = d.gravedadEspecifica15C15C
                       }).ToList();
            }
            return View(lst);
        }

    public ActionResult NuevaPruebaFisica()
    {
        return View();
    }

    [HttpPost]
    public ActionResult NuevaPruebaFisica(PruebaFisicaViewModel model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                using (gdlimatEntities1 db = new gdlimatEntities1())
                {
                    var oPruebaFisica = new tbl_PRUEBAFISICA();

                        oPruebaFisica.idEquipo = model.idEquipo;
                        oPruebaFisica.examenVisual = model.examenVisual;
                        oPruebaFisica.color = model.color;
                        oPruebaFisica.tensionInterfacial = model.tensionInterfacial;
                        oPruebaFisica.gravedadEspecifica15C15C = model.gravedadEspecifica15C15C;
 
                    db.tbl_PRUEBAFISICA.Add(oPruebaFisica);
                    db.SaveChanges();


                }
                return Redirect("~/PruebaFisica/");
            }
            return View(model);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public ActionResult EditarPruebaFisica(String idEquipo)
    {
            PruebaFisicaViewModel model = new PruebaFisicaViewModel();
        using (gdlimatEntities1 db = new gdlimatEntities1())
        {
            var oPruebaFisica = db.tbl_PRUEBAFISICA.Find(idEquipo);

            model.idEquipo = oPruebaFisica.idEquipo;
            model.examenVisual = oPruebaFisica.examenVisual;
            model.color = oPruebaFisica.color;
            model.tensionInterfacial = oPruebaFisica.tensionInterfacial;
            model.gravedadEspecifica15C15C = oPruebaFisica.gravedadEspecifica15C15C;

            }
        return View(model);
    }

    [HttpPost]
    public ActionResult EditarPruebaFisica(PruebaFisicaViewModel model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                using (gdlimatEntities1 db = new gdlimatEntities1())
                {
                    var oPruebaFisica = db.tbl_PRUEBAFISICA.Find(model.idEquipo);
                        oPruebaFisica.idEquipo = model.idEquipo;
                        oPruebaFisica.examenVisual = model.examenVisual;
                        oPruebaFisica.color = model.color;
                        oPruebaFisica.tensionInterfacial = model.tensionInterfacial;
                        oPruebaFisica.gravedadEspecifica15C15C = model.gravedadEspecifica15C15C;
                        db.Entry(oPruebaFisica).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }

                return Redirect("~/PruebaFisica/");
            }
            return View(model);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpGet]
    public ActionResult EliminarPruebaFisica(String idEquipo)
    {
        using (gdlimatEntities1 db = new gdlimatEntities1())
        {
            var oPruebaFisica = db.tbl_PRUEBAFISICA.Find(idEquipo);
            db.tbl_PRUEBAFISICA.Remove(oPruebaFisica);
            db.SaveChanges();
        }
        return Redirect("~/PruebaFisica/");
    }
    }
}