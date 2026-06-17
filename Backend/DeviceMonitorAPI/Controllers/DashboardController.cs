using Microsoft.AspNetCore.Mvc;

namespace DeviceMonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    [HttpGet("summary")]
    public IActionResult GetSummary()
    {
        var result = new
        {
            totalDevices = 128,
            onlineDevices = 120,
            offlineDevices = 8,
            pendingEvents = 5,
            todayLogs = 324,
            lastUpdated = DateTime.UtcNow
        };

        return Ok(result);
    }
}
