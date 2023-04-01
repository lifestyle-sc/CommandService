using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("/api/c/[controller]")]
    [ApiController]
    public class PlatformsController : Controller
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public IActionResult TestBound()
        {
            return Ok("Welcome to platforms Controller!");
        }
    }
}
