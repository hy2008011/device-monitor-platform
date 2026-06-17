namespace DeviceMonitorAPI.Models;

public class PendingEvent
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Severity { get; set; } = "Medium";
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
