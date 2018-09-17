using Fiap.Web.MVC.Models;
using Fiap.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Web.MVC.Controllers
{
    public class ImovelController : Controller
    {
        private ImobiliariaContext _context = new ImobiliariaContext();

        [HttpGet]
        public ActionResult Buscar(int? codigo)
        {
            CarregarComboCategorias();
            
            var lista = _context.Imoveis.Include("Categoria").Where(c => c.CategoriaId == codigo || codigo == null)
                .ToList();
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarComboCategorias();
            return View();
        }

        private void CarregarComboCategorias()
        {
            //Buscar por todas as categorias
            var lista = _context.Categorias.ToList();
            //Enviar para a tela a lista de categorias para o select
            ViewBag.categorias = new SelectList(lista, "CategoriaId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Imovel imovel)
        {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();
            TempData["msg"] = "Imovel cadastrado";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            CarregarComboCategorias();
            return View(_context.Imoveis.Include("Categoria").Include("Escritura").ToList());
        }
    }
}