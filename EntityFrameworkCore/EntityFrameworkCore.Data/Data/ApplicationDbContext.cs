using EntityFrameworkCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkCore.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=EntityFrameworkCore;Integrated Security=true");
            // TODO: Colocar informação de conexão em um arquivo
            // TODO: Incluir comando update-database no arquivo explicando o projeto
        }

        // Modelagem do Banco de Dados separado por Tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);            
        }
    }
}
