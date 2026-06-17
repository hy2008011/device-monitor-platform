namespace DeviceMonitorAPI.Models;

public class Device
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Owner { get; set; } = string.Empty;
    public bool IsAudited { get; set; }
    public string Status { get; set; } = "Unknown";
    public DateTime LastSeenAt { get; set; } = DateTime.UtcNow;
}
