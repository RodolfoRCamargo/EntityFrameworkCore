using EntityFrameworkCore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore.Data.Domain
{
    public class MigrationDomain
    {
        public bool PesquisarTabelaProduto()
        {
            using var db = new Data.ApplicationDbContext();

            var consultarProdutos = db.Produtos.ToList();
            return consultarProdutos.Count() >= 0;
        }

        public List<Produto> PesquisarCargaInicialProduto()
        {
            using var db = new Data.ApplicationDbContext();

            List<Produto> consultarProdutos = db.Produtos.ToList();
            return consultarProdutos;
        }
    }
}
