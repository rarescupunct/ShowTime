namespace ShowTime.Models;

public class Festival
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ICollection<BandFestival> BandFestivals { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}