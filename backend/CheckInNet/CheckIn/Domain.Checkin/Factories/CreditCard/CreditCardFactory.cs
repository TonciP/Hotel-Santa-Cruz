using Domain.Estadia.Model.CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public class CreditCardFactory : ICreditCardFactory
    {
        public CreditCard CrearCreditCard()
        {
            return new CreditCard();
        }

        public CreditCard CrearCreditCard(Guid? creditcardId, string tipoTarjeta, string numeroTarjeta)
        {
            if (creditcardId == null || creditcardId == Guid.Empty)
            {
                return new CreditCard();
            }
            return new CreditCard(tipoTarjeta, numeroTarjeta);
        }
    }
}
