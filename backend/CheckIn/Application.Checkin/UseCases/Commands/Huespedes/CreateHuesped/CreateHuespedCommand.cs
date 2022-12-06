using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.Huespedes.CreateHuesped
{
    public class CreateHuespedCommand : IRequest<Guid>
    {
        public string DNI { get; set; }

    }
}
