using ShowTime.Models;
using Microsoft.EntityFrameworkCore;

namespace ShowTime.Data;

public class ShowTimeContext(DbContextOptions<ShowTimeContext> options) : DbContext(options)
{
    public DbSet<Festival> Festivals { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Band> Bands { get; set; }
}
