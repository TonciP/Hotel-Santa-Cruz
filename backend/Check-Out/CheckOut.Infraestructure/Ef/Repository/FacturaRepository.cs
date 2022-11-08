using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Repositories;
using CheckOut.Infraestructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Repository
{
    internal class FacturaRepository : IFacturaRepository
    {
        private readonly WriteDbContext _context;

        public FacturaRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Facturar obj)
        {
            //throw new NotImplementedException();
            await _context.Facturar.AddAsync(obj);
        }

        public Task<Facturar> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Facturar obj)
        {
            throw new NotImplementedException();
        }
    }
}
