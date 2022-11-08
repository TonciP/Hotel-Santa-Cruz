using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckOut.Domain.Model.Pagos;

namespace CheckOut.Domain.Factories.pago
{
    public interface IPagoFactory
    {
        ///Task CreatePago(Pago obj);
        Pago CreatePago(decimal total);
    }
}
