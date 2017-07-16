using Suporte.Dominio;
using Suporte.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fazendas.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            ViewBag.Title = "Lista Usuário";
            List<Usuario> usuarios = DBUsuario.GetAll();
            return View(usuarios);
        }
        public ActionResult Incluir()
        {
              return View();
          }
        public ActionResult Adiciona(Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                List<Usuario> existe = DBUsuario.PorNome(usuario.TxNome);
                if (existe.Count > 0)
                {
                    ModelState.AddModelError("usuario.NomeJaCadastrado", "Nome do Usuário já Cadastrado");
                }
            }
            if (ModelState.IsValid)
            {
                DBUsuario.Save(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Usuario = usuario; ;
                return View("Form");
            }
        }
        public ActionResult Excluir(int id)
        {
            {
                DBUsuario.Delete(id);
                return RedirectToAction("Index");
            }
        }
    }
   
}