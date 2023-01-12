using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1;

[Route("[Controller]")]
public class ItemsController : ApiController
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}
