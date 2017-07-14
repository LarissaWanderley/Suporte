using Newtonsoft.Json;
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

             //   LogDetalhe logDetalheAnterior = DBLogDetalhe.PesqUltimo("Perfil", perfil.Id);

                Perfil antigo = DBPerfil.GetById(perfil.Id);
                int idLogAnterior = antigo.IdLog;
                antigo.IdLog = perfil.IdLog;

                if (nuAcao == 1 || !antigo.Equals(perfil))
                    {
                    DBPerfil.Save(perfil);
                    Log log = new Log();
                    log.IdChave = perfil.Id;
                    log.NuAcao = nuAcao;
                    log.IdUsuario = 1;
                    log.IpUsuario = Request.UserHostAddress;
                    log.TxTabela = "Perfil";
                    log.DtTransacao = DateTime.Now;
                    log.TxUrl = Request.Url.AbsoluteUri;
                    log.IdLogAnterior = idLogAnterior;
                    DBLog.Save(log);
                    perfil.IdLog = log.Id;
                    DBPerfil.Save(perfil);

                  //  
                    if (idLogAnterior > 0)
                        {
                            antigo.IdLog = idLogAnterior;
                      
                            LogDetalhe logDetalhe = new LogDetalhe();
                            logDetalhe.IdLog = idLogAnterior;
                            logDetalhe.TxObjeto = JsonConvert.SerializeObject(antigo);
                            DBLogDetalhe.Save(logDetalhe);
                        }
                    }             
                //  string aa = JsonConvert.SerializeObject(log);
                //  Log p1 = JsonConvert.DeserializeObject<Log>(aa);
                //  ou  
                //  Log p = new Log();
                //  JsonConvert.PopulateObject(aa, p);

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
            Log log = new Log();
            log.IdChave = id;
            log.NuAcao = 3;
            log.IdUsuario = 1;
            log.IpUsuario = Request.UserHostAddress;
            log.TxTabela = "Perfil";
            log.DtTransacao = DateTime.Now;
            log.TxUrl = Request.Url.AbsoluteUri;
            log.IdLogAnterior = DBLog.PesqLogAnterior(log.TxTabela, log.IdChave);
            DBLog.Save(log);

            Perfil antigo = DBPerfil.GetById(id);

            LogDetalhe logDetalhe = new LogDetalhe();
            logDetalhe.IdLog = id;
            logDetalhe.TxObjeto = JsonConvert.SerializeObject(antigo);
            DBLogDetalhe.Save(logDetalhe);

            DBPerfil.Delete(id);
            return RedirectToAction("Index");


        }
    }
}