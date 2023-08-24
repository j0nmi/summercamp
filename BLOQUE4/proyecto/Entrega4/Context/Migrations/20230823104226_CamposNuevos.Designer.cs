﻿// <auto-generated />
using System;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Context.Migrations
{
    [DbContext(typeof(ContextoConversor))]
    [Migration("20230823104226_CamposNuevos")]
    partial class CamposNuevos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entidades.Entities.Historial", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("cantidad")
                        .HasColumnType("float");

                    b.Property<DateTime>("fechaConversion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("monedaDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("monedaOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("resultadoConversion")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("historial");
                });

            modelBuilder.Entity("Entidades.Entities.Moneda", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("factor")
                        .HasColumnType("real");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("monedas");
                });

            modelBuilder.Entity("Entidades.Entities.Pais", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("bandera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("paises");

                    b.HasData(
                        new
                        {
                            id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b01"),
                            bandera = "ESP",
                            nombre = "Spain"
                        },
                        new
                        {
                            id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b02"),
                            bandera = "PLN",
                            nombre = "Poland"
                        },
                        new
                        {
                            id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b03"),
                            bandera = "FR",
                            nombre = "France"
                        });
                });

            modelBuilder.Entity("Entidades.Entities.Usuario", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idPais")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b31"),
                            email = "aaaa@aaaa.com",
                            fechaNacimiento = new DateTime(1980, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idPais = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b06"),
                            password = "123456"
                        },
                        new
                        {
                            id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b32"),
                            email = "bbbb@bbbb.com",
                            fechaNacimiento = new DateTime(1990, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idPais = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b05"),
                            password = "123456"
                        },
                        new
                        {
                            id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b33"),
                            email = "cccc@cccc.com",
                            fechaNacimiento = new DateTime(2000, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idPais = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b04"),
                            password = "123456"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}