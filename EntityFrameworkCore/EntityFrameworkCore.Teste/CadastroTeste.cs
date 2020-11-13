using EntityFrameworkCore.Data.Domain;
using EntityFrameworkCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EntityFrameworkCore.Teste
{
    public class CadastroTeste
    {
        [Fact(DisplayName = "Incluir Produto"), Trait("Cadastro", "Produto")]
        public void IncluirProduto()
        {
            // Arrange

            // Act
            new ProdutoDomain().AdicionarProduto(new Produto { Id = Guid.NewGuid(), Nome = "Caneta Azul", Valor = 1 });

            // Assert
        }

        [Fact(DisplayName = "Incluir Produtos em Massa", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void IncluirProdutos()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(DisplayName = "Alterar Produto", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void AlterarProduto()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(DisplayName = "Excluir Produto", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void ExcluirProduto()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(DisplayName = "Consultar Produto", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void ConsultarProduto()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(DisplayName = "Consultar Adiantada de Produtos", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void ConsultaAdiantadaProdutos()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(DisplayName = "Validar Cadastro de Produto", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void ValidarCadastroProduto()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(DisplayName = "Validar Cadastro Data Annotation", Skip = "Desenvolver"), Trait("Cadastro", "Produto")]
        public void ValidarCadastroDataAnnotation()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
