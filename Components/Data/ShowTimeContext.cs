using ShowTime.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace ShowTime.Components.Data;

public class ShowTimeContext : DbContext
{
    public DbSet<Festival> Festivals { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Band> Bands { get; set; }
    public DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"DataSource=localhost\sa; Initial Catalog=STime; Integrated Security=True");
    }
}