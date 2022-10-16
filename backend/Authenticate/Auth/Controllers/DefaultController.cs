using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {


        private readonly ILogger<DefaultController> _logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "/")]
        public string Get()
        {
            return "Runnin ..";
        }
    }
}