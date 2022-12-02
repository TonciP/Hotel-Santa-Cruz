using iTextSharp.text;
using iTextSharp.text.pdf;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Applitacion.UseCase.Commands.Habitaciones.RegistrarHabitacion;

namespace WebApp.Reserva.Controllers
{
    [Route("api/tracking")]
    [ApiController]
    public class TrackingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrackingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GenerateQR()
        {
            //preparar imagen qr

            BarcodeQRCode barcodeQR = new BarcodeQRCode("https://www.google.com/", 500, 500, null);
            Image codeQrImage = barcodeQR.GetImage();
            codeQrImage.ScaleAbsolute(200, 200);

            return Ok("ok");
        }

    }
}
