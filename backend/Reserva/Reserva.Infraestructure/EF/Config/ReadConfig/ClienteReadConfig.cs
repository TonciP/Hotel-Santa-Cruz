using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.ReadConfig
{
    internal class ClienteReadConfig : IEntityTypeConfiguration<ClienteReadModel>
    {
        public void Configure(EntityTypeBuilder<ClienteReadModel> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("clienteId");

            builder.Property(x => x.Nombres)
                .HasColumnName("nombres")
                .HasMaxLength(500);

            builder.Property(x => x.Apellidos)
                .HasColumnName("apellidos")
                .HasMaxLength(500);

            builder.Property(x => x.Email)
                .HasColumnName("email");

            builder.Property(x => x.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(500);

            builder.Property(x => x.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(500);
        }
    }
}
