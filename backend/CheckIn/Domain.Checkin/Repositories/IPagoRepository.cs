using Domain.Estadia.Model.Pago;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    internal class IPagoRepository : IRepository<Pago, Guid>
    {
        public Task CreateAsync(Pago obj)
        {
            throw new NotImplementedException();
        }

        public Task<Pago?> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
