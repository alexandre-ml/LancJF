using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LancJF.Models;

namespace LancJF.Data
{
    public class LancJFContext : DbContext
    {
        public LancJFContext (DbContextOptions<LancJFContext> options)
            : base(options)
        {
        }

        public DbSet<LancJF.Models.Categoria> Categoria { get; set; }

        public DbSet<LancJF.Models.Produto> Produto { get; set; }

        public DbSet<LancJF.Models.Pedido> Pedido { get; set; }

        public DbSet<LancJF.Models.ItemPedido> ItemPedido { get; set; }
    }
}
