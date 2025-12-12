namespace EventEase.Models;

public class Registration
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int NumberOfAttendees { get; set; }
    public string Comments { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }
}
