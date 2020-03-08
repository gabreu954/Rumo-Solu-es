using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRumo.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string Cliente { get; set; }
        public string Mesa { get; set; }
    }
}