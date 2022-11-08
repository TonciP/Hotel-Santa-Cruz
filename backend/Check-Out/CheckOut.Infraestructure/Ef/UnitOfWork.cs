using CheckOut.Infraestructure.EF.Context;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly WriteDbContext _context;

        public UnitOfWork(WriteDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
