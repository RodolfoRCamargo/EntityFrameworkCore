using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Data.Migrations
{
    public partial class Procedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var script = @"CREATE PROCEDURE [dbo].[ConsultarProdutoPorNome] 
                        	@nome VARCHAR(50),
                        	@valor DECIMAL(18,2)
                        AS
                        BEGIN
                            SELECT * FROM Produto 
                        	WHERE Nome = @nome AND valor > @valor;
                        END";

            migrationBuilder.Sql(script);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var script = @"DROP PROCEDURE [dbo].[ConsultarProdutoPorNome]";

            migrationBuilder.Sql(script);
        }
    }
}
