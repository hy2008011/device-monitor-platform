namespace DeviceMonitorAPI.Models;

public class DeviceLog
{
    public int Id { get; set; }
    public string DeviceName { get; set; } = string.Empty;
    public string LogType { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
