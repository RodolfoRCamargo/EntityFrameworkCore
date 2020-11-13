using EntityFrameworkCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Data.Domain
{
    public class ProdutoDomain
    {
        public void AdicionarProduto(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            var produtoAdicionar = new Produto { Id = produto.Id, Nome = produto.Nome, Valor = produto.Valor };
            db.Add(produtoAdicionar);
            db.SaveChanges();
        }
    }
}
