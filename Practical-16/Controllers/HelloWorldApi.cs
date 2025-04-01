using Microsoft.AspNetCore.Mvc;

namespace Practical_16.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("HelloWorldController.Get was called");
            return "Hello World!";
        }
    }
}
