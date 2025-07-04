﻿using ShowTime.Enums;

namespace ShowTime.Models;

public class Band
{
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Genre Genre { get; set; }
    public ICollection<BandFestival> BandFestivals { get; set; } = new List<BandFestival>();
}