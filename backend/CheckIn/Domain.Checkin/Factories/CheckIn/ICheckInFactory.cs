using Domain.Estadia.Model.CheckIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public interface ICheckInFactory
    {
        Checkin CrearCheckIn();
        Checkin CrearCheckIn(Guid? checkinId, Guid reservaId, Guid creditCardId, Guid habitacionId, Guid huespedId);
    }
}
