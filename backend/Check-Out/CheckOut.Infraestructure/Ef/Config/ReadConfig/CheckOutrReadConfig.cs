using CheckOut.Domain.Model.checkouts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckOut.Infraestructure.EF.ReadModel;

namespace CheckOut.Infraestructure.EF.Config.ReadConfig
{
    internal class CheckOutrReadConfig : IEntityTypeConfiguration<CheckOutReadModel>
    {
        public void Configure(EntityTypeBuilder<CheckOutReadModel> builder)
        {
            builder.ToTable("checkouts");

            builder.Property(x => x.Id).HasColumnName("checkoutId");

            builder.Property(x => x.CreditCartId).HasColumnName("credicartId");
            builder.Property(x => x.ClienteId).HasColumnName("clienteId");
            builder.Property(x => x.CheckIn).HasColumnName("checkInId");
            builder.HasOne(pcheckout => pcheckout._factura);
            builder.HasOne(pcheckout => pcheckout._pago);

        }
    }
}
