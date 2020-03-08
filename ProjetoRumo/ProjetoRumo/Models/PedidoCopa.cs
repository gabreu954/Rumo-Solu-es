using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRumo.Models
{
    public class PedidoCopa
    {
        [Key]
        public int PedidoCopaID { get; set; }
        public Pedido Pedido { get; set; }
        public Copa Copa { get; set; }
    }
}