using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Domain.Repositories
{
    public interface IFacturaRepository: IRepository<Facturar, Guid>
    {
        Task CreateAsync(Facturar facturar);
        Task UpdateAsync(Facturar facturar);
    }
}
