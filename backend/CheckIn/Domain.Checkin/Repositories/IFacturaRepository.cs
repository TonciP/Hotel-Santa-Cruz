using Domain.Estadia.Model.Factura;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    internal class IFacturaRepository : IRepository<Factura, Guid>
    {
        public Task CreateAsync(Factura obj)
        {
            throw new NotImplementedException();
        }

        public Task<Factura?> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
