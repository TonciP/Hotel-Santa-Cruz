using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Reserva.Controllers
{
    public class ClienteController : Controller
    {
        public readonly IMediator _mediator;
        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
