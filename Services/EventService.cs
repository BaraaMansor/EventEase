using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<Event> _events;

    public EventService()
    {
        // Mock data - in a real app, this would come from a database
        _events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Tech Conference 2025",
                Date = new DateTime(2025, 3, 15),
                Location = "San Francisco Convention Center",
                Description = "Join us for the biggest tech conference of the year featuring keynotes from industry leaders, hands-on workshops, and networking opportunities."
            },
            new Event
            {
                Id = 2,
                Name = "Music Festival Downtown",
                Date = new DateTime(2025, 4, 20),
                Location = "Central Park Amphitheater",
                Description = "Experience three days of incredible live music from local and international artists across multiple stages."
            },
            new Event
            {
                Id = 3,
                Name = "Food & Wine Expo",
                Date = new DateTime(2025, 5, 10),
                Location = "Metro Convention Hall",
                Description = "Taste cuisines from around the world and sample fine wines from renowned vineyards. Meet celebrity chefs and attend cooking demonstrations."
            },
            new Event
            {
                Id = 4,
                Name = "Art Gallery Opening",
                Date = new DateTime(2025, 2, 28),
                Location = "Modern Art Museum",
                Description = "Celebrate the opening of our new contemporary art exhibition featuring emerging artists. Meet the artists and enjoy complimentary refreshments."
            },
            new Event
            {
                Id = 5,
                Name = "Marathon for Charity",
                Date = new DateTime(2025, 6, 5),
                Location = "City Waterfront",
                Description = "Run for a cause! Join thousands of participants in our annual charity marathon. All proceeds benefit local children's hospitals."
            }
        };
    }

    /// <summary>
    /// Get all events
    /// </summary>
    public List<Event> GetAllEvents()
    {
        return _events.ToList();
    }

    /// <summary>
    /// Get a single event by ID
    /// </summary>
    public Event? GetEventById(int id)
    {
        return _events.FirstOrDefault(e => e.Id == id);
    }

    /// <summary>
    /// Check if an event exists
    /// </summary>
    public bool EventExists(int id)
    {
        return _events.Any(e => e.Id == id);
    }
}
