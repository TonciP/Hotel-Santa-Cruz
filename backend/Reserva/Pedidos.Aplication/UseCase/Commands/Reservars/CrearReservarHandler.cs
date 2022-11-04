using MediatR;
using Reserva.Domain.Factories.reserva;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Reservars
{
    internal class CrearReservarHandler 
        //: IRequestHandler<CreateReservarCommand, Guid>
    {
        private readonly IReservarRepository _reservapository;
        private readonly IReservaFactory _reservaFactory;
        private readonly IUnitOfWork _unitOfWor;

        public CrearReservarHandler(IReservarRepository reservarRepository, IReservaFactory reservaFactory, IUnitOfWork unitOfWork)
        {
            _reservapository = reservarRepository;
            _reservaFactory = reservaFactory;
            _unitOfWor = unitOfWork;

        }
        /*public Task<Guid> Handle(CreateReservarCommand request, CancellationToken cancellationToken)
        {
            var reservar = _reservaFactory.CrearReserva();
        }*/
    }
}
