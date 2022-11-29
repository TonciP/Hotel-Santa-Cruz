using CheckOut.Domain.Model.checkouts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Config.WriteConfig
{
    internal class CheckOutrWriteConfig : IEntityTypeConfiguration<CheckOutr>
    {
        public void Configure(EntityTypeBuilder<CheckOutr> builder)
        {
            builder.ToTable("checkouts");

            builder.Property(x => x.Id).HasColumnName("checkoutId");

            builder.Property(x => x.CreditCartId).HasColumnName("credicartId");
            builder.Property(x => x.CheckIn).HasColumnName("checkinId");
            builder.HasOne(pcheckout => pcheckout._factura);
            builder.HasOne(pcheckout => pcheckout._pago);

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
