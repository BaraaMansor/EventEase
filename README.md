# EventEase - Event Management Blazor Application

A fictional event management application built with Blazor that allows users to browse events, view details, and register for events.

## Project Structure

### Models

- **Event.cs**: Core data model with properties for Id, Name, Date, Location, and Description

### Components

- **EventCard.razor**: Reusable component displaying event information in a card format with navigation to details page
  - Includes styling with hover effects
  - Uses parameter binding to accept Event data

### Pages

1. **Events.razor** (`/events`)

   - Lists all available events using the EventCard component
   - Contains mock data for 5 sample events
   - Responsive grid layout

2. **EventDetails.razor** (`/event/{id}`)

   - Displays detailed information about a specific event
   - **Two-way data binding** implemented with `@bind` for all event fields (Name, Date, Location, Description)
   - Editable fields demonstrating dynamic updates
   - Navigation to registration page and back to events list

3. **Register.razor** (`/register/{id}`)
   - Event registration form with comprehensive fields
   - **Two-way data binding** for all form inputs:
     - Full Name
     - Email Address
     - Phone Number
     - Number of Attendees
     - Special Comments
   - Success confirmation upon registration
   - Navigation between pages

## Features Implemented

### ✅ Event Card Component

- Clean, card-based UI design
- Displays event name, date, and location
- Clickable navigation to event details
- Responsive hover effects

### ✅ Two-Way Data Binding

- **EventDetails.razor**: All event properties are editable with `@bind` directive
- **Register.razor**: Registration form fields use `@bind` with `@bind:event="oninput"` for real-time updates
- Dynamic state management within components

### ✅ Routing & Navigation

- Three main routes configured:
  - `/events` - Event listing page
  - `/event/{id}` - Event details page
  - `/register/{id}` - Registration page
- Navigation menu updated with Events link
- Inter-page navigation through buttons and links
- Route parameters for dynamic page content

### ✅ Mock Data

- Five sample events with realistic data
- Consistent data across all pages
- Event lookup by ID for details and registration

## How to Run

```powershell
dotnet run
```

Navigate to the displayed URL (typically https://localhost:5xxx) and click on "Events" in the navigation menu.

## Next Steps

Potential enhancements:

- Add form validation on registration page
- Implement state management for user sessions
- Create an attendance tracker
- Connect to a real database
- Add search/filter functionality for events
- Implement actual email confirmations

## Blazor Best Practices Followed

- Component-based architecture
- Proper use of `@code` blocks
- CSS isolation for styling
- Route parameter handling
- Parameter binding between components
- Responsive design patterns
