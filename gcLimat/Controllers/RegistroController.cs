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
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            List<ListRegistroViewModel> lst;
            using (gdlimatEntities1 db = new gdlimatEntities1())
            {
                lst = (from d in db.tbl_REGISTROS
                       select new ListRegistroViewModel
                       {
                           registro = d.registro


            }).ToList();
            }
            return View(lst);
        }

    public ActionResult RegistrarEvento()
    {
        return View();
    }

    [HttpPost]
    public ActionResult RegistrarEvento(RegistroViewModel model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                using (gdlimatEntities1 db = new gdlimatEntities1())
                {

                    var oRegistro = new tbl_REGISTROS();
                        oRegistro.registro = "Se ha registrado un nuevo equipo al ser "+DateTime.Now;
                        db.tbl_REGISTROS.Add(oRegistro);
                        db.SaveChanges();
                    }
            }
            return View(model);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
}