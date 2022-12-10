using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Model.Huespedes;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    public interface IHuespedRepository : IRepository<Huesped, Guid>
    {
        Task CreateAsync(Huesped obj);
        Task UpdateAsync(Huesped obj);
        Task DeleteAsync(Guid huespedId);
    }
}
