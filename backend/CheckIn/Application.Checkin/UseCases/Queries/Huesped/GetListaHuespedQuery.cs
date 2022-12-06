using Application.Estadia.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Queries.Huesped
{
    public class GetListaHuespedQuery : IRequest<IEnumerable<HuespedDto>>
    {
        public string DniSearchTerm { get; set; }
    }
}
