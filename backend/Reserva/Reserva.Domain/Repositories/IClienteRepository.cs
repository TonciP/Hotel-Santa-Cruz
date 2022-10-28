using Reserva.Domain.Model.cliente;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Repositories
{
    public interface IClienteRepository : IRepository<Cliente, Guid>
    {
        Task UpdateAsync(Cliente obj);
    }
}
