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
                return View();
        }
    }
}