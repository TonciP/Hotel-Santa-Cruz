using CheckOut.Domain.Factories.Factura;
using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.UseCase.Commands.Facturas
{
    internal class CreateFacturasHandler : IRequestHandler<CreateFacturasCommand, Guid>
    {
        private readonly IFacturaFactory _facturaFactory;
        private readonly IFacturaRepository _facturaRepository;
        private readonly IUnitOfWork _unitOfWord;
        public CreateFacturasHandler(IFacturaFactory facturaFactory, IFacturaRepository facturaRepository, IUnitOfWork unitOfWork)
        {
            _facturaFactory = facturaFactory;
            _facturaRepository = facturaRepository;
            _unitOfWord = unitOfWork;
        }
        public async Task<Guid> Handle(CreateFacturasCommand request, CancellationToken cancellationToken)
        {
            Facturar facturar = new Facturar(request._detalleFactura, request.NumeroFactura, request.Total, request.FechaFactura);

            await _facturaRepository.CreateAsync(facturar);

            await _unitOfWord.Commit();

            return facturar.Id;
        }
    }
}
