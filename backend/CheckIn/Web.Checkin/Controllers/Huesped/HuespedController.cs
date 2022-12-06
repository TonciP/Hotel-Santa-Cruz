using Application.Estadia.UseCases.Commands.Habitaciones.CreateHabitacion;
using Application.Estadia.UseCases.Commands.Huespedes.CreateHuesped;
using Application.Estadia.UseCases.Queries.Habitacion;
using Application.Estadia.UseCases.Queries.Huesped;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Checkin.Controllers.Huesped
{
    [Route("api/[controller]")]
    [ApiController]
    public class HuespedController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HuespedController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchHuesped([FromQuery] string? dni = "")
        {
            var query = new GetListaHuespedQuery
            {
                DniSearchTerm = dni
            };
            var result = await _mediator.Send(query);
            return Ok(result);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateHuesped([FromBody] CreateHuespedCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
