using MediatR;
using Reserva.Applitacion.Dto;
using Reserva.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Applitacion.UseCase.Queries.TipoHabitacion
{
    public class GetTipoHabitacionHandler 
        //: IRequestHandler<GetListaHabitacionQuery, ICollection<TipoHabitacionDto>>
    {
        private readonly ITipoHabitacionRepository _tipoHabitacionRepository;
        private readonly IUnitOfWork _unitOfWor;

        public GetTipoHabitacionHandler(ITipoHabitacionRepository tipoHabitacionRepository, IUnitOfWork unitOfWork)
        {
            _tipoHabitacionRepository = tipoHabitacionRepository;
            _unitOfWor = unitOfWork;
        }

        //public async Task<ICollection<TipoHabitacionDto>> Handle(GetListaHabitacionQuery request, CancellationToken cancellationToken)
        //{
        //    //ICollection<Domain.Model.TipoHabitaciones> items = await _tipoHabitacionRepository.GetItems();

        //    //ICollection<ItemDto> list = _mapper.Map<ICollection<Domain.Model.TipoHabitaciones>, ICollection<TipoHabitacionDto>>(items);

        //    //return list;
        //    return null;
        //}
    }
}
