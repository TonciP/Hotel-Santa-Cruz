using Reserva.Domain.Event;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Habitaciones;
using Reserva.Domain.Model.Trackings;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Reservas
{

    public class Reservar : AggregateRoot
    {
        //public Tracking _tracking { get; private set; }
        public Guid? TrackingId { get; private set; }
        public Guid? HabitacionId { get; private set; }

        public string Estado { get; private set; }
        public Estadia _estadia { get; private set; }
        public Guid ClienteId{ get; private set; }

        public Reservar(Guid? trackingId, Guid? habitacionId, Estadia estadiaId, Guid clienteId)
        {
            if (trackingId == Guid.Empty || habitacionId == null || estadiaId == null)
            {
                throw new ArgumentException("El (tracking, habitacion, estadia, cliente) no puede ser vacio");
            }

            Id = Guid.NewGuid();
            TrackingId = trackingId;
            HabitacionId = habitacionId;
            _estadia = estadiaId;
            ClienteId = clienteId;
        }

        public void enviarCorreo(Tracking trackingId,Cliente clienteId)
        {
            var evento = new MailReservaAgregado(trackingId, clienteId);
            AddDomainEvent(evento);
        }

    }
}
