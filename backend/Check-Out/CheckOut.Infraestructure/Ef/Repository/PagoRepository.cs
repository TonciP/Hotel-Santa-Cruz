using CheckOut.Domain.Factories.pago;
using CheckOut.Domain.Model.Pagos;
using CheckOut.Domain.Repositories;
using CheckOut.Infraestructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Repository
{
    internal class PagoRepository : IPagoRepository
    {
        private readonly WriteDbContext _context;

        public PagoRepository(WriteDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Pago obj)
        {
            throw new NotImplementedException();
        }

        public async Task CreatePago(Pago obj)
        {
            await _context.Pago.AddAsync(obj);
        }

        public Task<Pago> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Pago obj)
        {
            throw new NotImplementedException();
        }
    }
}
