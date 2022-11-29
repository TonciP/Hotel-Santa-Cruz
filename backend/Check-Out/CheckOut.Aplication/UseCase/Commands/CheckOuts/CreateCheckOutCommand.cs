using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.UseCase.Commands.CheckOuts
{
    public class CreateCheckOutCommand : IRequest<Guid>
    {
        public Guid _clienteId { get; set; }
        public Guid CreditCartId { get; set; }
        public Guid CheckInt { get; set; }
        public Facturar _factura { get; set; }
        public Pago _pago { get; set; }

        /*public CreateCheckOutCommand(Guid checkInt,Guid clienteId, Guid creditcarId, Facturar factura, Pago pago)
        {
            CheckInt = checkInt;
            _clienteId = clienteId;
            CreditCartId = creditcarId;
            _factura = factura;
            _pago = pago;
        }*/
    }
}
