using Domain.Estadia.events;
using Domain.Estadia.Model.CreditCards;
using ShareKernel.Core;

namespace Domain.Estadia.Model.CheckIn
{
    public class Checkin : AggregateRoot
    {
        public Guid ReservaId { get; set; }

        public CreditCard CreditCard { get; set; }

        public Guid HabitacionId { get; set; }

        public Guid HuespedId { get; set; }

        public Checkin(Guid reservaId, Guid habitacionId, Guid huespedId)
        {
            Id = Guid.NewGuid();
            ReservaId = reservaId;
            HabitacionId = habitacionId;
            HuespedId = huespedId;
        }
        public void agregarCreditCard(string tipoTarjeta,string numeroTarjeta)
        {
            CreditCard = new CreditCard(tipoTarjeta, numeroTarjeta);
            var evento = new CreditCardAgregado(tipoTarjeta, numeroTarjeta);
            AddDomainEvent(evento);
        }
        // Only for Entity Framework
        public Checkin() { }
    }
}
