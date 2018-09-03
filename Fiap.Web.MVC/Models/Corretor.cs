using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Web.MVC.Models
{
    public class Corretor
    {
        [Key]
        public int NumeroCreci { get; set; }
        public string Nome { get; set; }
        public float Comissao { get; set; }

        //Relacionamentos
        public IList<Imovel> Imoveis { get; set; }
    }
}