using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Domain.Model.Clientes;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Config.WriteConfig
{
    internal class ClienteWriteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.Property(x => x.Id).HasColumnName("clienteId");

            /*var nombreConverter = new ValueConverter<ClienteStringValue, string>(
                personNameValue => personNameValue.Value,
                stringValue => new ClienteStringValue(stringValue)
            );*/

            builder.Property(x => x.Nombres)
                //.HasConversion(nombreConverter)
                .HasColumnName("nombres");

            /*var apellidoConverter = new ValueConverter<ClienteStringValue, string>(
                personApellidoValue => personApellidoValue.Value,
                stringValue => new ClienteStringValue(stringValue)
            );*/

            builder.Property(x => x.Apellidos)
            //    .HasConversion(apellidoConverter)
                .HasColumnName("apellidos");

            /*var emailConverter = new ValueConverter<EmailValue, string>(
                emailApellidoValue => emailApellidoValue.Value,
                stringValue => new EmailValue(stringValue)
            );*/

            builder.Property(x => x.Email)
            //    .HasConversion(emailConverter)
                .HasColumnName("email");

            /*var direccionConverter = new ValueConverter<ClienteStringValue, string>(
                direccionNameValue => direccionNameValue.Value,
                stringValue => new ClienteStringValue(stringValue)
            );*/

            builder.Property(x => x.Direccion)
            //    .HasConversion(direccionConverter)
                .HasColumnName("direccion");

            /*var telefonoConverter = new ValueConverter<TelefonoValue, string>(
                telefonoNameValue => telefonoNameValue.Value,
                stringValue => new TelefonoValue(stringValue)
            );*/

            builder.Property(x => x.Telefono)
            //    .HasConversion(telefonoConverter)
                .HasColumnName("telefono");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");

        }
    }
}
