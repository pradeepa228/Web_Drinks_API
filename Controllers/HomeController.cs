using Microsoft.AspNetCore.Mvc;

namespace Web_Drinks_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }
}
