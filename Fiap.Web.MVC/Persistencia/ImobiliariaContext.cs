using Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Web.MVC.Persistencia
{
    public class ImobiliariaContext : DbContext
    {
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<Escritura> Escrituras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}