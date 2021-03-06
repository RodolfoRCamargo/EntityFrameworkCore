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
    [Migration("20210111182157_Procedure")]
    partial class Procedure
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
                            Id = new Guid("9679b720-e797-4ff5-8e81-9069ae198274"),
                            Nome = "Caneta Bic",
                            Valor = 1m
                        },
                        new
                        {
                            Id = new Guid("f7c5f4e9-5865-4096-b0ef-ce0eb9989761"),
                            Nome = "Caneta Azul",
                            Valor = 1.39m
                        },
                        new
                        {
                            Id = new Guid("b0e0a33a-1e08-4b94-b2c4-a5f194bbfe4d"),
                            Nome = "Caneta Vermelha",
                            Valor = 1.40m
                        },
                        new
                        {
                            Id = new Guid("3c97f2df-815d-4fd9-ace1-ab6d96322a13"),
                            Nome = "Caneta Preta",
                            Valor = 1.41m
                        },
                        new
                        {
                            Id = new Guid("c73604d6-9d1d-404d-b7dc-5fede817e075"),
                            Nome = "Lápis",
                            Valor = 0.37m
                        },
                        new
                        {
                            Id = new Guid("799c3fbe-0c6d-4e69-8aa8-a246fc0d6231"),
                            Nome = "Borracha",
                            Valor = 0.74m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
