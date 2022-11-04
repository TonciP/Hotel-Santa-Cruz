using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Reservas;

namespace Reserva.Domain.Factories.reserva
{
    public interface IReservaFactory
    {
        Reservar CrearReserva(Guid? habitacionId);
        Reservar CrearReserva(Guid? habitacionId, Cliente cliente);
        Reservar CrearReserva();
    }
}
