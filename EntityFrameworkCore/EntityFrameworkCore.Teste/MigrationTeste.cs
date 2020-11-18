using EntityFrameworkCore.Data.Domain;
using EntityFrameworkCore.Data.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EntityFrameworkCore.Teste
{
    public class MigrationTeste
    {
        [Fact(DisplayName = "Consultar Produtos"), Trait("Migration", "Produto")]
        public void ConsultarProdutos()
        {
            try
            {
                // Act
                bool sucesso = new MigrationDomain().PesquisarTabelaProduto();

                // Assert
                Assert.True(sucesso);
            }
            catch (System.Exception)
            {
                // Assert
                Assert.True(false);
            }            
        }

        [Fact(DisplayName = "Consultar Produtos Carga Inicial"), Trait("Migration", "Produto")]
        public void ConsultarProdutosCargaInicial()
        {
            // Act
            List<Produto> produtos = new MigrationDomain().PesquisarCargaInicialProduto();
            var produto = produtos.First(p => p.Nome == "Caneta Azul" && p.Valor == 1.39M);
            
            // Assert
            Assert.True(produto.Nome == "Caneta Azul" && produto.Valor == 1.39M);
        }
    }
}
