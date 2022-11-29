using Domain.Estadia.Model.CreditCard;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    public interface ICreditCardRepository : IRepository<CreditCard,Guid>
    {
    }
}
