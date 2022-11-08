using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.Ef.ReadModel
{
    internal class CheckOutReadModel
    {
        public Guid ClienteId { get; set; }
        public Guid CreditCartId { get; set; }
    }
}
