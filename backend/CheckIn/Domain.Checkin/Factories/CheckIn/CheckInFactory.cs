using Domain.Estadia.Model.CheckIn;
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

        public Checkin CrearCheckIn(Guid? checkinId, Guid reservaId, Guid creditCardId, Guid habitacionId, Guid huespedId)
        {
            if (checkinId == null || checkinId == Guid.Empty)
            {
                return new Checkin();
            }
            return new Checkin(reservaId, creditCardId, habitacionId,  huespedId);
        }
    }
}
