using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.ReadModel
{
    internal class PagoReadModel
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
    }
}
