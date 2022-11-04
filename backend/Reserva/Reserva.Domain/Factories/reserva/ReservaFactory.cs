using Microsoft.EntityFrameworkCore.Storage;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Reservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.reserva
{
    internal class ReservaFactory : IReservaFactory
    {
        public Reservar CrearReserva(Guid? habitacionId)
        {
            if (habitacionId == null || habitacionId.Value == Guid.Empty)
            {
                throw new ArgumentException("Los campos para la reserva estan vacios");
            }
            return new Reservar(habitacionId.Value);
        }

        public Reservar CrearReserva()
        {
            throw new NotImplementedException();
        }

        public Reservar CrearReserva(Guid? habitacionId, Cliente cliente)
        {
            if (habitacionId == null || habitacionId.Value == Guid.Empty || cliente == null)
            {
                throw new ArgumentException("Los campos para la reserva estan vacios");
            }
            return new Reservar(habitacionId.Value, cliente);
        }
    }
}
