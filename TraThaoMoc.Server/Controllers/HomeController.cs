
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace TraThaoMoc.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController: ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("ping")]
        public string Get()
        {
            return "Hello";
            
        }
    }
}
