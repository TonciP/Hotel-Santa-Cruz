using Domain.Estadia.Factories;
using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn
{
    internal class CreateCheckinHandler : IRequestHandler<CreateCheckinCommand, Guid>
    {
        private readonly ICheckInRepository _checkinrepository;
        private readonly ICheckInFactory _checkinFactory;
        private readonly IUnitOfWork _unitOfWor;

        public CreateCheckinHandler(ICheckInRepository checkinrepository, ICheckInFactory checkinFactory, IUnitOfWork unitOfWork)
        {
            _checkinrepository = checkinrepository;
            _checkinFactory = checkinFactory;
            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(CreateCheckinCommand request, CancellationToken cancellationToken)
        {
            Guid ReservaId = request.ReservaId;

            Guid HabitacionId = request.HabitacionId;

            //CreditCard creditcard = new CreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);

            Guid HuespedId = request.HuespedId;

            Checkin obj = new Checkin(ReservaId, HabitacionId, HuespedId);

            obj.agregarCreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);

            //var obj = _reservaFactory.CrearReserva(tracking, TipoHabitacionId, estadia, cliente);
            //obj.agregarCreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);
            await _checkinrepository.CreateAsync(obj);
            await _unitOfWor.Commit();

            //obj.enviarCorreo(tracking, cliente);

            return obj.Id;
        }
    }
}
