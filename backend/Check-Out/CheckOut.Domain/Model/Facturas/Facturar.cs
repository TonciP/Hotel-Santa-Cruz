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
        public int NumeroFactura { get; private set; }
        public decimal Total { get; private set; }
        public DateTime FechaFactura { get; private set; }
        public DetalleFactura _detalleFactura { get; private set; }
        //public ICollection<DetalleFactura> _detalleFactura { get; set; }

        public Facturar(DetalleFactura detalleFactura, int numeroFactura, decimal total, DateTime fechaFactura)
        {
            Id = Guid.NewGuid();
            _detalleFactura = detalleFactura;
            //_detalleFactura = new ICollection<DetalleFactura>();
            NumeroFactura = numeroFactura;
            Total = total;
            FechaFactura = fechaFactura;

        }
        public void AgregarDetalleFactura(Guid servicioId, decimal precio, string descripcion)
        {
            var detalle = new DetalleFactura(servicioId, precio, descripcion);
            //_detalle.Add(detalle);
            //Total += detalle.SubTotal;

            //var evento = new DetalleFacturaAgregado(servicioId, precio, descripcion);
            //AddDomainEvent(evento);
        }
        public Facturar(){ }
    }
}
