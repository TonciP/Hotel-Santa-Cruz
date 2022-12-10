using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CreditCards;
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
        Checkin CrearCheckIn(Guid reservaId, Guid habitacionId,CreditCard creditCardId, Guid huespedId);
    }
}
