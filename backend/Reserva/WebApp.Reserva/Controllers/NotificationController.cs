using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Applitacion.UseCase.Commands.Clientes.RegistrarCliente;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.TipoHabitaciones;
using WebApp.Reserva.action;
using Reserva.Domain.Model.Trackings;
using Reserva.Applitacion.UseCase.Commands.Notifications.EnviarMail;

namespace WebApp.Reserva.Controllers
{
    [Route("api/notificacion")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        //public readonly IMediator _mediator;
        //public NotificationController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<string> EnviarMail([FromBody] EnviarMailCommand command)
        {
            //var result = await _mediator.Send(command);

            //return Ok(result);
            bool envio = ReservaActionController.enviarCorreo(command.Cliente, command.Tracking, command.TipoHabitacion);

            if (true)
            {
                return "Se envio correctamente";
            }
            else
            {
                return "No se envio correctamente"; ;
            }
            

        }
    }
}
