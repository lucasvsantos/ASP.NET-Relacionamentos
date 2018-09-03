using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Web.MVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public float Descricao { get; set; }

        //Relacionamentos
        public IList<Imovel> Imoveis { get; set; }
    }
}