using Newtonsoft.Json;
using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Perfil";
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
            int nuAcao = perfil.Id < 1 ? 1 : 2;
            if (nuAcao == 1)
            {
                List<Perfil> existe = DBPerfil.PorNome(perfil.TxPerfil);
                if (existe.Count > 0)
                {
                    ModelState.AddModelError("perfil.NomeJaCadastrado", "Perfil já Cadastrado");
                }
            }

            if (ModelState.IsValid)
            {
               
                string ipUsuario = Request.UserHostAddress;
                string txUrl = Request.Url.AbsoluteUri;
                if (DBPerfil.Sava(perfil , ipUsuario, txUrl))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Perfil = perfil;
                    return View("Form");
                }
                   
               
            }
            else
            {
                ViewBag.Perfil = perfil;
                return View("Form");
            }
        }


        public ActionResult Excluir(int id)
        {
            Perfil perfil = DBPerfil.GetById(id);
            string ipUsuario = Request.UserHostAddress;
            string txUrl = Request.Url.AbsoluteUri;
            if (!DBPerfil.Excui(perfil, ipUsuario, txUrl))
            {
                TempData["Error"] = "Erro na Exclusão do Registro";
            }
            return RedirectToAction("Index");
        }
    }
}