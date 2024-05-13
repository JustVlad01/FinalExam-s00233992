using System.Collections.Generic;

namespace YourProjectName.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
