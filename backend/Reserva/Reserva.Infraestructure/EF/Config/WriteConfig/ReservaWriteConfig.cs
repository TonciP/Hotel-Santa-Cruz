using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.WriteConfig
{
    internal class ReservaWriteConfig : IEntityTypeConfiguration<Reservar>
    {
        public void Configure(EntityTypeBuilder<Reservar> builder)
        {
            builder.ToTable("reservas");
            builder.Property(preserva => preserva.Id).HasColumnName("reservaId");

            builder.HasOne(preserva => preserva._tracking);
            builder.Property(preserva => preserva.HabitacionId).HasColumnName("habitacionId");
            builder.HasOne(preserva => preserva._estadia);
            builder.HasOne(preserva => preserva._cliente);

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
