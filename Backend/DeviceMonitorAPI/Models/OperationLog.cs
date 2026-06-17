namespace DeviceMonitorAPI.Models;

public class OperationLog
{
    public int Id { get; set; }
    public string OperatorName { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
