using ShowTime.Models;
using Microsoft.EntityFrameworkCore;

namespace ShowTime.Data;

public class ShowTimeContext(DbContextOptions<ShowTimeContext> options) : DbContext(options)
{
    public DbSet<Festival> Festivals { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Band> Bands { get; set; }
    public DbSet<BandFestival> BandFestivals { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BandFestival>()
            .HasKey(bf => new { bf.BandID, bf.FestivalID });

        modelBuilder.Entity<BandFestival>()
            .HasOne(bf => bf.Band)
            .WithMany(b => b.BandFestivals)
            .HasForeignKey(bf => bf.BandID);

        modelBuilder.Entity<BandFestival>()
            .HasOne(bf => bf.Festival)
            .WithMany(f => f.BandFestivals)
            .HasForeignKey(bf => bf.FestivalID);
        

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Festival)
            .WithMany(f => f.Bookings)
            .HasForeignKey(b => b.FestivalId);
    }
}
