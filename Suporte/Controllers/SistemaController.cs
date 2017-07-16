using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class SistemaController : Controller
    {
        // GET: Sistema
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Sistema";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<Sistema> sistema = DBSistema.GetAll();
            return View(sistema);
        }
    }
}