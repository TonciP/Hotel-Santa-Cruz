using CheckOut.Domain.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Factories.pago
{
    public class PagoFactory : IPagoFactory
    {
        public Pago CreatePago()
        {
            return new Pago();
        }

        public Pago CreatePago(decimal total)
        {
            if (total == Decimal.Parse("0.0"))
            {
                return new Pago();
            }
            return new Pago(total);

        }
    }
}
