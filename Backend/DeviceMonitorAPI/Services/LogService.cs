using DeviceMonitorAPI.Data;
using DeviceMonitorAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DeviceMonitorAPI.Services;

public class LogService : ILogService
{
    private readonly ApplicationDbContext _context;

    public LogService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<LogDto> GetLogs()
    {
        return _context.DeviceLogs
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => new LogDto
            {
                Id = x.Id,
                DeviceName = x.DeviceName,
                LogType = x.LogType,
                Content = x.Content,
                CreatedAt = x.CreatedAt
            })
            .ToList();
    }
}
