using CheckOut.Domain.Factories.checkouts;
using CheckOut.Domain.Model.checkouts;
using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using CheckOut.Domain.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.UseCase.Commands.CheckOuts
{
    internal class CreateCheckOutHandler : IRequestHandler<CreateCheckOutCommand, Guid>
    {
        private readonly ICheckOutRepository _checkOutRepository;
        private readonly ICheckOutFactory _checkOutFactory;
        private readonly IUnitOfWork _unitOfWord;

        public CreateCheckOutHandler(ICheckOutRepository checkOutRepository, ICheckOutFactory checkOutFactory, IUnitOfWork unitOfWork)
        {
            _checkOutRepository = checkOutRepository;
            _checkOutFactory = checkOutFactory;
            _unitOfWord = unitOfWork;

        }


        public async Task<Guid> Handle(CreateCheckOutCommand request, CancellationToken cancellationToken)
        {
            CheckOutr checkOut = new CheckOutr(request.CheckInt, request._clienteId, request.CreditCartId, request._factura, request._pago);

            await _checkOutRepository.CreateAsync(checkOut);

            await _unitOfWord.Commit();

            return checkOut.Id;
        }
    }
}
