using Microsoft.AspNetCore.Mvc;
using Web_Drinks_API.Models;

namespace Web_Drinks_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string name)
        {
            var coffee = new Coffee();
            if (name != null)
            {
                coffee.Name = name;
                coffee.Id = 7;
            }
            else
            {
                coffee.Name = "latte";
                coffee.Id = -1;
            }
            return coffee;
        }
        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }
    }
}
