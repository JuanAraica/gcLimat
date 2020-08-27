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
            using (gdlimatEntities db = new gdlimatEntities())
                return View();
        }
    }
}