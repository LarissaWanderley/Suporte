using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class ComputadorController : Controller
    {
        // GET: Computador
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Computador";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<Computador> computador = DBComputador.GetAll();
            return View(computador);
        }
    }
}