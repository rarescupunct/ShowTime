﻿using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using ShowTime.Components;
using ShowTime.Data;
using ShowTime.Enums;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementation{

    public class RepositoryBand: RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context)
        {
        }

        
         public async Task<IEnumerable<Band>> GetByGenreAsync(Genre genre)
        {
            return await Context.Bands.Where(b => b.Genre == genre).ToListAsync();
        }

        public async Task<IEnumerable<Band>> GetAvailableByIdAsync(Guid festivalID)
        {
            
            var assignedBandIds = await Context.BandFestivals
                .Where(bf => bf.FestivalID == festivalID)
                .Select(bf => bf.BandID)
                .ToListAsync();

            
            return await Context.Bands
                .Where(b => !assignedBandIds.Contains(b.Id))
                .ToListAsync();
        }


        public async Task AddBFContextAsync(Band band, Festival festival)
        {
            var exists = await Context.BandFestivals
                .AnyAsync(x => x.BandID == band.Id && x.FestivalID == festival.ID);

            if (!exists)
            {
                var bf = new BandFestival
                {
                    BandID = band.Id,
                    FestivalID = festival.ID,
                    Order = 1
                };

                await Context.BandFestivals.AddAsync(bf);
                var changes = await Context.SaveChangesAsync();
                Console.WriteLine($"Saved changes: {changes}");
            }
        }
    }
}