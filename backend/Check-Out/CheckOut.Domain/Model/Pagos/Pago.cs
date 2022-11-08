using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Model.Pagos
{
    public class Pago : AggregateRoot
    {
        public decimal Total { get; private set; }

        public Pago(decimal total)
        {
            Id = Guid.NewGuid();
            Total = total;

        }

    }
}
