using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRumo.Models
{
    public class PedidoCozinha
    {
        [Key]
        public int PedidoCozinhaId { get; set; }
        public Pedido Pedido { get; set; }
        public Cozinha Cozinha { get; set; }
    }
}