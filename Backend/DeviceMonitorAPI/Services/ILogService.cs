using DeviceMonitorAPI.DTOs;

namespace DeviceMonitorAPI.Services;

public interface ILogService
{
    IEnumerable<LogDto> GetLogs();
}
