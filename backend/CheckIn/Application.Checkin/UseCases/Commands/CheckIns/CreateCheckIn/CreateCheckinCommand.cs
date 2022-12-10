using Domain.Estadia.Model.CreditCards;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn
{
    public class CreateCheckinCommand : IRequest<Guid>
    {
        public Guid ReservaId { get; set; }

        public CreditCard CreditCard { get; set; }

        public Guid HabitacionId { get; set; }

        public Guid HuespedId { get; set; }

    }
}
