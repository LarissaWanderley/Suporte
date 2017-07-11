using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fazendas.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            List<Perfil> perfil = DBPerfil.GetAll();
            return View(perfil);
        }
        public ActionResult Incluir()
        {
            ViewBag.Perfil = new Perfil();
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Perfil perfil)
        {
            List<Perfil> existe = DBPerfil.PorNome(perfil.TxPerfil);
            if (existe.Count > 0)
            {
                ModelState.AddModelError("perfuk.NomeJaCadastrado", "Perfil já Cadastrado");
            }
            if (ModelState.IsValid)
            {
                DBPerfil.Save(perfil);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Perfil = perfil;
                return View("Form");
            }
        }
        public ActionResult Visualizar(int id)
        {
            Perfil perfil = DBPerfil.GetById(id);
            ViewBag.Perfil = perfil;
            return View();
        }
        public ActionResult Altera(Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                DBPerfil.Save(perfil);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Perfil = perfil;
                return View("Visualiza");
            }

        }
        public ActionResult Excluir(int id)
        {
            {
                List<Usuario> existe = DBUsuario.PorPerfil(id);
                if (existe.Count > 0)
                {
                    TempData["Error"] = "Perfil já Cadastrado";
                    return RedirectToAction("Index");
                }
                else
                {
                    DBPerfil.Delete(id);
                    return RedirectToAction("Index");
                }


            }
        }
    }
}