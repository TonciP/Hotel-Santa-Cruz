using Reserva.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.cliente
{
    public class ClienteFactory : IClienteFactory
    {
        public Cliente CrearCliente()
        {
            return new Cliente();
        }

        public Cliente CrearCliente(Guid? clienteId, string nombres, string apellidos, string email, string direccion, string telefono)
        {
            if (clienteId == null || clienteId == Guid.Empty)
            {
                return new Cliente();
            }
            return new Cliente(clienteId.Value,  nombres,  apellidos,  email,  direccion,  telefono);
        }
    }
}
