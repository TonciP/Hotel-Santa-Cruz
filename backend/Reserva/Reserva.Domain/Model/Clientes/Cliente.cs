using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Clientes
{
    public class Cliente : AggregateRoot
    {
        //public Guid ClienteId { get; private set; }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public string Email { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }

        public Cliente(string nombres, string apellidos, string email, string direccion, string telefono)
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
        //public Cliente() { }

    }
}
