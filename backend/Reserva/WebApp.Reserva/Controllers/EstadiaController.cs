using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Commands.Estadias;
using Reserva.Aplication.UseCase.Commands.Reservars;

namespace WebApp.Reserva.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EstadiaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EstadiaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReserva([FromBody] CreateEstadiaCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
