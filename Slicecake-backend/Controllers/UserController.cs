using Microsoft.AspNetCore.Mvc;
using Note.Domain;

namespace Slicecake_backend.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    [HttpPost(Name = "PostUser")]
    public IActionResult PostUserModel()
    {
        return Ok();
    }
}