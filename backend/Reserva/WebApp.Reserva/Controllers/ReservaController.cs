using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Commands.Reservars;

namespace WebApp.Reserva.Controllers
{
    [Route("api/reserva")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateReserva([FromBody] CreateReservarCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /*public async Task<string> Mail([FromQuery] string correo)
        {

        }*/
    }
}
