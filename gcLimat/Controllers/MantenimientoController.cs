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
    }
}