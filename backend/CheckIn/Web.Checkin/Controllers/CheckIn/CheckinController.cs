using Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn;
using Application.Estadia.UseCases.Commands.Habitaciones.CreateHabitacion;
using Application.Estadia.UseCases.Queries.Habitacion;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Checkin.Controllers.CheckIn
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckinController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CheckinController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateHabitacion([FromBody] CreateCheckinCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
