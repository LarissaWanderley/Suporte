using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class SetorController : Controller
    {
        // GET: Setor
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Setor";
            return View();
        }
    }
}