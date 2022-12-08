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

            bool envio = await ReservaActionController.enviarCorreoAsync(command.Cliente, command.Tracking, command.TipoHabitacion, command.qrpath);

            if (envio)
            {
                return Ok("ok");
            }
            else
            {
                return Ok("No se envio correctamente") ;
            }
            

        }

        [HttpPost("GuardarImagen", Name = "upload")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GuardarImagen(IFormFile file)
        {
            //preparar imagen qr
            //BarcodeQRCode barcodeQR = new BarcodeQRCode("https://www.google.com/", 500, 500, null);
            //Image codeQrImage = barcodeQR.GetImage();
            //codeQrImage.ScaleAbsolute(200, 200);

            string path = @"D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\";
            bool fileExists = System.IO.File.Exists(path + file.FileName);
            //foreach (var formFile in files)
            //{
            if (!fileExists)
            {
                if (file.Length > 0)
                {
                    var filePath = "D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\" + file.FileName;

                    path =  filePath;
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                return Ok(new { success = "ok", path = path });
            }
            else
            {
                return Ok(new { success = "error", message = "No se pudo guardar la imagen por que ya se tiene una imagen con el mismo valor" });
            }

            //}

            // Process uploaded files
            // Don't rely on or trust the FileName property without validation.

            //Image.

            //return Ok("ok");
        }
    }
}
