using DeviceMonitorAPI.DTOs;
using DeviceMonitorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeviceMonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (!_authService.ValidateUser(request.UserName, request.Password))
        {
            return Unauthorized(new { message = "用户名或密码错误" });
        }

        var token = _authService.GenerateToken(request.UserName, "管理员");

        return Ok(new LoginResponse
        {
            Token = token,
            UserName = request.UserName,
            RoleName = "管理员",
            ExpiresAt = DateTime.UtcNow.AddHours(8)
        });
    }
}
