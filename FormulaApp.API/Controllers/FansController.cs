using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FansController : ControllerBase
{
  [HttpGet(Name = "GetFans")]
  public async Task<IActionResult> Get()
  {
    return Ok("fans");
  }
}