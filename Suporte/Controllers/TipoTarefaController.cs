
using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class TipoTarefaController : Controller
    {
        // GET: TipoTarefa
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Tipo Tarefa";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<TipoTarefa> tipoTarefa = DBTipoTarefa.GetAll();
            return View(tipoTarefa);
        }
    }
}