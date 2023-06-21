using Microsoft.AspNetCore.Mvc;

namespace Cusquinhos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly ILogger<AnimalController> _logger;

        public AnimalController(
            ILogger<AnimalController> logger)
        {
            _logger = logger;
        }
    }
}