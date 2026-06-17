using DeviceMonitorAPI.Data;
using DeviceMonitorAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DeviceMonitorAPI.Services;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<UserDto> GetUsers()
    {
        return _context.Users
            .AsNoTracking()
            .Include(u => u.Role)
            .Select(u => new UserDto
            {
                Id = u.Id,
                UserName = u.UserName,
                FullName = u.FullName,
                Email = u.Email,
                IsActive = u.IsActive,
                RoleName = u.Role != null ? u.Role.Name : string.Empty
            })
            .ToList();
    }
}
