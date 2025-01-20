﻿// <auto-generated />
using System;
using MiAppContactos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MiAppContactos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250113164549_AgregarPasswordUsuario")]
    partial class AgregarPasswordUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("MiAppContactos.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool?>("Activo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activo");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("apellido");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("email");

                    b.Property<int>("IdTipoNumero")
                        .HasColumnType("int")
                        .HasColumnName("idTipoNumero");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("idUsuario");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("nombre");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("numeroTelefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdTipoNumero" }, "idTipoNumero");

                    b.HasIndex(new[] { "IdUsuario" }, "idUsuario");

                    b.ToTable("contactos", (string)null);
                });

            modelBuilder.Entity("MiAppContactos.Models.TiposNumero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tiposNumeros", (string)null);
                });

            modelBuilder.Entity("MiAppContactos.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool?>("Activo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("activo");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("MiAppContactos.Models.Contacto", b =>
                {
                    b.HasOne("MiAppContactos.Models.TiposNumero", "IdTipoNumeroNavigation")
                        .WithMany("Contactos")
                        .HasForeignKey("IdTipoNumero")
                        .IsRequired()
                        .HasConstraintName("contactos_ibfk_1");

                    b.HasOne("MiAppContactos.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Contactos")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("contactos_ibfk_2");

                    b.Navigation("IdTipoNumeroNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("MiAppContactos.Models.TiposNumero", b =>
                {
                    b.Navigation("Contactos");
                });

            modelBuilder.Entity("MiAppContactos.Models.Usuario", b =>
                {
                    b.Navigation("Contactos");
                });
#pragma warning restore 612, 618
        }
    }
}
