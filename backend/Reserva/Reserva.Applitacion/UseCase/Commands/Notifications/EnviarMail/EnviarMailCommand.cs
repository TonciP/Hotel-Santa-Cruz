using MediatR;
using Microsoft.AspNetCore.Http;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.TipoHabitaciones;
using Reserva.Domain.Model.Trackings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reserva.Applitacion.UseCase.Commands.Notifications.EnviarMail
{
    public class EnviarMailCommand : IRequest<Guid>
    {
        public TipoHabitacion TipoHabitacion { get; set; }
        public Estadia Estadia { get; set; }
        public Tracking Tracking { get; set; }
        public Cliente Cliente { get; set; }

        public string QRpah;
    }
}
