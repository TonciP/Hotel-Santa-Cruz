using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Commands.Reservars;

namespace WebApp.Reserva.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IMediator _mediator;

        public ReservaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> CreateReserva([FromBody] CreateReservarCommand command)
        {

            return Ok();
        }
    }
}
