using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.CheckOut
{
    public class Checkout : AggregateRoot
    {
        public Guid ClienteId { get; set; }

        public Guid CreditCardId { get; set; }

        public Guid CheckInId { get; set; }

        public Guid FacturaId { get; set; }

        public Guid PagoId { get; set; }

        public Checkout(Guid clienteId, Guid creditCardId, Guid checkInId, Guid facturaId,Guid pagoId)
        {
            Id = Guid.NewGuid();
            ClienteId = clienteId;
            CreditCardId = creditCardId;
            CheckInId = checkInId;
            FacturaId = facturaId;
            PagoId = pagoId;
        }
        public void Editcheckout(Guid clienteId, Guid creditCardId, Guid checkInId, Guid facturaId, Guid pagoId)
        {
            ClienteId = clienteId;
            CreditCardId = creditCardId;
            CheckInId = checkInId;
            FacturaId = facturaId;
            PagoId = pagoId;
        }
        // Only for Entity Framework
        public Checkout() { }
    }
}
