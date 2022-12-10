using Application.Estadia.Dto;
using Application.Estadia.UseCases.Queries.CheckIn;
using Application.Estadia.UseCases.Queries.Habitacion;
using Infrastructure.Estadia.EF.Context;
using Infrastructure.Estadia.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.Queries.CheckIn
{
    internal class GetListaCheckinHandler : IRequestHandler<GetListaCheckinQuery, IEnumerable<CheckinDto>>
    {
        private readonly DbSet<CheckinReadModel> checkin;

        public GetListaCheckinHandler(ReadDbContext dbContext)
        {
            checkin = dbContext.Checkin;
        }


        public async Task<IEnumerable<CheckinDto>> Handle(GetListaCheckinQuery request, CancellationToken cancellationToken)
        {
            var query = checkin.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.HuespedSearchTerm))
            {
                query = query.Where(x => x.HuespedId.Equals(request.HuespedSearchTerm.ToLower()));
            }

            var lista = await query.Select(x => new CheckinDto
            {
                CheckinId = x.Id,
                ReservaId = x.ReservaId,
                CreditCard = x.CreditCard,
                HabitacionId = x.HabitacionId,
                HuespedId = x.HuespedId,
            }).ToListAsync();

            return lista;
        }
    }
}
