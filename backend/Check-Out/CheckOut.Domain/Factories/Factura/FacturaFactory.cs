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
            return new Facturar();
        }



        public Facturar CrearFactura(DetalleFactura detalleFactura, int numeroFactura, decimal total, DateTime fechaFactura)
        {
            if (detalleFactura == null || numeroFactura == 0 || total == Decimal.Parse("0.0"))
            {
                return new Facturar();
            }
            return new Facturar(detalleFactura, numeroFactura, total, fechaFactura);
        }
    }
}
