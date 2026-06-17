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

    [HttpGet("pending-events")]
    public IActionResult GetPendingEvents()
    {
        var eventsList = new[]
        {
            new { id = 1, title = "发现异常插U盘事件", severity = "High", status = "Pending" },
            new { id = 2, title = "设备离线超过30分钟", severity = "Medium", status = "Pending" }
        };

        return Ok(eventsList);
    }
}
