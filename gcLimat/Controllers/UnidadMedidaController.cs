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
    public class UnidadMedidaController : Controller
    {
        // GET: UnidadMedida
        public ActionResult Index()
        {
            List<ListUnidadMedidaViewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_UNIDADMEDIDA
                       select new ListUnidadMedidaViewModel
                       {
                            factorAMedir = d.factorAMedir,
                            unidadMedida = d.unidadMedida,
                            valorRecomendado = d.valorRecomendado
                        }).ToList();
            }
            return View(lst);
        }
    }
}