using EventEase.Models;

namespace EventEase.Services;

public class RegistrationService
{
    private readonly List<Registration> _registrations = new();
    private int _nextId = 1;

    /// <summary>
    /// Register a user for an event
    /// </summary>
    public async Task<Registration> RegisterForEventAsync(Registration registration)
    {
        // Simulate API call delay
        await Task.Delay(500);

        registration.Id = _nextId++;
        registration.RegistrationDate = DateTime.Now;
        _registrations.Add(registration);

        return registration;
    }

    /// <summary>
    /// Get all registrations for a specific user (by email)
    /// </summary>
    public List<Registration> GetUserRegistrations(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return new List<Registration>();

        return _registrations
            .Where(r => r.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(r => r.RegistrationDate)
            .ToList();
    }

    /// <summary>
    /// Get all registrations for a specific event
    /// </summary>
    public List<Registration> GetEventRegistrations(int eventId)
    {
        return _registrations
            .Where(r => r.EventId == eventId)
            .OrderByDescending(r => r.RegistrationDate)
            .ToList();
    }

    /// <summary>
    /// Check if a user is registered for a specific event
    /// </summary>
    public bool IsUserRegistered(string email, int eventId)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        return _registrations.Any(r => 
            r.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && 
            r.EventId == eventId);
    }

    /// <summary>
    /// Get total registration count
    /// </summary>
    public int GetTotalRegistrations()
    {
        return _registrations.Count;
    }

    /// <summary>
    /// Get registration count for a specific event
    /// </summary>
    public int GetEventRegistrationCount(int eventId)
    {
        return _registrations.Count(r => r.EventId == eventId);
    }
}
