namespace DeviceMonitorAPI.Services;

public interface IAuthService
{
    string GenerateToken(string userName, string roleName);
    bool ValidateUser(string userName, string password);
}
