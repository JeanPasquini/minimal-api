﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalApi.Infraestrutura.Db;

#nullable disable

namespace mininal_api.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Administrador", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.Property<string>("Perfil")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar(10)"); 

                b.Property<string>("Senha")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.ToTable("Administradores");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Email = "administrador@teste.com",
                        Perfil = "Adm",
                        Senha = "123456"
                    });
            });

            modelBuilder.Entity("MinimalApi.Dominio.Entidades.Veiculo", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int>("Ano")
                    .HasColumnType("int");

                b.Property<string>("Marca")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnType("nvarchar(150)");

                b.HasKey("Id");

                b.ToTable("Veiculos");
            });
#pragma warning restore 612, 618
        }
    }
}
