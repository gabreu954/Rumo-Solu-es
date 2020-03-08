using ProjetoRumo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjetoRumo.Data
{
    public class PedidoContext : DbContext
    {
        public DbSet<Copa> Copa { get; set; }
        public DbSet<Cozinha> Cozinha { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoCopa> PedidoCopa { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinha { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}