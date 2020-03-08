using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRumo.Models
{
    public class Copa
    {
        [Key]
        public int IdCopa { get; set; }
        public string Bebida { get; set; }
        public int Quantidade { get; set; }
    }
}