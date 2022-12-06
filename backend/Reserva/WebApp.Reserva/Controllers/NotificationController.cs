using MediatR;

using Microsoft.AspNetCore.Mvc;

using WebApp.Reserva.action;

using Reserva.Applitacion.UseCase.Commands.Notifications.EnviarMail;

namespace WebApp.Reserva.Controllers
{
    [Route("api/notificacion")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        public readonly IMediator _mediator;
        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> EnviarMail([FromBody] EnviarMailCommand command)
        {
            //var result = await _mediator.Send(command);

            //return Ok(result);




            bool envio = await ReservaActionController.enviarCorreoAsync(command.Cliente, command.Tracking, command.TipoHabitacion, command.QRpah);

            if (true)
            {
                return Ok("ok");
            }
            else
            {
                return Ok("No se envio correctamente") ;
            }
            

        }
    }
}
