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
                return View();
        }
    }
}