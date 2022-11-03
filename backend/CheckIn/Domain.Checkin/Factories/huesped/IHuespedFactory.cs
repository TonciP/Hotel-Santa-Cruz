using Domain.Checkin.Model.Huesped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories.cliente
{
    public interface IHuespedFactory
    {
        Huesped CrearHuesped();
        Huesped CrearHuesped(Guid? huespedId, string dni);
    }
}
