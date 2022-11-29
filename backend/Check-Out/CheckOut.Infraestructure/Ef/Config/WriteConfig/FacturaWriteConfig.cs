using CheckOut.Domain.Model.Facturas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Config.WriteConfig
{
    internal class FacturaWriteConfig : IEntityTypeConfiguration<Facturar>
    {
        public void Configure(EntityTypeBuilder<Facturar> builder)
        {
            builder.ToTable("facturas");
            builder.Property(pfactura => pfactura.Id).HasColumnName("facturaId");

            builder.HasOne(pfactura => pfactura._detalleFactura);

            builder.Property(pfactura => pfactura.NumeroFactura).HasColumnName("numerofactura");
            builder.Property(pfactura => pfactura.Total).HasColumnName("total");
            builder.Property(pfactura => pfactura.FechaFactura).HasColumnName("fechafactura");

            builder.Ignore(pfactura => pfactura.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
