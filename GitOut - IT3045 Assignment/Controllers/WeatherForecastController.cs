using Microsoft.AspNetCore.Mvc;

namespace GitOut___IT3045_Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetNameController : ControllerBase
    {
        [HttpGet(Name = "GetName")]
        public IActionResult Get()
        {
            return Ok(new { name = "Aneesh" });
        }
    }
}
