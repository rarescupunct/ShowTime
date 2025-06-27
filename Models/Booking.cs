namespace ShowTime.Models;

public class Booking
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public Guid FestivalID { get; set; }
    public Festival Festival { get; set; }
    public DateTime Date { get; set; }
}