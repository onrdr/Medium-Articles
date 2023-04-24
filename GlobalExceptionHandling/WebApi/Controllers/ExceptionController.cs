using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExceptionController : ControllerBase
{
    [HttpGet(Name = "GetException")]
    public IEnumerable<IActionResult> Get()
    {
        throw new Exception("Something went wrong");
    }
}