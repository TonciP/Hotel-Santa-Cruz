using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Factura
{
    public class Factura : AggregateRoot
    {
        public string? DetalleFactura { get; set; }

        public int NumeroFactura { get; set; }

        public double Total { get; set; }

        public string? Fecha { get; set; }

        public Factura(string detalleFactura, int numeroFactura, double total, string fecha)
        {
            Id = Guid.NewGuid();
            DetalleFactura = detalleFactura;
            NumeroFactura = numeroFactura;
            Total = total;
            Fecha = fecha;
        }
        public void EditFactura(string detalleFactura, int numeroFactura, double total, string fecha)
        {
            DetalleFactura = detalleFactura;
            NumeroFactura = numeroFactura;
            Total = total;
            Fecha = fecha;
        }
        public Factura() { }
    }
}
