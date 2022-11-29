using CheckOut.Aplication.UseCase.Commands.CheckOuts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.CheckOut.Controllers
{
    [Route("api/checkout")]
    [ApiController]
    public class CheckOutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CheckOutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> GenerarCheckOut([FromBody] CreateCheckOutCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCheckOut([FromBody] DeleteCheckOutCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
