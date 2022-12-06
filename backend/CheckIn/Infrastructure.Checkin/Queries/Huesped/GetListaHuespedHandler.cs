using Application.Estadia.Dto;
using Application.Estadia.UseCases.Queries.Habitacion;
using Application.Estadia.UseCases.Queries.Huesped;
using Infrastructure.Estadia.EF.Context;
using Infrastructure.Estadia.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.Queries.Huesped
{
    internal class GetListaHuespedHandler : IRequestHandler<GetListaHuespedQuery, IEnumerable<HuespedDto>>
    {
        private readonly DbSet<HuespedReadModel> huesped;

        public GetListaHuespedHandler(ReadDbContext dbContext)
        {
            huesped = dbContext.Huesped;
        }


        public async Task<IEnumerable<HuespedDto>> Handle(GetListaHuespedQuery request, CancellationToken cancellationToken)
        {
            var query = huesped.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.DniSearchTerm))
            {
                query = query.Where(x => x.DNI.Contains(request.DniSearchTerm.ToLower()));
            }

            var lista = await query.Select(x => new HuespedDto
            {
                HuespedId = x.Id,
                DNI = x.DNI,
            }).ToListAsync();

            return lista;
        }
    }
}
