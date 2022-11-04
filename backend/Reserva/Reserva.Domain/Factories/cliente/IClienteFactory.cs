
using Reserva.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.cliente
{
    public interface IClienteFactory
    {
        Cliente CrearCliente();
        Cliente CrearCliente(Guid? clienteId, string nombres, string apellidos, string email, string direccion, string telefono);
    }
}
