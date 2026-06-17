namespace DeviceMonitorAPI.DTOs;

public class LogDto
{
    public int Id { get; set; }
    public string DeviceName { get; set; } = string.Empty;
    public string LogType { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
