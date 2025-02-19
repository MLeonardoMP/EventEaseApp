namespace EventEaseApp.Services {
    using EventEaseApp.Models;
    public class EventService {

        public async Task<List<Event>> GetEvents() {

            await Task.Delay(100);
            return new List<Event> {
                new Event { Id = 1, Name = "Tech Conference 2024", Description = "Annual technology conference featuring latest innovations", Location = "Seattle Convention Center", Date = "2024-06-15" },
                new Event { Id = 2, Name = "Summer Music Festival", Description = "Three-day outdoor music festival with multiple stages", Location = "Central Park", Date = "2024-07-20" },
                new Event { Id = 3, Name = "Food & Wine Expo", Description = "Culinary showcase featuring local restaurants and wineries", Location = "Downtown Exhibition Hall", Date = "2024-08-05" },
                new Event { Id = 4, Name = "Marathon Race", Description = "Annual city marathon with 5K and 10K options", Location = "City Center", Date = "2024-09-10" },
                new Event { Id = 5, Name = "Art Gallery Opening", Description = "Exhibition of contemporary artists with wine reception", Location = "Modern Art Museum", Date = "2024-10-01" }
            };
        }

    }
}
