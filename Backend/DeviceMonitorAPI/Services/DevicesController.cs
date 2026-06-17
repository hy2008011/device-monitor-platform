using DeviceMonitorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeviceMonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevicesController : ControllerBase
{
    private readonly IDeviceService _deviceService;

    public DevicesController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    [HttpGet]
    public IActionResult GetDevices()
    {
        return Ok(_deviceService.GetDevices());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetDevice(int id)
    {
        var device = _deviceService.GetDeviceById(id);
        if (device is null)
        {
            return NotFound(new { message = "设备不存在" });
        }

        return Ok(device);
    }
}
