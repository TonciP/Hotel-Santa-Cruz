using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public class CheckInFactory : ICheckInFactory
    {
        public Checkin CrearCheckIn()
        {
            return new Checkin();
        }

        public Checkin CrearCheckIn(Guid reservaId, Guid habitacionId,CreditCard creditCardId, Guid huespedId)
        {
            if (reservaId == null ||  habitacionId == null || huespedId == null || creditCardId == null)
            {
                throw new ArgumentException("Los campos para el checkin estan vacios");
            }
            return new Checkin(reservaId, habitacionId,  huespedId);
        }
    }
}
