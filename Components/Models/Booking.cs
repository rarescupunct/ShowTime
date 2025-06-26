namespace ShowTime.Components.Models;

public class Booking
{
    public string Id { get; set; }
    public DateTime Date { get; set; }
    public int Price { get; set; }
    public int UserId { get; set; }
    public ICollection<Festival> FestivalID { get; set; }
}