namespace ShowTime.Models;

public class BandFestival
{
    public Guid FestivalID { get; set; }
    public Festival Festival { get; set; }
    
    public Guid BandID { get; set; }
    public Band Band { get; set; }
    
    public int Order { get; set; }
}