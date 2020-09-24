﻿// <auto-generated />
using GerenciamentoHerois.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciamentoHerois.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200922052733_PopularTabelas")]
    partial class PopularTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciamentoHerois.Models.Heroi", b =>
                {
                    b.Property<int>("HeroiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura")
                        .HasColumnType("int")
                        .HasMaxLength(5);

                    b.Property<string>("Codinome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasMaxLength(5);

                    b.Property<int>("PoderId")
                        .HasColumnType("int");

                    b.HasKey("HeroiID");

                    b.HasIndex("PoderId");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("GerenciamentoHerois.Models.Poder", b =>
                {
                    b.Property<int>("PoderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("TipoPoder")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("PoderId");

                    b.ToTable("Poderes");
                });

            modelBuilder.Entity("GerenciamentoHerois.Models.Heroi", b =>
                {
                    b.HasOne("GerenciamentoHerois.Models.Poder", "Poder")
                        .WithMany("Herois")
                        .HasForeignKey("PoderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
