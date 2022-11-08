using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.ReadModel
{
    internal class DetalleFacturaReadModel
    {
        public Guid Id { get; set; }
        public Guid ServicioId { get; set; }
        public decimal PrecioServicio { get; set; }
        public string Descripcion { get; set; }
    }
}
