//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.qrcode;
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
        [HttpPost]
        public async Task<IActionResult> GenerateQR(IFormFile file)
        {
            //preparar imagen qr
            //BarcodeQRCode barcodeQR = new BarcodeQRCode("https://www.google.com/", 500, 500, null);
            //Image codeQrImage = barcodeQR.GetImage();
            //codeQrImage.ScaleAbsolute(200, 200);

            string path = "D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\";
            bool dirExists = Directory.Exists(path + file.FileName);
            //foreach (var formFile in files)
            //{
            if (dirExists)
            {
                if (file.Length > 0)
                {
                    var filePath = "D:\\UNIVERSIDAD_SEMESTRES\\Ingeneer-2022-2\\Taller-Ingenieria-Web\\Proyecto\\Develop\\Hotel-Santa-Cruz\\image\\" + file.FileName;

                    path += " " + filePath;
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                return Ok(new { success = "ok", path = path });
            }
            else
            {
                return Ok(new { success = "error", message =  "No se pudo guardar la imagen por que ya se tiene una imagen con el mismo valor" });
            }
                
            //}

            // Process uploaded files
            // Don't rely on or trust the FileName property without validation.

            


            //Image.

            //return Ok("ok");
        }


    }
}
