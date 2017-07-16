using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class MotivoController : Controller
    {
        // GET: Motivo
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Motivo";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<Motivo> motivo = DBMotivo.GetAll();
            return View(motivo);
        }
    }
}