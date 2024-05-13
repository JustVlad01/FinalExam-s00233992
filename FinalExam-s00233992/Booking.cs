using System;

namespace YourProjectName.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingsDate { get; set; }
        public int NumberOfParticipants { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
