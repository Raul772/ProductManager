using Microsoft.EntityFrameworkCore;
using RL.Business.Models;

namespace RL.Data.Context
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string)))) 
            {
                property.SetColumnType("varchar(100)");
            }

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
