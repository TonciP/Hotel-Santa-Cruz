using CheckOut.Domain.Model.checkouts;
using CheckOut.Domain.Repositories;
using CheckOut.Infraestructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Repository
{
    internal class CheckOutRepository : ICheckOutRepository
    {
        private readonly WriteDbContext _context;
        public CheckOutRepository(WriteDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(CheckOutr obj)
        {
            await _context.CheckOutr.AddAsync(obj);
        }

        public async Task<CheckOutr> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(CheckOutr obj)
        {
            throw new NotImplementedException();
        }
    }
}
