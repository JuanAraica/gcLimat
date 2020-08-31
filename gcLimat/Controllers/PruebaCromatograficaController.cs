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
    public class PruebaCromatograficaController : Controller
    {
        // GET: PruebaCromatografica
        public ActionResult Index()
        {
            List<ListPruebaCromatograficaViewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_PRUEBACROMATOGRAFICA
                select new ListPruebaCromatograficaViewModel
                {
                    idPruebaCroma = d.idPruebaCroma,
                    idEquipo = d.idEquipo,
                    dioxidoCarbono = d.dioxidoCarbono,
                    acetileno = d.acetileno,
                    etileno = d.etileno,
                    etano = d.etano,
                    metano = d.metano,
                    monoxidoCarbono = d.monoxidoCarbono,
                    hidrogeno = d.hidrogeno,
                    totalGasesCombusibles = d.totalGasesCombusibles
                }).ToList();
            }
            return View(lst);
        }


        public ActionResult NuevaPruebaCromatografica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevaPruebaCromatografica(PruebaCromatograficaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oPruebaCromatografica = new tbl_PRUEBACROMATOGRAFICA();
                        oPruebaCromatografica.idEquipo = model.idEquipo;
                        oPruebaCromatografica.dioxidoCarbono = model.dioxidoCarbono;
                        oPruebaCromatografica.acetileno = model.acetileno;
                        oPruebaCromatografica.etileno = model.etileno;
                        oPruebaCromatografica.etano = model.etano;
                        oPruebaCromatografica.metano = model.metano;
                        oPruebaCromatografica.monoxidoCarbono = model.monoxidoCarbono;
                        oPruebaCromatografica.hidrogeno = model.hidrogeno;
                        oPruebaCromatografica.totalGasesCombusibles = model.totalGasesCombusibles;

                        db.tbl_PRUEBACROMATOGRAFICA.Add(oPruebaCromatografica);
                        db.SaveChanges();

                    }
                    return Redirect("~/PruebaCromatografica/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult EditarPruebaCromatografica(int idPruebaCroma)
        {
            PruebaCromatograficaViewModel model = new PruebaCromatograficaViewModel();
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oPruebaCromatografica = db.tbl_PRUEBACROMATOGRAFICA.Find(idPruebaCroma);
                model.idEquipo = oPruebaCromatografica.idEquipo;
                model.dioxidoCarbono = oPruebaCromatografica.dioxidoCarbono;
                model.acetileno = oPruebaCromatografica.acetileno;
                model.etileno = oPruebaCromatografica.etileno;
                model.etano = oPruebaCromatografica.etano;
                model.metano = oPruebaCromatografica.metano;
                model.monoxidoCarbono = oPruebaCromatografica.monoxidoCarbono;
                model.hidrogeno = oPruebaCromatografica.hidrogeno;
                model.totalGasesCombusibles = oPruebaCromatografica.totalGasesCombusibles;

            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarPruebaCromatografica(PruebaCromatograficaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oPruebaCromatografica = db.tbl_PRUEBACROMATOGRAFICA.Find(model.idPruebaCroma);
                        oPruebaCromatografica.idEquipo = model.idEquipo;
                        oPruebaCromatografica.dioxidoCarbono = model.dioxidoCarbono;
                        oPruebaCromatografica.acetileno = model.acetileno;
                        oPruebaCromatografica.etileno = model.etileno;
                        oPruebaCromatografica.etano = model.etano;
                        oPruebaCromatografica.metano = model.metano;
                        oPruebaCromatografica.monoxidoCarbono = model.monoxidoCarbono;
                        oPruebaCromatografica.hidrogeno = model.hidrogeno;
                        oPruebaCromatografica.totalGasesCombusibles = model.totalGasesCombusibles;

                        db.Entry(oPruebaCromatografica).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/PruebaCromatografica/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult EliminarPruebaCromatografica(int idPruebaCroma)
        {
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oPruebaCromatografica = db.tbl_PRUEBACROMATOGRAFICA.Find(idPruebaCroma);
                db.tbl_PRUEBACROMATOGRAFICA.Remove(oPruebaCromatografica);
                db.SaveChanges();
            }
            return Redirect("~/PruebaCromatografica/");
        }
    }
}