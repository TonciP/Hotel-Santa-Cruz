﻿using CheckOut.Domain.Factories.checkouts;
using CheckOut.Domain.Model.checkouts;
using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Factories.checkout
{
    public class CheckOutFactory : ICheckOutFactory
    {
        public CheckOutr GenerarCheckOut()
        {
            throw new NotImplementedException();
        }

        public CheckOutr GenerarCheckOut(Guid clienteId, Guid creadicartId, Facturar factura, Pago pago)
        {
            throw new NotImplementedException();
        }
    }
}
