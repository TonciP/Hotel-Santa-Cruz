using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.UseCase.Commands.CheckOuts
{
    public class DeleteCheckOutCommand : IRequest<Guid>
    {
        //public ICollection<Cliente> clientes { get; set; }
        //public Cliente clientes { get; set; }
        public Guid checoutId { get; set; }


    }
}
