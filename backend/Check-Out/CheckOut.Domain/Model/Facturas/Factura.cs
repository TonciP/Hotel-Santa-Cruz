using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Model.Facturas
{
    public class Factura
    {
        public string NumeroFactura { get; set; }
        public int Total { get; set; }
        public DateTime FechaFactura { get; private set; }
    }
}
