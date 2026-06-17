using DeviceMonitorAPI.Models;

namespace DeviceMonitorAPI.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Users.Any())
        {
            var adminRole = context.Roles.FirstOrDefault(r => r.Id == 1);
            if (adminRole is null)
            {
                adminRole = new Role
                {
                    Id = 1,
                    Name = "管理员",
                    Description = "系统管理员"
                };
                context.Roles.Add(adminRole);
            }

            context.Users.Add(new User
            {
                UserName = "admin",
                PasswordHash = "admin123",
                FullName = "系统管理员",
                Email = "admin@example.com",
                IsActive = true,
                RoleId = adminRole.Id,
                CreatedAt = DateTime.UtcNow
            });

            context.SaveChanges();
        }
    }
}
