namespace EventEaseApp.Services {
    using EventEaseApp.Models;
   public class UserSessionService
{
    private readonly Dictionary<string, Registration> _userSessions = new();
    
    public async Task SaveRegistrationState(string sessionId, Registration registration)
    {
        _userSessions[sessionId] = registration;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Saved registration state for session {sessionId}");
        Console.ResetColor();
        await Task.CompletedTask; 
    }
    
    public async  Task<Registration?> GetRegistrationState(string sessionId)
    {
        return await Task.FromResult(_userSessions.TryGetValue(sessionId, out var registration) ? registration : null);
    }
}
}