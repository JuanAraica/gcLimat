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
    public class MantenimientoController : Controller
    {
        // GET: Mantenimiento
        public ActionResult Index()
        {
            List<ListMantenimientoViewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_MANTENIMIENTO
                       select new ListMantenimientoViewModel
                       {
                           idMantenimiento = d.idMantenimiento,
                           idEquipo = d.idEquipo,
                           tipoMantenimiento = d.tipoMantenimiento,
                           descripcion = d.descripcion,
                           supervisor = d.supervisor,
                           fecha = d.fecha

                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult NuevoMantenimiento ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoMantenimiento(MantenimientoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oMantenimiento= new tbl_MANTENIMIENTO();
                        oMantenimiento.idEquipo = model.idEquipo;
                        oMantenimiento.tipoMantenimiento = model.tipoMantenimiento;
                        oMantenimiento.descripcion = model.descripcion;
                        oMantenimiento.supervisor = model.supervisor;
                        oMantenimiento.fecha = model.fecha;

                        db.tbl_MANTENIMIENTO.Add(oMantenimiento);
                        db.SaveChanges();
                    }
                    return Redirect("~/Mantenimiento/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }









        public ActionResult EditarMantenimiento(int idMantenimiento)
        {
            MantenimientoViewModel model = new MantenimientoViewModel();
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oMantenimiento = db.tbl_MANTENIMIENTO.Find(idMantenimiento);
                model.tipoMantenimiento = oMantenimiento.tipoMantenimiento;
                model.descripcion = oMantenimiento.descripcion;
                model.supervisor = oMantenimiento.supervisor;
                model.fecha = oMantenimiento.fecha;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarMantenimiento(MantenimientoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (gdlimatEntities1 db = new gdlimatEntities1())
                    {
                        var oMantenimiento = db.tbl_MANTENIMIENTO.Find(model.idMantenimiento);
                        oMantenimiento.idEquipo = model.idEquipo;
                        oMantenimiento.tipoMantenimiento = model.tipoMantenimiento;
                        oMantenimiento.descripcion = model.descripcion;
                        oMantenimiento.supervisor = model.supervisor;
                        oMantenimiento.fecha = model.fecha;

                        db.Entry(oMantenimiento).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/Mantenimiento/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult EliminarMantenimiento(int idMantenimiento)
        {
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                var oMantenimiento = db.tbl_MANTENIMIENTO.Find(idMantenimiento);
                db.tbl_MANTENIMIENTO.Remove(oMantenimiento);
                db.SaveChanges();
            }
            return Redirect("~/Mantenimiento/");
        }
    }
}