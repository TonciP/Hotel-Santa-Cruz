using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.cliente
{
    public class Cliente : AggregateRoot<Guid>
    {
        //public Guid ClienteId { get; private set; }
        public ClienteStringValue Nombres { get; private set; }
        public ClienteStringValue Apellidos { get; private set; }
        public EmailValue Email { get; private set; }
        public ClienteStringValue Direccion { get; private set; }
        public TelefonoValue Telefono { get; private set; }

        public Cliente(Guid clienteId, string nombres, string apellidos, string email, string direccion, string telefono)
        {
            Id = Guid.NewGuid();
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public void EditCliente(string nombres, string apellidos, string email, string direccion, string telefono)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        // Only for Entity Framework
        public Cliente() { }

    }
}
