﻿// <auto-generated />
using System;
using GerenciamentoDeEstoqueDoacoes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoDeEstoqueDoacoes.Migrations
{
    [DbContext(typeof(EstoqueDbContext))]
    [Migration("20240507210537_newMigratoToNewModel")]
    partial class newMigratoToNewModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GerenciamentoDeEstoqueDoacoes.Models.DoacoesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("EmEstoque")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Entrege")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("HorarioDoacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeDoItem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Doacoes");
                });

            modelBuilder.Entity("GerenciamentoDeEstoqueDoacoes.Models.relacoesModel", b =>
                {
                    b.Property<string>("GridRadios")
                        .HasColumnType("varchar(255)");

                    b.HasKey("GridRadios");

                    b.ToTable("Relacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
