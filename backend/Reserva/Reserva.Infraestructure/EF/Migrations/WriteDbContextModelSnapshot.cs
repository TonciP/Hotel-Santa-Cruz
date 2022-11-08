﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Infraestructure.EF.Context;

#nullable disable

namespace Reserva.Infraestructure.Ef.Migrations
{
    [DbContext(typeof(WriteDbContext))]
    partial class WriteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Reserva.Domain.Model.Clientes.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("clienteId");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("apellidos");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("direccion");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombres");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Model.Estadias.Estadia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("estadiaId");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaEntrada");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaSalida");

                    b.HasKey("Id");

                    b.ToTable("estadia", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Model.Reservas.Reservar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("reservaId");

                    b.Property<Guid>("HabitacionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("habitacionId");

                    b.Property<Guid>("_clienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("_estadiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("_trackingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("_clienteId");

                    b.HasIndex("_estadiaId");

                    b.HasIndex("_trackingId");

                    b.ToTable("reservas", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Model.Trackings.Tracking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("trackingId");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("hash");

                    b.HasKey("Id");

                    b.ToTable("Tracking", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Model.Reservas.Reservar", b =>
                {
                    b.HasOne("Reserva.Domain.Model.Clientes.Cliente", "_cliente")
                        .WithMany()
                        .HasForeignKey("_clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reserva.Domain.Model.Estadias.Estadia", "_estadia")
                        .WithMany()
                        .HasForeignKey("_estadiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reserva.Domain.Model.Trackings.Tracking", "_tracking")
                        .WithMany()
                        .HasForeignKey("_trackingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_cliente");

                    b.Navigation("_estadia");

                    b.Navigation("_tracking");
                });
#pragma warning restore 612, 618
        }
    }
}
