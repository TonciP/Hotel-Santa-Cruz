using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Estadia.Model.Pagos;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class PagoWriteConfig : IEntityTypeConfiguration<Pagoss>
    {
        public void Configure(EntityTypeBuilder<Pagoss> builder)
        {
            builder.ToTable("Pago");
            builder.Property(x => x.Id).HasColumnName("pagoId");

            builder.Property(x => x.Total)
                .HasColumnName("total");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
