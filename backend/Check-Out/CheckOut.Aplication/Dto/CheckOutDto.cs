using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.Dto
{
    internal class CheckOutDto
    {
        public Guid CheckIn { get;  set; }
        public Guid _clienteId { get;  set; }
        public Guid CreditCartId { get;  set; }
        public Facturar _factura { get;  set; }
        public Pago _pago { get;  set; }
    }
}
