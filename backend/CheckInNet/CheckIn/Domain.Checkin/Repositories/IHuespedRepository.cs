using Domain.Estadia.Model.Huesped;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    public interface IHuespedRepository : IRepository<Huesped,Guid>
    {
    }
}
