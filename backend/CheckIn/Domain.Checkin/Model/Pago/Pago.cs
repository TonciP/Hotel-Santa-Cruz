using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Pago
{
    public class Pago : AggregateRoot
    {
        public double Total { get; set; }
    
        public Pago(double total)
        {
            Id = Guid.NewGuid();
            Total = total;
        }
        public void EditPago(double total)
        {
            Total = total;
        }
        public Pago() { }
    }
}
