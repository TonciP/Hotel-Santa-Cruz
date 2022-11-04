using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Model.Estadias;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class EstadiaReadConfig : IEntityTypeConfiguration<Estadia>
    {
        public void Configure(EntityTypeBuilder<Estadia> builder)
        {
            builder.ToTable("estadia");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("estadiaId");

            builder.Property(x => x.FechaIngreso)
                .HasColumnName("fechaEntrada");

            builder.Property(x => x.FechaSalida)
                .HasColumnName("fechaSalida");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");

        }
    }
}
