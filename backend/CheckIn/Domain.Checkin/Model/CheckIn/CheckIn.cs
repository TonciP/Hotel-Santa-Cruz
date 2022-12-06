using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.CheckIn
{
    public class Checkin : AggregateRoot
    {
        public Guid ReservaId { get; set; }

        public Guid CreditCardId { get; set; }

        public Guid HabitacionId { get; set; }

        public Guid HuespedId { get; set; }

        public Checkin(Guid reservaId, Guid creditCardId, Guid habitacionId, Guid huespedId)
        {
            Id = Guid.NewGuid();
            ReservaId = reservaId;
            CreditCardId = creditCardId;
            HabitacionId = habitacionId;
            HuespedId = huespedId;
        }
        public void EditCheckIn(Guid reservaId,Guid creditCardId, Guid habitacionId, Guid huespedId)
        {
            ReservaId = reservaId;
            CreditCardId = creditCardId;
            HabitacionId = habitacionId;
            HuespedId = huespedId;
        }
        // Only for Entity Framework
        public Checkin() { }
    }
}
