﻿// <auto-generated />
using System;
using Infrastructure.Estadia.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Estadia.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20221206205106_InitialStructure")]
    partial class InitialStructure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Estadia.EF.ReadModel.CheckinReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("checkinId");

                    b.Property<Guid>("CreditCardId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creditCardId");

                    b.Property<Guid>("HabitacionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("habitacionId");

                    b.Property<Guid>("HuespedId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("huespedId");

                    b.Property<Guid>("ReservaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("reservaId");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.HasIndex("HabitacionId");

                    b.HasIndex("HuespedId");

                    b.ToTable("Checkin", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Estadia.EF.ReadModel.CreditCardReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creditCardId");

                    b.Property<string>("NumeroTarjeta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("numero_tarjeta");

                    b.Property<string>("TipoTarjeta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tipo_tarjeta");

                    b.HasKey("Id");

                    b.ToTable("CreditCard", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Estadia.EF.ReadModel.HabitacionReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("habitacionId");

                    b.Property<string>("CaracteristicasHabitacion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("caracteristica_habitacion");

                    b.Property<string>("CodigoHabitacion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo_habitacion");

                    b.Property<string>("Disponibilidad")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("disponibilidad");

                    b.Property<string>("LimitePersona")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("limite_persona");

                    b.Property<int>("NumeroHabitacion")
                        .HasColumnType("int")
                        .HasColumnName("numero_habitacion");

                    b.Property<double>("PrecioHabitacion")
                        .HasColumnType("float")
                        .HasColumnName("precio_habitacion");

                    b.Property<Guid>("TipoHabitacion")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("tipo_habitacion");

                    b.HasKey("Id");

                    b.ToTable("Habitacion", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Estadia.EF.ReadModel.HuespedReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("huespedId");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("dni");

                    b.HasKey("Id");

                    b.ToTable("Huesped", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Estadia.EF.ReadModel.CheckinReadModel", b =>
                {
                    b.HasOne("Infrastructure.Estadia.EF.ReadModel.CreditCardReadModel", "CreditCard")
                        .WithMany()
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Estadia.EF.ReadModel.HabitacionReadModel", "Habitacion")
                        .WithMany()
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Estadia.EF.ReadModel.HuespedReadModel", "Huesped")
                        .WithMany()
                        .HasForeignKey("HuespedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditCard");

                    b.Navigation("Habitacion");

                    b.Navigation("Huesped");
                });
#pragma warning restore 612, 618
        }
    }
}
