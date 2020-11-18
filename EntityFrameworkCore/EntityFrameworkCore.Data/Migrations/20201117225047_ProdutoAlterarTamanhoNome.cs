using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EntityFrameworkCore.Data.Migrations
{
    public partial class ProdutoAlterarTamanhoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("6ca39ea5-a341-4b01-a0ab-f0712143635d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("8eb21458-c745-4535-8123-1382dd19a23e"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("b5939da9-53a0-4900-bab7-cb1ad959e152"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c15b3028-f2f5-4918-9eb2-76693cbc2a72"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("dd14e5e2-5e27-4d02-b3e5-a249ae293e7c"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("fadf397f-b811-4b8a-a85e-be49977ccbab"));

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("38d63d27-9a85-4ac4-85ac-4b467562e058"), "Caneta Bic", 1m },
                    { new Guid("129ad12f-3927-4339-82f9-bfd66563d1c9"), "Caneta Azul", 1.39m },
                    { new Guid("61062a51-e22c-401b-a72e-15ce0228f144"), "Caneta Vermelha", 1.40m },
                    { new Guid("fb2d304d-6cbf-4fe2-85d3-b4241c3212b0"), "Caneta Preta", 1.41m },
                    { new Guid("780149fb-e95b-49b6-acea-fb42ad840e34"), "Lápis", 0.37m },
                    { new Guid("8aec92cf-4fc0-4d0b-b336-86f4b822736b"), "Borracha", 0.74m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("129ad12f-3927-4339-82f9-bfd66563d1c9"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("38d63d27-9a85-4ac4-85ac-4b467562e058"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("61062a51-e22c-401b-a72e-15ce0228f144"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("780149fb-e95b-49b6-acea-fb42ad840e34"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("8aec92cf-4fc0-4d0b-b336-86f4b822736b"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("fb2d304d-6cbf-4fe2-85d3-b4241c3212b0"));

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
    }
}
