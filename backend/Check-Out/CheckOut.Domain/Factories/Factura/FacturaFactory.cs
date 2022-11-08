using CheckOut.Domain.Factories.Factura;
using CheckOut.Domain.Model.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Factories.factura
{
    public class FacturaFactory : IFacturaFactory
    {
        public Facturar CrearFactura()
        {
            throw new NotImplementedException();
        }

        public Facturar CrearFactura(Guid facturaId, DetalleFactura detalleFactura, int numeroFactura, decimal total)
        {
            throw new NotImplementedException();
        }
    }
}
