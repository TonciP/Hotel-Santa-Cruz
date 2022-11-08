using CheckOut.Domain.Model.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.Ef.ReadModel
{
    internal class FacturaReadModel
    {
        public Guid Id { get; set; }
        public DetalleFactura DetalleFactura { get; set; }
        public int NumeroFactura { get; set; }
        public decimal Total { get; set; }

    }
}