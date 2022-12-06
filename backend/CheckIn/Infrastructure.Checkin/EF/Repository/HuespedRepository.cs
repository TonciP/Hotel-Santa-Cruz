using Domain.Estadia.Model.Huesped;
using Domain.Estadia.Repositories;
using Infrastructure.Estadia.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Repository
{
    internal class HuespedRepository : IHuespedRepository
    {
        private readonly WriteDbContext _context;

        public HuespedRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Huesped obj)
        {
            await _context.Huesped.AddAsync(obj);
        }

        public async Task DeleteAsync(Guid huespedId)
        {
            var huesped = _context.Huesped.Find(huespedId);
            _context.Remove(huesped);
            await _context.SaveChangesAsync();
        }

        public async Task<Huesped?> FindByIdAsync(Guid id)
        {
            return await _context.Huesped.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Huesped obj)
        {
            _context.Huesped.Update(obj);
            return Task.CompletedTask;
        }
    }
}
