﻿using MediatR;
using Reserva.Domain.Factories.reserva;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.Trackings;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Reservars
{
    internal class CrearReservarHandler : IRequestHandler<CreateReservarCommand, Guid>
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
        public async Task<Guid> Handle(CreateReservarCommand request, CancellationToken cancellationToken)
        {
            Cliente cliente = new Cliente(request.Cliente.nombres, request.Cliente.apellidos,
                request.Cliente.email, request.Cliente.direccion, request.Cliente.telefono);

            Tracking tracking = new Tracking(request.Tracking.Hash);

            Estadia estadia = new Estadia(request.Estadia.FechaIngreso, request.Estadia.FechaSalida);

            Guid HabitacionId = request.HabitacionId;

            Reservar obj = new Reservar(tracking, HabitacionId, estadia, cliente);

            obj.enviarCorreo(tracking, cliente);
            //var reserva = _reservaFactory.CrearReserva(request.HabitacionId);
            //reserva.agregar(request.Tracking,request.Estadia, request.Cliente);

            await _reservapository.CreateAsync(obj);
            await _unitOfWor.Commit();

            return obj.Id;
        }
    }
}
