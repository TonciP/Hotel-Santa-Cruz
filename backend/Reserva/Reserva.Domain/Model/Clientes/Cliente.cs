using Reserva.Domain.ValueObjects;
using ShareKernel.Core;

namespace Reserva.Domain.Model.Clientes
{
    public class Cliente : AggregateRoot
    {
        //public Guid ClienteId { get; private set; }
        public PersonNameValue Nombres { get;  set; }
        public PersonNameValue Apellidos { get;  set; }
        public EmailValidValue Email { get;  set; }
        public string Direccion { get;  set; }
        public TelefonoValue Telefono { get;  set; }

        //public Cliente(PersonNameValue nombres, PersonNameValue apellidos, EmailValidValue email, string direccion, TelefonoValue telefono)
        //{
        //    Id = Guid.NewGuid();
        //    Nombres = nombres;
        //    Apellidos = apellidos;
        //    Email = email;
        //    Telefono = telefono;
        //    Direccion = direccion;
        //}

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
        public Cliente() { }

    }
}
