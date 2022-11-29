using CheckOut.Domain.Model.checkouts;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Repositories
{
    public interface ICheckOutRepository : IRepository<CheckOutr, Guid>
    {
        Task UpdateAsync(CheckOutr obj);
        Task DeleteAsync(Guid checkoutId);
    }
}
