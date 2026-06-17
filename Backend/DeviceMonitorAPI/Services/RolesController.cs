using Microsoft.AspNetCore.Mvc;

namespace DeviceMonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetRoles()
    {
        var roles = new[]
        {
            new { id = 1, name = "管理员", description = "系统管理员" },
            new { id = 2, name = "操作员", description = "设备监控操作员" },
            new { id = 3, name = "审计员", description = "系统审计员" }
        };

        return Ok(roles);
    }
}
