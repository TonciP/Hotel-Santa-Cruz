using CheckOut.Domain.Model.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Factories.Factura
{
    public interface IFacturaFactory
    {
        Facturar CrearFactura();
        Facturar CrearFactura(Guid facturaId, DetalleFactura detalleFactura, int numeroFactura, decimal total);

    }
}
