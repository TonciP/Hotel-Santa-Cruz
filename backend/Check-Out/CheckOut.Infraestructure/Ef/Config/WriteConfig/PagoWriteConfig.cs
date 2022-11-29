using CheckOut.Domain.Model.checkouts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckOut.Domain.Model.Pagos;

namespace CheckOut.Infraestructure.EF.Config.WriteConfig
{
    internal class PagoWriteConfig : IEntityTypeConfiguration<Pago>
    {
        public void Configure(EntityTypeBuilder<Pago> builder)
        {
            builder.ToTable("pagos");

            builder.Property(x => x.Id).HasColumnName("pagoId");

            builder.Property(x => x.Total).HasColumnName("total");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
