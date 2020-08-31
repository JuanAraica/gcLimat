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
    public class PruebaElectricaController : Controller
    {
        // GET: PruebaElectrica
        public ActionResult Index()
        {
            List<ListPruebaElectricaViewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_PRUEBAELECTRICA
                       select new ListPruebaElectricaViewModel
                       {
                        idPruebaElectrica = d.idPruebaElectrica,
                        idEquipo = d.idEquipo,
                        rigidezDioElectrica = d.rigidezDioElectrica,
                        factorPotencia100C = d.factorPotencia100C,
                        resistividad100 = d.resistividad100
                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult NuevaPruebaElectrica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevaPruebaElectrica(PruebaElectricaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {

                        var oPruebaElectrica = new tbl_PRUEBAELECTRICA();
                        oPruebaElectrica.idEquipo = model.idEquipo;
                        oPruebaElectrica.rigidezDioElectrica = model.rigidezDioElectrica;
                        oPruebaElectrica.factorPotencia100C = model.factorPotencia100C;
                        oPruebaElectrica.resistividad100 = model.resistividad100;
                        db.tbl_PRUEBAELECTRICA.Add(oPruebaElectrica);
                        db.SaveChanges();

                    }
                    return Redirect("~/PruebaElectrica/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult EditarPruebaElectrica(int idPruebaElectrica)
        {
            PruebaElectricaViewModel model = new PruebaElectricaViewModel();
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oPruebaElectrica = db.tbl_PRUEBAELECTRICA.Find(idPruebaElectrica);

                model.idEquipo = oPruebaElectrica.idEquipo;
                model.rigidezDioElectrica = oPruebaElectrica.rigidezDioElectrica;
                model.factorPotencia100C = oPruebaElectrica.factorPotencia100C;
                model.resistividad100 = oPruebaElectrica.resistividad100;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarPruebaElectrica(PruebaElectricaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oPruebaElectrica = db.tbl_PRUEBAELECTRICA.Find(model.idPruebaElectrica);
                        oPruebaElectrica.idEquipo = model.idEquipo;
                        oPruebaElectrica.rigidezDioElectrica = model.rigidezDioElectrica;
                        oPruebaElectrica.factorPotencia100C = model.factorPotencia100C;
                        oPruebaElectrica.resistividad100 = model.resistividad100;

                        db.Entry(oPruebaElectrica).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/PruebaElectrica/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult EliminarPruebaElectrica(int idPruebaElectrica)
        {
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oPruebaElectrica = db.tbl_PRUEBAELECTRICA.Find(idPruebaElectrica);
                db.tbl_PRUEBAELECTRICA.Remove(oPruebaElectrica);
                db.SaveChanges();
            }
            return Redirect("~/PruebaElectrica/");
        }
    }
}