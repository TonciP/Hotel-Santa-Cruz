using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Model.Facturas
{
    public class DetalleFactura : Entity
    {
        public Guid ServicioId { get; private set; }
        public decimal PrecioServicio { get; private set; }
        public string Descripcion { get; private set; }

         public DetalleFactura(Guid servicioId, decimal precioServicio, string descripcion)
        {
            Id = Guid.NewGuid();
            ServicioId = servicioId;
            PrecioServicio = precioServicio;
            Descripcion = descripcion;
        }

    }
}
