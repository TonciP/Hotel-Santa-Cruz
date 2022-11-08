using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Model.checkouts
{
    public class CheckOutr : AggregateRoot
    {
        public Guid _clienteId { get; private set; }
        public Guid CreditCartId { get; private set; }
        public Facturar _factura { get; private set; }
        public Pago _pago { get; private set; }
        public CheckOutr(Guid clienteId, Guid creadicartId, Facturar factura, Pago pago)
        {
            _clienteId = clienteId;
            CreditCartId = creadicartId;
            _factura = factura;
            _pago = pago;
        }

    }
}
