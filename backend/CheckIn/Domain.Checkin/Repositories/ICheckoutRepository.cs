using Domain.Estadia.Model.CheckOut;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    internal class ICheckoutRepository : IRepository<Checkout, Guid>
    {
        public Task CreateAsync(Checkout obj)
        {
            throw new NotImplementedException();
        }

        public Task<Checkout?> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
