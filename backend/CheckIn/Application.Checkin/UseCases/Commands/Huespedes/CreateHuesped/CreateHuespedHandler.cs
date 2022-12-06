using Application.Estadia.UseCases.Commands.Habitaciones.CreateHabitacion;
using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Model.Huesped;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.Huespedes.CreateHuesped
{
    internal class CreateHuespedHandler : IRequestHandler<CreateHuespedCommand, Guid>
    {
        private readonly IHuespedRepository _huespedRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateHuespedHandler(IHuespedRepository huespedRepository, IUnitOfWork unitOfWork)
        {
            _huespedRepository = huespedRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Guid> Handle(CreateHuespedCommand request, CancellationToken cancellationToken)
        {
            Huesped obj = new Huesped(request.DNI);

            await _huespedRepository.CreateAsync(obj);

            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}
