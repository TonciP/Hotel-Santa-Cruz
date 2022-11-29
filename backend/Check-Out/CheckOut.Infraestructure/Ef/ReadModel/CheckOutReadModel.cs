using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.ReadModel
{
    internal class CheckOutReadModel
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Guid CreditCartId { get; set; }
        public Guid CheckIn { get; private set; }
        public Facturar _factura { get; private set; }
        public Pago _pago { get; private set; }
    }
}
