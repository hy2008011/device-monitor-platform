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
                context.SaveChanges();
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

            context.Devices.AddRange(
                new Device
                {
                    Name = "终端设备-01",
                    IpAddress = "192.168.1.101",
                    Department = "研发部",
                    Category = "办公电脑",
                    Owner = "张三",
                    IsAudited = true,
                    Status = "Online",
                    LastSeenAt = DateTime.UtcNow
                },
                new Device
                {
                    Name = "终端设备-02",
                    IpAddress = "192.168.1.102",
                    Department = "财务部",
                    Category = "办公电脑",
                    Owner = "李四",
                    IsAudited = false,
                    Status = "Offline",
                    LastSeenAt = DateTime.UtcNow.AddMinutes(-30)
                }
            );

            context.DeviceLogs.Add(new DeviceLog
            {
                DeviceName = "终端设备-01",
                LogType = "开关机日志",
                Content = "设备已启动",
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false
            });

            context.PendingEvents.Add(new PendingEvent
            {
                Title = "发现异常插U盘事件",
                Severity = "High",
                Status = "Pending",
                CreatedAt = DateTime.UtcNow
            });

            context.SaveChanges();
        }
    }
}
