using CheckOut.Domain.Model.Facturas;
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
    internal class DetalleFacturaReadConfig : IEntityTypeConfiguration<DetalleFacturaReadModel>
    {
        public void Configure(EntityTypeBuilder<DetalleFacturaReadModel> builder)
        {
            builder.ToTable("DetalleFactura");
            builder.HasKey(pDetalleFactura => pDetalleFactura.Id);
            builder.Property(pDetalleFactura => pDetalleFactura.Id).HasColumnName("detalleFacturaId");

            builder.Property(pDetalleFactura => pDetalleFactura.ServicioId).HasColumnName("servicioId") ;
            builder.Property(pDetalleFactura => pDetalleFactura.PrecioServicio).HasColumnName("precioServicio") ;
            builder.Property(pDetalleFactura => pDetalleFactura.Descripcion).HasColumnName("descripcion") ;
        }
    }
}
