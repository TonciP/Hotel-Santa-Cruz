using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.CreditCard
{
    public class CreditCard : AggregateRoot<Guid>
    {
        public string TipoTarjeta { get; set; }

        public string NumeroTarjeta { get; set; }

        public CreditCard(string tipoTarjeta, string numeroTarjeta)
        {
            Id = Guid.NewGuid();
            TipoTarjeta = tipoTarjeta;
            NumeroTarjeta = numeroTarjeta;
        }
        public void EditCreditCard(string tipoTarjeta, string numeroTarjeta)
        {
            
            TipoTarjeta = tipoTarjeta;
            NumeroTarjeta = numeroTarjeta;
        }
        public CreditCard() { }
    }
}
