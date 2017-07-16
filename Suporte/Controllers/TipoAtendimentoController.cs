using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class TipoAtendimentoController : Controller
    {
        // GET: TipoAtendimento
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Tipo Atendimento";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<TipoAtendimento> tipoAtendimento = DBTipoAtendimento.GetAll();
            return View(tipoAtendimento);
        }
    }
}