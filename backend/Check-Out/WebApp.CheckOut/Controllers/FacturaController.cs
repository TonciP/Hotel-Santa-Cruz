using CheckOut.Aplication.UseCase.Commands.CheckOuts;
using CheckOut.Aplication.UseCase.Commands.Facturas;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.CheckOut.Controllers
{
    [Route("api/factura")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FacturaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> GenerarCheckOut([FromBody] CreateFacturasCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


    }
}
