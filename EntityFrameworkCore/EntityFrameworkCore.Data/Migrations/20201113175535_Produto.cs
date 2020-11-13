using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Data.Migrations
{
    public partial class Produto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("6ca39ea5-a341-4b01-a0ab-f0712143635d"), "Caneta Bic", 1m },
                    { new Guid("b5939da9-53a0-4900-bab7-cb1ad959e152"), "Caneta Azul", 1.39m },
                    { new Guid("fadf397f-b811-4b8a-a85e-be49977ccbab"), "Caneta Vermelha", 1.40m },
                    { new Guid("c15b3028-f2f5-4918-9eb2-76693cbc2a72"), "Caneta Preta", 1.41m },
                    { new Guid("dd14e5e2-5e27-4d02-b3e5-a249ae293e7c"), "Lápis", 0.37m },
                    { new Guid("8eb21458-c745-4535-8123-1382dd19a23e"), "Borracha", 0.74m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
