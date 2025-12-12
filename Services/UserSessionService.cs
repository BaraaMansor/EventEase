using EventEase.Models;

namespace EventEase.Services;

public class UserSessionService
{
    private UserSession? _currentSession;

    /// <summary>
    /// Get or create the current user session
    /// </summary>
    public UserSession GetSession()
    {
        if (_currentSession == null)
        {
            _currentSession = new UserSession();
        }
        else
        {
            _currentSession.LastVisit = DateTime.Now;
            _currentSession.TotalVisits++;
        }

        return _currentSession;
    }

    /// <summary>
    /// Add an event to the user's registered events
    /// </summary>
    public void AddRegisteredEvent(int eventId)
    {
        var session = GetSession();
        if (!session.RegisteredEventIds.Contains(eventId))
        {
            session.RegisteredEventIds.Add(eventId);
        }
    }

    /// <summary>
    /// Check if user has registered for an event
    /// </summary>
    public bool IsEventRegistered(int eventId)
    {
        var session = GetSession();
        return session.RegisteredEventIds.Contains(eventId);
    }

    /// <summary>
    /// Get all registered event IDs
    /// </summary>
    public List<int> GetRegisteredEventIds()
    {
        var session = GetSession();
        return session.RegisteredEventIds.ToList();
    }

    /// <summary>
    /// Get session statistics
    /// </summary>
    public (DateTime FirstVisit, DateTime LastVisit, int TotalVisits) GetSessionStats()
    {
        var session = GetSession();
        return (session.FirstVisit, session.LastVisit, session.TotalVisits);
    }

    /// <summary>
    /// Clear the current session (for testing or logout)
    /// </summary>
    public void ClearSession()
    {
        _currentSession = null;
    }
}
