using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class SolucaoController : Controller
    {
        // GET: Solucao
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Solução";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<Solucao> solucao = DBSolucao.GetAll();
            return View(solucao);
        }
    }
}