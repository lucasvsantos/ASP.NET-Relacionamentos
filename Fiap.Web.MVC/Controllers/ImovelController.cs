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
        public ActionResult Cadastrar()
        {
            //Buscar por todas as categorias
            var lista = _context.Categorias.ToList();
            //Enviar para a atela a lista de categorias para o select
            ViewBag.categorias = new SelectList(lista, "CategoriaId", "Nome");
            return View();
        }

        public ActionResult Listar()
        {
            return View(_context.Imoveis.ToList());
        }
    }
}