namespace ShowTime.Components.Models;

public class Festival
{
    public int ID { get; set; }
    public string Name { get; set; }
    public ICollection<Band> Bands { get; set; }
    public string? Description { get; set; }
}