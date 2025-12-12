namespace EventEase.Models;

public class UserSession
{
    public string SessionId { get; set; } = Guid.NewGuid().ToString();
    public DateTime FirstVisit { get; set; } = DateTime.Now;
    public DateTime LastVisit { get; set; } = DateTime.Now;
    public int TotalVisits { get; set; } = 1;
    public List<int> RegisteredEventIds { get; set; } = new();
}
