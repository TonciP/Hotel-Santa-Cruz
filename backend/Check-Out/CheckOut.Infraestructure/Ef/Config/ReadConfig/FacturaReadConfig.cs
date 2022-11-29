using CheckOut.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Config.ReadConfig
{
    internal class FacturaReadConfig : IEntityTypeConfiguration<FacturaReadModel>
    {
        public void Configure(EntityTypeBuilder<FacturaReadModel> builder)
        {
            builder.ToTable("facturas");
            builder.Property(pfactura => pfactura.Id).HasColumnName("facturaId");

            builder.HasOne(pfactura => pfactura._detalleFactura);

            builder.Property(pfactura => pfactura.NumeroFactura).HasColumnName("numerofactura");
            builder.Property(pfactura => pfactura.Total).HasColumnName("total");
            builder.Property(pfactura => pfactura.FechaFactura).HasColumnName("fechafactura");
        }
    }
}
