using CheckOut.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckOut.Domain.Model.Facturas;

namespace CheckOut.Infraestructure.EF.Config.WriteConfig
{
    internal class DetalleFacturaWriteConfig : IEntityTypeConfiguration<DetalleFactura>
    {
        public void Configure(EntityTypeBuilder<DetalleFactura> builder)
        {
            builder.ToTable("DetalleFactura");
            builder.HasKey(pDetalleFactura => pDetalleFactura.Id);
            builder.Property(pDetalleFactura => pDetalleFactura.Id).HasColumnName("detalleFacturaId");

            builder.Property(pDetalleFactura => pDetalleFactura.ServicioId).HasColumnName("servicioId");
            builder.Property(pDetalleFactura => pDetalleFactura.PrecioServicio).HasColumnName("precioServicio").HasPrecision(4,1);
            builder.Property(pDetalleFactura => pDetalleFactura.Descripcion).HasColumnName("descripcion");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
