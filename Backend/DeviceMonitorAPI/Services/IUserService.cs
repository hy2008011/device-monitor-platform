using DeviceMonitorAPI.DTOs;

namespace DeviceMonitorAPI.Services;

public interface IUserService
{
    IEnumerable<UserDto> GetUsers();
}
