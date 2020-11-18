using EntityFrameworkCore.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore.Data.Domain
{
    public class ProdutoDomain
    {
        public Produto ConsultarProdutoNome(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            return db.Produtos.Where(p => p.Nome == produto.Nome).FirstOrDefault();
        }

        public Produto ConsultarProdutoParteNome(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            return db.Produtos.Where(p => p.Nome.Contains(produto.Nome)).FirstOrDefault();
        }

        public List<Produto> ConsultarProdutos()
        {
            using var db = new Data.ApplicationDbContext();

            return db.Produtos.ToList();
        }

        public Produto ConsultarProdutoMemoria(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            return db.Produtos.Find(produto.Id);
        }

        public void AdicionarProduto(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            db.Add(produto);
            db.SaveChanges();
        }

        public void AdicionarProdutosMassa(List<Produto> produtos)
        {
            using var db = new Data.ApplicationDbContext();

            db.AddRange(produtos);
            db.SaveChanges();
        }

        // Atualiza apenas a informação atualizada.
        public void AlterarProduto(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            var produtoAlterar = db.Produtos.Find(produto.Id);
            produtoAlterar.Nome = produto.Nome;
            db.SaveChanges();
        }

        // Atualiza todas as informações da Entidade.
        public void AlterarProdutoTodasPropriedades(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            db.Update(produto);
            db.SaveChanges();
        }

        public void ExcluirProduto(Produto produto)
        {
            using var db = new Data.ApplicationDbContext();

            var produtoExcluir = db.Produtos.Find(produto.Id);
            db.Remove(produtoExcluir);
            db.SaveChanges();
        }
    }
}
