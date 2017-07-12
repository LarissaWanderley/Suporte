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

        public ActionResult Form(int id)
        {
            if (id == 0)
            {
                ViewBag.Perfil = new Perfil();
            }
            else
            {
                Perfil perfil = DBPerfil.GetById(id);
                ViewBag.Perfil = perfil;
            } 
            return View();
        }
        [HttpPost]
        public ActionResult Gravar(Perfil perfil)
        {
            if (perfil.Id < 1)
            {
                List<Perfil> existe = DBPerfil.PorNome(perfil.TxPerfil);
                if (existe.Count > 0)
                {
                    ModelState.AddModelError("perfil.NomeJaCadastrado", "Perfil já Cadastrado");
                }
            }
            
            if (ModelState.IsValid)
            {
                DBPerfil.Save(perfil);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Perfil = perfil;
                return View(perfil.Id < 1 ? "Form" : "Visualizar");
            }
        }
      
        public ActionResult Excluir(int id)
        {

            DBPerfil.Delete(id);
            return RedirectToAction("Index");


        }
    }
}