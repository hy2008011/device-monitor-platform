using DeviceMonitorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeviceMonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogsController : ControllerBase
{
    private readonly ILogService _logService;

    public LogsController(ILogService logService)
    {
        _logService = logService;
    }

    [HttpGet]
    public IActionResult GetLogs()
    {
        return Ok(_logService.GetLogs());
    }
}
