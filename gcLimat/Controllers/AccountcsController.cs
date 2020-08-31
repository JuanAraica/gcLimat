using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gcLimat.Models;

namespace gcLimat.Controllers
{
    public class AccountcsController : Controller
    {
        // GET: Accountcs
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Verify(Accountcs acc)
        {
            return View();
        }
    }
}