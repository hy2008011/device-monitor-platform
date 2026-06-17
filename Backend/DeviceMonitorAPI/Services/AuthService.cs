using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DeviceMonitorAPI.Services;

public class AuthService : IAuthService
{
    private readonly IConfiguration _configuration;

    public AuthService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(string userName, string roleName)
    {
        var jwtKey = _configuration["Jwt:Key"] ?? "ThisIsADevelopmentOnlyJwtKey1234567890";
        var jwtIssuer = _configuration["Jwt:Issuer"] ?? "DeviceMonitorPlatform";
        var jwtAudience = _configuration["Jwt:Audience"] ?? "DeviceMonitorPlatform.Client";

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, userName),
            new Claim(ClaimTypes.Role, roleName)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: jwtIssuer,
            audience: jwtAudience,
            claims: claims,
            expires: DateTime.UtcNow.AddHours(8),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public bool ValidateUser(string userName, string password)
    {
        return userName == "admin" && password == "admin123";
    }
}
