namespace EventEaseApp.Models
{
    public class Attendance
    {
        public int EventId { get; set; }
        public int RegistrationId { get; set; }
        public DateTime CheckInTime { get; set; }
        public bool IsPresent { get; set; }
    }
}