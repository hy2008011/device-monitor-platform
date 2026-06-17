using DeviceMonitorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceMonitorAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Device> Devices => Set<Device>();
    public DbSet<DeviceLog> DeviceLogs => Set<DeviceLog>();
    public DbSet<PendingEvent> PendingEvents => Set<PendingEvent>();
    public DbSet<OperationLog> OperationLogs => Set<OperationLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "管理员", Description = "系统管理员" },
            new Role { Id = 2, Name = "操作员", Description = "设备监控操作员" },
            new Role { Id = 3, Name = "审计员", Description = "系统审计员" }
        );
    }
}
