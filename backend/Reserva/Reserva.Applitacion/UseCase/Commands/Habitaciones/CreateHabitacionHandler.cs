using MediatR;
using Reserva.Domain.Factories.habitacion;
using Reserva.Domain.Model.Habitaciones;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Habitaciones
{
    internal class CreateHabitacionHandler : IRequestHandler<CreateHabitacionCommand, Guid>
    {
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateHabitacionHandler(IHabitacionRepository habitacionRepository, IUnitOfWork unitOfWork)
        {
            _habitacionRepository = habitacionRepository;  
            _unitOfWork = unitOfWork;

        }
        public async Task<Guid> Handle(CreateHabitacionCommand request, CancellationToken cancellationToken)
        {
            Habitacion obj = new Habitacion();

            await _habitacionRepository.CreateAsync(obj);

            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}
