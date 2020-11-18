﻿// <auto-generated />
using System;
using EntityFrameworkCore.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201117225047_ProdutoAlterarTamanhoNome")]
    partial class ProdutoAlterarTamanhoNome
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityFrameworkCore.Data.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = new Guid("38d63d27-9a85-4ac4-85ac-4b467562e058"),
                            Nome = "Caneta Bic",
                            Valor = 1m
                        },
                        new
                        {
                            Id = new Guid("129ad12f-3927-4339-82f9-bfd66563d1c9"),
                            Nome = "Caneta Azul",
                            Valor = 1.39m
                        },
                        new
                        {
                            Id = new Guid("61062a51-e22c-401b-a72e-15ce0228f144"),
                            Nome = "Caneta Vermelha",
                            Valor = 1.40m
                        },
                        new
                        {
                            Id = new Guid("fb2d304d-6cbf-4fe2-85d3-b4241c3212b0"),
                            Nome = "Caneta Preta",
                            Valor = 1.41m
                        },
                        new
                        {
                            Id = new Guid("780149fb-e95b-49b6-acea-fb42ad840e34"),
                            Nome = "Lápis",
                            Valor = 0.37m
                        },
                        new
                        {
                            Id = new Guid("8aec92cf-4fc0-4d0b-b336-86f4b822736b"),
                            Nome = "Borracha",
                            Valor = 0.74m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
