using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Web.MVC.Models
{
    public class Escritura
    {
        public int EscrituraId { get; set; }
        public string Proprietario { get; set; }
        public int NumeroCartorio { get; set; }
    }
}