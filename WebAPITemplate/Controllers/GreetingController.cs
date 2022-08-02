using WebAPITemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPITemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly ILogger<GreetingController> _logger;
        public GreetingController(ILogger<GreetingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Get")]
        public Greeting Get()
        {
            _logger.LogInformation("Information Log Goes Here....");

            _logger.LogWarning("Warning Log Goes Here....");

            _logger.LogError("Error Log Goes Here....");

            _logger.LogCritical("Critical Log Goes Here....");

            return new Greeting 
            { 
                Message = "Greetings...."
            };
        }
    }
}
