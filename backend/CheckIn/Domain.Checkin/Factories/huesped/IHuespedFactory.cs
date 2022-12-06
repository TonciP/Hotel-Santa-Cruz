using Domain.Estadia.Model.Huesped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories
{
    public interface IHuespedFactory
    {
        
        public Huesped CrearHuesped(Guid? huespedId,string? dni);

        public Huesped CrearHuesped();
    }
}
