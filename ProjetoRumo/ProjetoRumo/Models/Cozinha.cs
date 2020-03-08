using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRumo.Models
{
    public class Cozinha
    {
        [Key]
        public int IdCozinha { get; set; }
        public string Prato { get; set; }
        public int Quantidade { get; set; }
    }
}