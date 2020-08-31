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
    public class PruebaQuimicaController : Controller
    {
        // GET: PruebaQuimica
        public ActionResult Index()
        {
            List<ListPruebaQuimicaVewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_PRUEBAQUIMICA
                       select new ListPruebaQuimicaVewModel
                       {
                           idPruebaEQuimica = d.idPruebaEQuimica,
                           idEquipo = d.idEquipo,
                           contenidoAgua = d.contenidoAgua,
                           numNeutralizacionAcido = d.numNeutralizacionAcido,
                           PBC = d.PBC
                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult NuevaPruebaQuimica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevaPruebaQuimica(PruebaQuimicaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oPruebaQuimica = new tbl_PRUEBAQUIMICA();

                        oPruebaQuimica.idEquipo = model.idEquipo;
                        oPruebaQuimica.contenidoAgua = model.contenidoAgua;
                        oPruebaQuimica.numNeutralizacionAcido = model.numNeutralizacionAcido;
                        oPruebaQuimica.PBC = model.PBC;
                        
                        db.tbl_PRUEBAQUIMICA.Add(oPruebaQuimica);
                        db.SaveChanges();
 
                    }
                    return Redirect("~/oPruebaQuimica/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult EditarPruebaQuimica(int idPruebaEQuimica)
        {
            PruebaQuimicaViewModel model = new PruebaQuimicaViewModel();
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oPruebaQuimica = db.tbl_PRUEBAQUIMICA.Find(idPruebaEQuimica);

                model.idEquipo = oPruebaQuimica.idEquipo;
                model.contenidoAgua = oPruebaQuimica.contenidoAgua;
                model.numNeutralizacionAcido = oPruebaQuimica.numNeutralizacionAcido;
                model.PBC = oPruebaQuimica.PBC;
            
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarPruebaEQuimica(PruebaQuimicaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oPruebaQuimica = db.tbl_PRUEBAQUIMICA.Find(model.idEquipo);
                        oPruebaQuimica.idEquipo = model.idEquipo;
                        oPruebaQuimica.contenidoAgua = model.contenidoAgua;
                        oPruebaQuimica.numNeutralizacionAcido = model.numNeutralizacionAcido;
                        oPruebaQuimica.PBC = model.PBC;

                        db.Entry(oPruebaQuimica).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/PruebaQuimica/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult EliminarPruebaQuimica(int idPruebaEQuimica)
        {
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oPruebaQuimica = db.tbl_PRUEBAQUIMICA.Find(idPruebaEQuimica);
                db.tbl_PRUEBAQUIMICA.Remove(oPruebaQuimica);
                db.SaveChanges();
            }
            return Redirect("~/PruebaQuimica/");
        }
    }
}