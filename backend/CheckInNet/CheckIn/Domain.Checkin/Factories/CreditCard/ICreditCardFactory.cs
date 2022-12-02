using Domain.Estadia.Model.CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public interface ICreditCardFactory
    {
        CreditCard CrearCreditCard();
        CreditCard CrearCreditCard(Guid? creditcardId,string tipoTarjeta, string numeroTarjeta);
    }
}
