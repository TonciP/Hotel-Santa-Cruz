using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Pagos
{
    public class Pagoss : Entity
    {
        public double Total { get; set; }
    
        public Pagoss(double total)
        {
            Id = Guid.NewGuid();
            Total = total;
        }
        public Pagoss() { }
    }
}
