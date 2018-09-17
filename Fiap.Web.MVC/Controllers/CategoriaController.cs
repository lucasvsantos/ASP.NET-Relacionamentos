using Fiap.Web.MVC.Models;
using Fiap.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Web.MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private ImobiliariaContext _context = new ImobiliariaContext();

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            TempData["msg"] = "Categoria cadastrada!!!!!!!!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var retornoCategorias = _context.Categorias.ToList();
            ViewBag.categorias = new SelectList(retornoCategorias, "CategoriaId", "Nome");
            return View("Listar");
        }
    }
}