using MediatR;
using Reserva.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Clientes
{
    public class DeleteClienteCommand : IRequest<Guid>
    {
        //public ICollection<Cliente> clientes { get; set; }
        public Cliente clientes { get; set; }


    }
}
