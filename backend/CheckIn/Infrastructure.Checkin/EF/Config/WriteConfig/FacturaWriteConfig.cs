﻿using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Estadia.Model.Facturas;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class FacturaWriteConfig : IEntityTypeConfiguration<Facturass>
    {
        public void Configure(EntityTypeBuilder<Facturass> builder)
        {
            builder.ToTable("Factura");
            builder.Property(x => x.Id).HasColumnName("facturaId");

            builder.Property(x => x.DetalleFactura)
                .HasColumnName("detalle_factura");

            builder.Property(x => x.NumeroFactura)
                .HasColumnName("numero_factura");

            builder.Property(x => x.Total)
                .HasColumnName("total");

            builder.Property(x => x.Fecha)
                .HasColumnName("fecha_factura");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");

        }
    }
}
