using CheckOut.Domain.Factories.checkouts;
using CheckOut.Domain.Model.checkouts;
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
    internal class DeleteCheckOutHandler : IRequestHandler<DeleteCheckOutCommand, Guid>
    {
        private readonly ICheckOutRepository _checkOutRepository;
        private readonly ICheckOutFactory _checkOutFactory;
        private readonly IUnitOfWork _unitOfWord;

        public DeleteCheckOutHandler(ICheckOutRepository checkOutRepository, ICheckOutFactory checkOutFactory, IUnitOfWork unitOfWork)
        {
            _checkOutRepository = checkOutRepository;
            _checkOutFactory = checkOutFactory;
            _unitOfWord = unitOfWork;

        }


        public async Task<Guid> Handle(DeleteCheckOutCommand request, CancellationToken cancellationToken)
        {
            Guid checoutId = request.checoutId;
            await _checkOutRepository.DeleteAsync(checoutId);

            await _unitOfWord.Commit();

            return checoutId;
        }
    }
}
