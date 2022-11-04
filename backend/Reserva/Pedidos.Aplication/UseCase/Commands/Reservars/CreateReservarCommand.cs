using MediatR;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Reservars
{
    public class CreateReservarCommand : IRequest<Guid>
    {
        public Cliente Cliente { get; set; }
        public Tracking Tracking { get; set; }
        public Guid HabitacionId { get; set; }
        public Estadia Estadia { get; set; }

        public CreateReservarCommand(Guid habitacionId, Cliente cliente, Tracking tracking, Estadia estadia)
        {
            Cliente = cliente;
            Tracking = tracking;
            Estadia = estadia;
            HabitacionId = habitacionId;

        }
    }
}
