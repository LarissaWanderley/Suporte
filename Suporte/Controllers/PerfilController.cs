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
            if ( ModelState.IsValid && perfil.Id < 1)
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
                Log log = new Log();
                log.IdChave = perfil.Id;
                log.NuAcao = 1;
                log.IdUsuario = 1;
                log.IpUsuario = Request.UserHostAddress;
                log.TxTabela = "Perfil";
                log.DtTransacao = DateTime.Now;
                log.TxUrl = Request.Url.AbsoluteUri;

                int i = DBLog.PesqLogAnterior(log.TxTabela, log.IdChave);
                if (i > 0)
                {
                    log.IdLogAnterior = i ;
                }
               
                DBLog.Save(log);



                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Perfil = perfil;
                return View("Form");
            }
        }
      
        public ActionResult Excluir(int id)
        {

            DBPerfil.Delete(id);
            return RedirectToAction("Index");


        }
    }
}