using Reserva.Domain.Model.cliente;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Repository
{
    internal class ClienteRepository : IClienteRepository
    {
        //private readonly WriteDbContext _context;

        public Task CreateAsync(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
