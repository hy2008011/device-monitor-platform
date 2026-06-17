using DeviceMonitorAPI.DTOs;

namespace DeviceMonitorAPI.Services;

public interface IDeviceService
{
    IEnumerable<DeviceDto> GetDevices();
    DeviceDto? GetDeviceById(int id);
}
