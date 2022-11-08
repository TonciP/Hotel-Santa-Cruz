using CheckOut.Domain.Model.Facturas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.UseCase.Commands.Facturas
{
    public class CreateFacturasCommand : IRequest<Guid>
    {
        public int NumeroFactura { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaFactura { get; private set; }
        public DetalleFactura _detalleFactura { get; set; }
    }
}
