using Microsoft.AspNetCore.Mvc;

namespace K2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hi!");
        }



    }
}
