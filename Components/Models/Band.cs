namespace ShowTime.Components.Models;

public class Band
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public ICollection<Member> Members { get; set; }
}