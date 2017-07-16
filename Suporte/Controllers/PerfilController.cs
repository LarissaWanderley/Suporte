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
                //Perfil antigo = DBPerfil.GetById(perfil.Id);
                //int idLogAnterior = antigo.IdLog;
                //antigo.IdLog = perfil.IdLog;
                //if (nuAcao == 1 || !antigo.Equals(perfil))
                //{
                //    Log log = new Log();
                //    log.NuAcao = nuAcao;
                //    log.IdUsuario = 1;
                //    log.IpUsuario = Request.UserHostAddress;
                //    log.TxTabela = "Perfil";
                //    log.DtTransacao = DateTime.Now;
                //    log.TxUrl = Request.Url.AbsoluteUri;
                //    log.IdLogAnterior = idLogAnterior;
                //    //DbTransaction transacao = GetTransaction();

                //    try
                //    {
                //        DBPerfil.Save(perfil);
                //        //DBPerfil.Save(perfil, transacao);
                //        log.IdChave = perfil.Id;
                //        DBLog.Save(log);
                //        //   DBLog.Save(log, transacao);
                //        perfil.IdLog = log.Id;
                //        DBPerfil.Save(perfil);
                //        //   DBPerfil.Save(perfil,transacao);
                //        if (idLogAnterior > 0)
                //        {
                //            LogDetalhe logDetalhe = new LogDetalhe();
                //            logDetalhe.IdLog = idLogAnterior;
                //            antigo.IdLog = idLogAnterior;
                //            logDetalhe.TxObjeto = JsonConvert.SerializeObject(antigo);
                //            DBLogDetalhe.Save(logDetalhe);
                //            // DBLogDetalhe.Save(logDetalhe, transacao);
                //        }
                //        // transacao.Commit();
                //    }
                //    catch (Exception ex)
                //    {
                //        // if (transacao.Connection != null)
                //        //{
                //        //   transacao.Rollback();
                //        ModelState.AddModelError("perfil.ErroGrava", "Erro na Gravação do Registro");
                //        ViewBag.Perfil = perfil;
                //        return View("Form");
                //        //}
                //    }
                //}
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

        //  string aa = JsonConvert.SerializeObject(log);
        //  Log p1 = JsonConvert.DeserializeObject<Log>(aa);
        //  ou  
        //  Log p = new Log();
        //  JsonConvert.PopulateObject(aa, p);

        public ActionResult Excluir(int id)
        {
            Perfil perfil = DBPerfil.GetById(id);
            string ipUsuario = Request.UserHostAddress;
            string txUrl = Request.Url.AbsoluteUri;
            if (!DBPerfil.Excui(perfil, ipUsuario, txUrl))
            {
                ViewBag.Error = "Erro na Exclusão do Registro";

            }

           //Log log = new Log();
            //log.IdChave = id;
            //log.NuAcao = 3;
            //log.IdUsuario = 1;
            //log.IpUsuario = Request.UserHostAddress;
            //log.TxTabela = "Perfil";
            //log.DtTransacao = DateTime.Now;
            //log.TxUrl = Request.Url.AbsoluteUri;
            //log.IdLogAnterior = DBLog.PesqLogAnterior(log.TxTabela, log.IdChave);
            //DBLog.Save(log);

            //Perfil antigo = DBPerfil.GetById(id);

            //LogDetalhe logDetalhe = new LogDetalhe();
            //logDetalhe.IdLog = id;
            //logDetalhe.TxObjeto = JsonConvert.SerializeObject(antigo);
            //DBLogDetalhe.Save(logDetalhe);

            //DBPerfil.Delete(id);

            return RedirectToAction("Index");
        }
    }
}