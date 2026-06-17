using DeviceMonitorAPI.Data;
using DeviceMonitorAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DeviceMonitorAPI.Services;

public class DeviceService : IDeviceService
{
    private readonly ApplicationDbContext _context;

    public DeviceService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<DeviceDto> GetDevices()
    {
        return _context.Devices
            .AsNoTracking()
            .Select(d => new DeviceDto
            {
                Id = d.Id,
                Name = d.Name,
                IpAddress = d.IpAddress,
                Department = d.Department,
                Category = d.Category,
                Owner = d.Owner,
                IsAudited = d.IsAudited,
                Status = d.Status,
                LastSeenAt = d.LastSeenAt
            })
            .ToList();
    }

    public DeviceDto? GetDeviceById(int id)
    {
        return _context.Devices
            .AsNoTracking()
            .Where(d => d.Id == id)
            .Select(d => new DeviceDto
            {
                Id = d.Id,
                Name = d.Name,
                IpAddress = d.IpAddress,
                Department = d.Department,
                Category = d.Category,
                Owner = d.Owner,
                IsAudited = d.IsAudited,
                Status = d.Status,
                LastSeenAt = d.LastSeenAt
            })
            .FirstOrDefault();
    }
}
