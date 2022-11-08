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
        public Guid CheckIn { get; private set; }
        public Guid _clienteId { get; private set; }
        public Guid CreditCartId { get; private set; }
        public Facturar _factura { get; private set; }
        public Pago _pago { get; private set; }

        public CheckOutr(Guid checkIn, Guid clienteId, Guid creadicartId, Facturar factura, Pago pago)
        {
            if (checkIn == Guid.Empty || clienteId == Guid.Empty || creadicartId == Guid.Empty || factura == null || pago == null)
            {
                throw new ArgumentException("El (checkIn, clienteId, creadicartId, factura, pago) no puede ser vacio");
            }

            Id = Guid.NewGuid();
            CheckIn = checkIn;
            _clienteId = clienteId;
            CreditCartId = creadicartId;
            _factura = factura;
            _pago = pago;
        }

        public CheckOutr() { }

    }
}
