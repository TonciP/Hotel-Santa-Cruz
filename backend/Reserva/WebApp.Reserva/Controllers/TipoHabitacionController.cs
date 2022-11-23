using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Aplication.UseCase.Queries.Cliente;
using Reserva.Applitacion.UseCase.Commands.Clientes.EliminarCliente;
using Reserva.Applitacion.UseCase.Commands.Clientes.RegistrarCliente;
using Reserva.Applitacion.UseCase.Commands.Habitaciones.RegistrarHabitacion;

namespace WebApp.Reserva.Controllers
{
    [Route("api/tipohabitacion")]
    [ApiController]
    public class TipoHabitacionController : ControllerBase
    {

        public readonly IMediator _mediator;
        public TipoHabitacionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTipoHabitacion([FromBody] CreateTipoHabitacionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        //[HttpDelete]
        //public async Task<IActionResult> DeleteHabitacion([FromBody] DeleteTipoHabitacionCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //}
    }
}
