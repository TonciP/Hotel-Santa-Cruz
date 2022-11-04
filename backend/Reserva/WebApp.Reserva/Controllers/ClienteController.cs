using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Commands.Clientes;
using Reserva.Aplication.UseCase.Queries.Cliente;

namespace WebApp.Reserva.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchCliente([FromQuery] string? nombre = "")
        {
            var query = new GetListaCliente
            {
                nombreSearch = nombre
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClienteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
