using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ShowTime.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}