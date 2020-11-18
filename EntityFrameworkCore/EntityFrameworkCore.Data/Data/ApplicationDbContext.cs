using EntityFrameworkCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=EntityFrameworkCore;Integrated Security=true");            
        }

        // Modelagem do Banco de Dados separado por Tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);            
        }
    }
}
