using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suporte.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.Title = "Login";
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
            }
            return View();
        }
        public ActionResult Autentica(String login, String senha)
        {
            Usuario usuario = DBUsuario.ValidaLogin(login, senha);

            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario.TxNome;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Error"] = "Login/Senha invalidos";
                return RedirectToAction("Index");
            }

        }
        public ActionResult Logout()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Index", "Home");
        }
    }

}