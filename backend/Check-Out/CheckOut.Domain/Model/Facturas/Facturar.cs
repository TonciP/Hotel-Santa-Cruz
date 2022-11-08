using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Model.Facturas
{
    public class Facturar : AggregateRoot
    {
        public string NumeroFactura { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaFactura { get; private set; }
        public DetalleFactura _detalleFactura { get; set; }

        public Facturar()
        {

        }
    }
}
