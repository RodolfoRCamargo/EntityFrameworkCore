using Bogus;
using EntityFrameworkCore.Data.Domain;
using EntityFrameworkCore.Data.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace EntityFrameworkCore.Teste
{
    public class CadastroTeste
    {
        [Fact(DisplayName = "Incluir Produto"), Trait("Cadastro", "Produto")]
        public void IncluirProduto()
        {
            // Arrange
            Produto produto = new Produto();
            produto.Id = Guid.NewGuid();
            var produtoFake = new Faker().Commerce;
            produto.Nome = produtoFake.Product();
            produto.Valor = decimal.Parse(produtoFake.Price(1, 100, 2, null));

            // Act
            new ProdutoDomain().AdicionarProduto(produto);
            var produtoAdicionado = new ProdutoDomain().ConsultarProdutoMemoria(produto);

            // Assert
            Assert.True(produto.Id == produtoAdicionado.Id);
        }

        [Fact(DisplayName = "Incluir Produtos em Massa"), Trait("Cadastro", "Produto")]
        public void IncluirProdutos()
        {
            // Arrange
            int qtdeProdutosAdicionados = 10;
            List<Produto> listaProdutos = new List<Produto>();
            for (int i = 0; i < qtdeProdutosAdicionados; i++)
            {
                listaProdutos.Add(new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = new Faker().Commerce.Product(),
                    Valor = decimal.Parse(new Faker().Commerce.Price(1, 100, 2, null))
                });
            }

            // Act
            int qtdeProdutosAntes = new ProdutoDomain().ConsultarProdutos().Count;
            new ProdutoDomain().AdicionarProdutosMassa(listaProdutos);
            int qtdeProdutosDepois = new ProdutoDomain().ConsultarProdutos().Count;

            // Assert
            Assert.True(qtdeProdutosAntes + qtdeProdutosAdicionados == qtdeProdutosDepois);
        }

        [Fact(DisplayName = "Alterar Produto"), Trait("Cadastro", "Produto")]
        public void AlterarProduto()
        {
            // Arrange
            Produto produto = new ProdutoDomain().ConsultarProdutoParteNome(new Produto { Nome = "Caneta Vermelha" });

            // Act
            produto.Nome = "Caneta Vermelha" + DateTime.Now.ToString("ddMMyyHHmmssffff");
            new ProdutoDomain().AlterarProduto(produto);

            // Assert
            Produto produtoAlterado = new ProdutoDomain().ConsultarProdutoNome(produto);
            Assert.Equal(produto.Nome, produtoAlterado.Nome);
        }

        [Fact(DisplayName = "Alterar Produto Todas as Propriedades"), Trait("Cadastro", "Produto")]
        public void AlterarProdutoTodasPropriedades()
        {
            // Arrange
            Produto produto = new ProdutoDomain().ConsultarProdutoParteNome(new Produto { Nome = "Caneta Vermelha" });

            // Act
            produto.Nome = "Caneta Vermelha" + DateTime.Now.ToString("ddMMyyHHmmssffff");
            new ProdutoDomain().AlterarProdutoTodasPropriedades(produto);

            // Assert
            Produto produtoAlterado = new ProdutoDomain().ConsultarProdutoNome(produto);
            Assert.Equal(produto.Nome, produtoAlterado.Nome);
        }

        [Fact(DisplayName = "Excluir Produto"), Trait("Cadastro", "Produto")]
        public void ExcluirProduto()
        {
            // Arrange
            Produto produto = new Produto();
            produto.Id = Guid.NewGuid();
            var produtoFake = new Faker().Commerce;
            produto.Nome = produtoFake.Product();
            produto.Valor = decimal.Parse(produtoFake.Price(1, 100, 2, null));

            new ProdutoDomain().AdicionarProduto(produto);
            var produtoAdicionado = new ProdutoDomain().ConsultarProdutoNome(produto);

            // Act
            new ProdutoDomain().ExcluirProduto(produtoAdicionado);

            // Assert
            Produto produtoExcluido = new ProdutoDomain().ConsultarProdutoMemoria(produtoAdicionado);
            Assert.Null(produtoExcluido);
        }

        [Fact(DisplayName = "Consultar Produto"), Trait("Cadastro", "Produto")]
        public void ConsultarProduto()
        {
            // Act
            Produto produto = new ProdutoDomain().ConsultarProdutoNome(new Produto { Nome = "Caneta Azul" });

            // Assert
            Assert.Equal("Caneta Azul", produto.Nome);
        }

        [Fact(DisplayName = "Consultar Produto em Memória"), Trait("Cadastro", "Produto")]
        public void ConsultarProdutoMemoria()
        {
            // Arrange
            Produto produtoOriginal = new ProdutoDomain().ConsultarProdutoNome(new Produto { Nome = "Caneta Azul" });

            // Act
            Produto produtoMemoria = new ProdutoDomain().ConsultarProdutoMemoria(produtoOriginal);

            // Assert
            Assert.True(produtoOriginal.Id == produtoMemoria.Id);
        }
    }
}
