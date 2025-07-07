using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ShowTime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ShowTime.Data;

public class ShowTimeContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public DbSet<Festival> Festivals { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Band> Bands { get; set; }
    public DbSet<BandFestival> BandFestivals { get; set; }

    public ShowTimeContext(DbContextOptions<ShowTimeContext> options)
        : base(options)
    {
    }

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
        
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.ApplicationUser)
            .WithMany(u => u.Bookings)
            .HasForeignKey(b => b.ApplicationUserId)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder); // Important to include for Identity
    }
}

