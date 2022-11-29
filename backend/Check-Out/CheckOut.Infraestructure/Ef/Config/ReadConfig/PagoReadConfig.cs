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
    internal class PagoReadConfig : IEntityTypeConfiguration<PagoReadModel>
    {
        public void Configure(EntityTypeBuilder<PagoReadModel> builder)
        {
            builder.ToTable("pagos");

            builder.Property(x => x.Id).HasColumnName("pagoId");

            builder.Property(x => x.Total).HasColumnName("total");
        }
    }
}
