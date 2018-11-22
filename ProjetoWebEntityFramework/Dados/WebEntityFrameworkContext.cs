using Microsoft.EntityFrameworkCore;
using ProjetoWebEntityFramework.Dados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebEntityFramework.Dados
{
    public class WebEntityFrameworkContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }

        //Construtor
        public WebEntityFrameworkContext(DbContextOptions<WebEntityFrameworkContext> options) : base(options)
        { }

        //Cria as tabelas do banco
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
