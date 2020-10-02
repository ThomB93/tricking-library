using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        public string Index()
        {
            return "Hello World";
        }
    }
}
